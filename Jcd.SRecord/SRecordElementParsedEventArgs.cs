using System;

namespace Jcd.SRecord
{
    /// <inheritdoc />
    public class SRecordElementParsedEventArgs : EventArgs
    {
        /// <summary>
        /// The parsed element containing the results of parsing.
        /// (successful, type parsed, error, error message, exception...etc.)
        /// </summary>
        public SRecordElement Element { get; }

        /// <summary>
        /// Constructs an instance of <c>SRecordElementParsedEventArgs</c>.
        /// </summary>
        /// <param name="element">The parsed element containing the results of parsing.</param>
        public SRecordElementParsedEventArgs(SRecordElement element)
        {
            Element = element;
        }
    }
}