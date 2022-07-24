using Jcd.SRecord.Parsers;

namespace Jcd.SRecord.IO
{
    /// <summary>
    /// Defines the interface needed to format an <c>SRecordLine</c>
    /// </summary>
    public interface ISRecordLineFormatter
    {
        /// <summary>
        /// Formats an <c>SRecordLine</c> as a line of text.
        /// </summary>
        /// <param name="line">the line to format.</param>
        /// <returns>
        /// Null indicates no line was generated. String.Empty indicates
        /// that a blank line was generated. <c>SRecordLineWriter</c>
        /// will discard null results. Depending on options settings, it may write
        /// blank lines.
        /// </returns>
        string Format(SRecordLine line);
    }
}