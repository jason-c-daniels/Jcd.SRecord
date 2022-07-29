using System;

namespace Jcd.SRecord
{
    /// <summary>
    /// Provides context for the SRecordElementParser.Parsing event.
    /// </summary>
    public class SRecordElementParsingEventArgs : EventArgs
    {
        /// <summary>
        /// The line number for the line of text being parsed.
        /// </summary>
        public int LineNumber { get; }
        
        /// <summary>
        /// The original line of text to parse.
        /// </summary>
        public string OriginalLineOfText { get; }
        
        /// <summary>
        /// Constructs a new instance of <c>SRecordElementParsingEventArgs</c>
        /// </summary>
        /// <param name="lineNumber">The line number.</param>
        /// <param name="originalLineOfText">The original line of text.</param>

        public SRecordElementParsingEventArgs(int lineNumber, string originalLineOfText)
        {
            LineNumber = lineNumber;
            OriginalLineOfText = originalLineOfText;
        }
    }
}