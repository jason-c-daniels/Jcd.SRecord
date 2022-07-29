using System;
using System.Diagnostics.CodeAnalysis;

namespace Jcd.SRecord
{
    /// <summary>
    /// Provides context for the SRecordElementFormatter.Formatted event.
    /// </summary>
    public class SRecordElementFormattedEventArgs : EventArgs 
    {
        /// <summary>
        /// Gets a flag indicating if the formatting attempt was successful.
        /// </summary>
        public bool Succeeded { get; }
        
        
        /// <summary>
        /// Gets the element that was formatted. 
        /// </summary>
        public SRecordElement Element { get; }
        
        
        /// <summary>
        /// Gets the text resulting from formatting.
        /// </summary>
        public string FormattedText { get; }
        
        
        /// <summary>
        /// Constructs an instance of <c>SRecordElementFormattedEventArgs</c>
        /// </summary>
        /// <param name="succeeded">A flag indicating if the formatting attempt was successful.</param>
        /// <param name="element">The element that was formatted.</param>
        /// <param name="formattedText">The text resulting from formatting.</param>

        public SRecordElementFormattedEventArgs(bool succeeded,[NotNull] SRecordElement element, string formattedText=null)
        {
            Succeeded = succeeded;
            Element = element;
            FormattedText = formattedText;
        }
        
    }
}