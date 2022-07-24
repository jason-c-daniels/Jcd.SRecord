using System;

namespace Jcd.SRecord.IO
{
    /// <summary>
    /// Represents a single line in an <c>SRecordDocument</c>
    /// </summary>
    public class SRecordElement
    {
        /// <summary>
        /// The line in the file where the text was found.
        /// </summary>
        public int LineNumber { get; }
        
        /// <summary>
        /// The SRecord parsed from the line (if any) 
        /// </summary>
        public SRecord SRecord { get; }
        
        /// <summary>
        /// The comment text (lines starting with a ';' '#' ...etc are comment lines.) 
        /// </summary>
        public string Comment { get; }
        
        /// <summary>
        /// True if the line recognized as an SRecord and/or comment. False otherwise.
        /// When false, OriginalLine should be populated with the extracted line of text, without end of line character(s).
        /// Also, ErrorMessage should be populated with the error encountered while trying to parse the line. 
        /// </summary>
        public SRecordElementType ElementType { get; }
        
        /// <summary>
        /// The original line of text. A well constructed parser will always provide this. The default one does.
        /// </summary>
        public string OriginalLine { get; }

        /// <summary>
        /// Contains a parser specific error message associated with attempting to parse this line.
        /// </summary>
        public string ErrorMessage { get; }

        /// <summary>
        /// An exception that happened while trying to parse the line of text.
        /// </summary>
        public Exception Exception { get; }

        /// <summary>
        /// Constructs an instance of an <c>SRecordElement</c>
        /// </summary>
        /// <param name="lineNumber">The line number in the file.</param>
        /// <param name="elementType">The elementType of line.</param>
        /// <param name="sRecord">the parsed and validated <c>SRecord</c> instance.</param>
        /// <param name="comment">The comment text, without the comment character.</param>
        /// <param name="originalLine">The original full text of the line.</param>
        /// <param name="errorMessage">An error message, populated when elementType is false.</param>
        /// <param name="exception">An exception that occurred during parsing of the SRecord entry.</param>
        public SRecordElement(int lineNumber, SRecordElementType elementType, SRecord sRecord = null,
                           string comment = null, string originalLine = null, string errorMessage = null,
                           Exception exception = null)
        {
            LineNumber = lineNumber;
            SRecord = sRecord;
            Comment = comment;
            ElementType = elementType;
            OriginalLine = originalLine;
            ErrorMessage = errorMessage;
            Exception = exception;
        }
        
    }
}