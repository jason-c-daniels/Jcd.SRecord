using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Jcd.SRecord.Extensions;
using Jcd.SRecord.Parsers;

namespace Jcd.SRecord.IO
{
    /// <summary>
    /// Provides a simplistic manner of parsing SRecords
    /// </summary>
    public class SRecordLineParser : ISRecordLineParser
    {
        private readonly SRecordParser _sRecordSRecordParser;
        private readonly char[] _commentCharacters;

        public SRecordParser SRecordParser => _sRecordSRecordParser;

        /// <summary>
        /// Gets a copy of the comment characters in use.
        /// </summary>
        public ReadOnlyCollection<char> CommentCharacters => Array.AsReadOnly(_commentCharacters);

        /// <summary>
        /// The default set of comment characeters we'll parse.
        /// </summary>
        public static readonly ReadOnlyCollection<char> DefaultCommentCharacters = Array.AsReadOnly(new[]{ '#', ';' });

        /// <summary>
        /// A default instance configured with reasonable, flexible, defaults. It should parse most any line.
        /// </summary>
        public static readonly SRecordLineParser Default = new SRecordLineParser(SRecordParser.Default, DefaultCommentCharacters);
        
        /// <summary>
        /// A default instance configured with reasonable, flexible, defaults. It should parse most any line.
        /// </summary>
        public static readonly SRecordLineParser NoComments = new SRecordLineParser(SRecordParser.Default, null);

        /// <summary>
        /// Indicates if comments are allowed. To Allow comments pass a set of
        /// recognized comment characters in to the constructor. 
        /// </summary>
        public bool AllowComments => _commentCharacters.Length > 0;

        /// <summary>
        /// Constructs an SRecordLineParser from an <c>SRecordParser</c>
        /// and an optional set of comment characters.
        /// </summary>
        /// <param name="sRecordParser"></param>
        /// <param name="commentCharacters"></param>
        public SRecordLineParser(SRecordParser sRecordParser=null,
                                 IEnumerable<char> commentCharacters=null)
        {
            _sRecordSRecordParser = sRecordParser ?? SRecordParser.Flexible;
            _commentCharacters = commentCharacters?.ToArray() ?? Array.Empty<char>();
            // ensure we're dealing with characters we're not already trying to parse elsewhere.
            foreach (var commentCharacter in _commentCharacters)
            {
                commentCharacter.ThrowArgumentExceptionIfNotValidForSRecordComment();
            }
        }

        /// <summary>
        /// Parses a line of text into an SRecordLine.
        /// </summary>
        /// <param name="lineNumber">The line number.</param>
        /// <param name="lineOfText">The raw text.</param>
        /// <returns>an SRecordLine describing the parsing results.</returns>
        public SRecordLine Parse(int lineNumber, [NotNull]string lineOfText)
        {
            var originalLineOfText = lineOfText;
            try
            {
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
                    return new SRecordLine(lineNumber, 
                        lineType: SRecordLineType.Blank, 
                        originalLine: originalLineOfText);
                
                if (AllowComments && lineOfText!.Length == 0)
                    return new SRecordLine(lineNumber, 
                        lineType: SRecordLineType.Comment, 
                        comment: comment, originalLine: originalLineOfText);
                
                if (!lineOfText![0].Equals(SRecordType.RecordStartCharacter))
                    return new SRecordLine(lineNumber,
                        lineType: SRecordLineType.Error,
                        originalLine: originalLineOfText,
                        errorMessage: $"Unrecognized starting character: {lineOfText[0].ToString()}");

                return new SRecordLine(lineNumber,
                    lineType: comment == null ? SRecordLineType.SRecord : SRecordLineType.SRecordWithEndOfLineComment,
                    sRecord: _sRecordSRecordParser.Parse(lineOfText), comment: comment, originalLine: originalLineOfText);
            }
            catch (Exception ex)
            {
                return new SRecordLine(lineNumber, 
                    lineType: SRecordLineType.Error, 
                    originalLine: originalLineOfText, 
                    errorMessage: "SRecord structure is invalid.", 
                    exception: ex);
            }
        }

        (string processable, string comment) SplitLineOnComment([NotNull]string line)
        {
            var splits=line.Split(_commentCharacters,2);
            return splits.Length == 2 ? (splits[0], splits[1]) : (line, null);
        }

    }
}