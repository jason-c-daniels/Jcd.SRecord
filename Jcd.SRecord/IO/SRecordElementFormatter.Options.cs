using Jcd.SRecord.Extensions;

namespace Jcd.SRecord.IO
{
    public partial class SRecordElementFormatter
    {
        /// <summary>
        /// Represents the formatting options desired when writing <c>SRecordElement</c> contents
        /// to an <c>SRecordElementWriter</c>.
        /// </summary>
        public struct Options
        {
            /// <summary>
            /// Tells the formatter to ignore all other directives, and just emit the original line of text.
            /// </summary>
            public readonly bool EmitOriginalText;

            /// <summary>
            /// Tells the formatter if end of line comments should be emitted.
            /// </summary>
            public readonly bool EmitComment;

            /// <summary>
            /// Tells the formatter to emit the SRecord when present. This is usually true.
            /// </summary>
            public readonly bool EmitSRecordContent;

            /// <summary>
            /// Tells the formatter if a space should be emitted before an end of line comment.
            /// </summary>
            public readonly bool EmitSpaceBeforeEndOfLineComment;

            /// <summary>
            /// Indicates if the formatter should emit an error line as a commented out line.
            /// In order for a comment line to be emitted, EmitComment must also be true.
            /// If false, a blank line or null will be generated for error lines (depending on blank line handling).
            /// </summary>
            public readonly bool EmitErrorLineAsCommentLine;

            /// <summary>
            /// Indicates if the formatter should emit a blank line as an empty string or null.
            /// When false, lines that would format to an empty string, become null instead.
            /// </summary>
            public readonly bool EmitBlankLineAsEmptyString;

            /// <summary>
            /// The character to use when emitting a comment.
            /// </summary>
            public readonly char CommentCharacter;

            /// <summary>
            /// Constructs a set of options to control the behavior of SRecordElementFormatter.
            /// </summary>
            /// <param name="emitSRecordContent">Tells the formatter to emit the SRecord when present.</param>
            /// <param name="emitComment">Tells the formatter if end of line comments should be emitted.</param>
            /// <param name="emitSpaceBeforeEndOfLineComment"></param>
            /// <param name="emitOriginalText">Tells the formatter to ignore all other directives, and just emit the original line of text.</param>
            /// <param name="emitBlankLineAsEmptyString"></param>
            /// <param name="emitErrorLineAsCommentLine"></param>
            /// <param name="commentCharacter"></param>
            public Options(bool emitSRecordContent = false,
                           bool emitComment = false,
                           bool emitSpaceBeforeEndOfLineComment = false,
                           bool emitOriginalText = false,
                           bool emitBlankLineAsEmptyString = false,
                           bool emitErrorLineAsCommentLine = false,
                           char commentCharacter = '#')
            {
                commentCharacter.ThrowArgumentExceptionIfNotValidForSRecordComment();
                CommentCharacter = commentCharacter;
                EmitSRecordContent = emitSRecordContent;
                EmitOriginalText = emitOriginalText;
                EmitComment = emitComment;
                EmitSpaceBeforeEndOfLineComment = emitSpaceBeforeEndOfLineComment;
                EmitErrorLineAsCommentLine = emitErrorLineAsCommentLine;
                EmitBlankLineAsEmptyString = emitBlankLineAsEmptyString;
            }

            /// <summary>
            /// A convenience instance that is configured to only emit <c>SRecord</c> line and only the <c>SRecord</c> data.
            /// </summary>
            public static readonly Options OnlyEmitSRecordData = new Options(emitErrorLineAsCommentLine: true);
            
            /// <summary>
            /// A convenience instance that is configured to only emit comment data.
            /// </summary>
            public static readonly Options OnlyEmitCommentData = new Options(emitComment: true);

            /// <summary>
            /// A convenience instance that is configured to emit <c>SRecord</c> line and comment data.
            /// </summary>
            public static readonly Options EmitSRecordAndCommentData =
                new Options(emitSRecordContent: true, emitComment: true);

            /// <summary>
            /// A convenience instance that is configured to emit <c>SRecord</c>
            /// line and comment data. For end of line comments after <c>SRecord</c>
            /// data, a space is inserted before the comment character.
            /// </summary>
            public static readonly Options EmitSRecordAndCommentDataWithSpace = new Options(emitSRecordContent: true,
                emitComment: true, emitSpaceBeforeEndOfLineComment: true);

            /// <summary>
            /// A convenience instance that is configured to emit <c>SRecord</c> line and comment data.
            /// As well <c>SRecordElement</c>s flagged as having an error will be emitted as commented out
            /// lines. (SRecordElement.OriginalLine is used, otherwise preserving the whole line.) 
            /// </summary>
            public static readonly Options CommentOutErrorLines = new Options(emitSRecordContent: true,
                emitComment: true, emitSpaceBeforeEndOfLineComment: true, emitErrorLineAsCommentLine:true);

            /// <summary>
            /// A convenience instance that is configured to only emit the original text.
            /// </summary>
            public static readonly Options OnlyEmitOriginalText = new Options(emitOriginalText: true);

            /// <summary>
            /// See <c>EmitSRecordAndCommentDataWithSpace</c>
            /// </summary>
            public static Options DefaultOptions => EmitSRecordAndCommentDataWithSpace;

        }
    }
}