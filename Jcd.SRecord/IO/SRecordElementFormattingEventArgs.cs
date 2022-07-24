using System;
using System.Diagnostics.CodeAnalysis;

namespace Jcd.SRecord.IO
{
    /// <inheritdoc />
    public class SRecordElementFormattingEventArgs : EventArgs
    {
        /// <summary>
        /// The element to be formatted.
        /// </summary>
        public SRecordElement Element { get; }
        
        /// <summary>
        /// Constructs a <c>SRecordElementFormattingEventArgs</c> instance.
        /// </summary>
        /// <param name="element">The element to be formatted.</param>

        public SRecordElementFormattingEventArgs([NotNull] SRecordElement element)
        {
            Element = element;
        }
    }
}