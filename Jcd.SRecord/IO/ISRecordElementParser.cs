using System;
// ReSharper disable UnusedMemberInSuper.Global

namespace Jcd.SRecord.IO
{
    /// <summary>
    /// Defines the operations necessary to parse <c>SRecordElement</c>s
    /// from text.
    /// </summary>
    public interface ISRecordElementParser
    {
        /// <summary>
        /// A flag indicating if comments will be parsed and removed before interpreting
        /// the <c>SRecord</c> data.
        /// </summary>
        bool AllowComments { get; }

        /// <summary>
        /// Parses a line of text into an SRecordElement.
        /// </summary>
        /// <param name="lineNumber">The line number.</param>
        /// <param name="lineOfText">The raw text.</param>
        /// <returns>an SRecordElement describing the parsing results.</returns>
        SRecordElement Parse(int lineNumber, string lineOfText);

        /// <summary>
        /// An event indicating that parsing has begun.
        /// </summary>
        // ReSharper disable once EventNeverSubscribedTo.Global
        public event EventHandler<SRecordElementParsingEventArgs> Parsing;
        
        /// <summary>
        /// An event that indicates parsing has finished.
        /// </summary>
        // ReSharper disable once EventNeverSubscribedTo.Global
        public event EventHandler<SRecordElementParsedEventArgs> Parsed;
    }
}