using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Jcd.SRecord.Extensions;

namespace Jcd.SRecord.IO
{
    /// <summary>
    /// Provides a default mechanism for parsing a line of text into
    /// an <c>SRecordElement</c>.
    /// </summary>
    public class SRecordElementParser : ISRecordElementParser
    {
        private readonly ISRecordParser _sRecordParser;
        private readonly char[] _commentCharacters;

        /// <summary>
        /// An event indicating parsing of a line of text has begun.
        /// The data on the argument is the original line of text.
        /// </summary>
        public event EventHandler<SRecordElementParsingEventArgs> Parsing;
        
        /// <summary>
        /// An event indicating parsing has finished.
        /// The data on the argument is the element resulting from parsing.
        /// </summary>
        public event EventHandler<SRecordElementParsedEventArgs> Parsed;

        /// <summary>
        /// Gets the <c>ISRecordParser</c> instance used to parse the <c>SRecord</c> data
        /// from a line of text.
        /// </summary>
        public ISRecordParser RecordParser => _sRecordParser;

        /// <summary>
        /// Gets a copy of the comment characters in use.
        /// </summary>
        public ReadOnlyCollection<char> CommentCharacters { get; }

        /// <summary>
        /// The default set of comment characters we'll parse.
        /// </summary>
        public static readonly ReadOnlyCollection<char> DefaultCommentCharacters = Array.AsReadOnly(new[]{ '#', ';' });

        /// <summary>
        /// A default instance configured with reasonable, flexible, defaults. It should parse
        /// most any line.
        /// </summary>
        public static SRecordElementParser Default => Flexible;
        
        /// <summary>
        /// An <c>SRecordElementParser</c> configured to accept either '#' or ';' as comment
        /// characters,  and to allow up to 250-252 (SRecordType dependent) data bytes in the
        /// <c>SRecord</c> data.
        /// </summary>
        public static readonly SRecordElementParser Flexible = new SRecordElementParser(SRecordParser.Flexible, DefaultCommentCharacters);

        /// <summary>
        /// An <c>SRecordElementParser</c> configured to accept no comments, and to allow up
        /// to 250-252 (SRecordType dependent) data bytes in the <c>SRecord</c> data.
        /// </summary>
        public static readonly SRecordElementParser FlexibleNoComments = new SRecordElementParser(SRecordParser.Flexible);

        /// <summary>
        /// An <c>SRecordElementParser</c> configured to accept either '#' or ';' as comment
        /// characters,  and to allow up to 32 (SRecordType dependent) data bytes in the
        /// <c>SRecord</c> data.
        /// </summary>
        public static readonly SRecordElementParser Strict = new SRecordElementParser(SRecordParser.Strict, DefaultCommentCharacters);

        /// <summary>
        /// An <c>SRecordElementParser</c> configured to accept no comments, and to allow up
        /// to 250-252 (SRecordType dependent) data bytes in the <c>SRecord</c> data.
        /// </summary>
        public static readonly SRecordElementParser StrictNoComments = new SRecordElementParser(SRecordParser.Strict);

        /// <summary>
        /// Indicates if comments are allowed. To Allow comments pass a set of
        /// recognized comment characters in to the constructor. 
        /// </summary>
        public bool AllowComments => _commentCharacters.Length > 0;

        /// <summary>
        /// Constructs an <c>SRecordElementParser</c> from an <c>ISRecordParser</c>
        /// and an optional set of comment characters.
        /// </summary>
        /// <param name="sRecordParser">The ISRecordParser instance to use.</param>
        /// <param name="commentCharacters">The comment characters to accept when parsing.</param>
        public SRecordElementParser(ISRecordParser sRecordParser=null,
                                    IEnumerable<char> commentCharacters=null)
        {
            _sRecordParser = sRecordParser ?? SRecordParser.Flexible;
            _commentCharacters = commentCharacters?.ToArray() ?? Array.Empty<char>();

            // ensure we're dealing with characters we're not already trying to parse elsewhere.
            foreach (var commentCharacter in _commentCharacters)
                commentCharacter.ThrowArgumentExceptionIfNotValidForSRecordComment();

            CommentCharacters = Array.AsReadOnly(_commentCharacters);
        }

        /// <summary>
        /// Parses a line of text into an SRecordElement.
        /// </summary>
        /// <param name="lineNumber">The line number.</param>
        /// <param name="lineOfText">The raw text.</param>
        /// <returns>an SRecordElement describing the parsing results.</returns>
        public SRecordElement Parse(int lineNumber, [NotNull]string lineOfText)
        {
            var originalLineOfText = lineOfText;
            try
            {
                RaiseParsingEvent(lineNumber, originalLineOfText);
                string comment = null;
                if (AllowComments)
                {
                    (lineOfText, comment) = SplitLineOnComment(lineOfText);
                }
                
                /*
                 remove trailing whitespace, because I'm nice... and I didn't want to 
                 field questions about why " # comment" is an invalid line, while 
                 "# comment" is a valid line. Plus it makes parsing end of line comments
                 easier. ("S9030000FC # a comment" and "S9030000FC# a comment" 
                         become equivalent when doing this.)
                */                
                lineOfText = lineOfText.TrimEnd();

                if (string.IsNullOrWhiteSpace(lineOfText) && comment == null)
                    return ProcessResult(new SRecordElement(lineNumber,
                        elementType: SRecordElementType.Blank,
                        originalLine: originalLineOfText)
                    );
                
                if (AllowComments && lineOfText!.Length == 0)
                    return ProcessResult(new SRecordElement(lineNumber, 
                        elementType: SRecordElementType.Comment, 
                        comment: comment, originalLine: originalLineOfText)
                    );
                
                if (!lineOfText![0].Equals(SRecordType.RecordStartCharacter))
                    return ProcessResult(new SRecordElement(lineNumber,
                        elementType: SRecordElementType.Error,
                        originalLine: originalLineOfText,
                        errorMessage: $"Unrecognized starting character: {lineOfText[0].ToString()}")
                    );

                return ProcessResult(new SRecordElement(lineNumber,
                    elementType: comment == null ? SRecordElementType.SRecord : SRecordElementType.SRecordWithEndOfElementComment,
                    sRecord: _sRecordParser.Parse(lineOfText), comment: comment, originalLine: originalLineOfText)
                );
            }
            catch (Exception ex)
            {
                return ProcessResult(new SRecordElement(lineNumber, 
                    elementType: SRecordElementType.Error, 
                    originalLine: originalLineOfText, 
                    errorMessage: "SRecord structure is invalid.", 
                    exception: ex)
                );
            }
        }
        
        private SRecordElement ProcessResult(SRecordElement element)
        {
            RaiseParsedEvent(element);
            return element;
        }

        private void RaiseParsingEvent(int lineNumber, string originalLineOfText)
        {
            Parsing?.Invoke(this,new SRecordElementParsingEventArgs(lineNumber, originalLineOfText));
        }
        
        private void RaiseParsedEvent(SRecordElement element)
        {
            Parsed?.Invoke(this,new SRecordElementParsedEventArgs(element));
        }

        (string processable, string comment) SplitLineOnComment([NotNull]string line)
        {
            var splits=line.Split(_commentCharacters,2);
            return splits.Length == 2 ? (splits[0], splits[1]) : (line, null);
        }
    }
}