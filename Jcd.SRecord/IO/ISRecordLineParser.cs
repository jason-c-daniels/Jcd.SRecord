namespace Jcd.SRecord.Parsers
{
    public interface ISRecordLineParser
    {
        bool AllowComments { get; }

        /// <summary>
        /// Parses a line of text into an SRecordLine.
        /// </summary>
        /// <param name="lineNumber">The line number.</param>
        /// <param name="lineOfText">The raw text.</param>
        /// <returns>an SRecordLine describing the parsing results.</returns>
        SRecordLine Parse(int lineNumber, string lineOfText);
    }
}