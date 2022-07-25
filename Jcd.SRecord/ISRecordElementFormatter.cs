using System;

namespace Jcd.SRecord
{
    /// <summary>
    /// Defines the operations necessary to support formatting
    /// <c>SRecordElement</c>s to lines of text.
    /// </summary>
    public interface ISRecordElementFormatter
    {
        /// <summary>
        /// Formats an <c>SRecordElement</c> as a element of text.
        /// </summary>
        /// <param name="element">the element to format.</param>
        /// <returns>
        /// Null indicates no element was generated. String.Empty indicates
        /// that a blank element was generated. <c>SRecordElementWriter</c>
        /// will discard null results. Depending on options settings, it may write
        /// blank lines.
        /// </returns>
        string Format(SRecordElement element);
        
        /// <summary>
        /// An event indicating that formatting has begun.
        /// </summary>
        // ReSharper disable once EventNeverSubscribedTo.Global
        public event EventHandler<SRecordElementFormattingEventArgs> Formatting;
        
        /// <summary>
        /// An event that indicates formatting has finished.
        /// </summary>
        // ReSharper disable once EventNeverSubscribedTo.Global
        public event EventHandler<SRecordElementFormattedEventArgs> Formatted;

    }
}