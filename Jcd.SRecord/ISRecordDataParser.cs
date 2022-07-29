using System;

namespace Jcd.SRecord
{
    /// <summary>
    /// Defines the operations necessary in order to support parsing text into <c>SRecordData</c> instances.
    /// </summary>
    public interface ISRecordDataParser
    {
        /// <summary>
        /// Parses a line of text into an <c>SRecordData</c>, ignoring trailing whitespace.
        /// </summary>
        /// <param name="lineOfText">The line of text to parse.</param>
        /// <returns>An <c>SRecordData</c> instance if it was successfully parsed.</returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="Exception"></exception>
        SRecordData Parse(string lineOfText);

        /// <summary>
        /// Tries parsing a line of text into an <c>SRecordData</c>
        /// </summary>
        /// <param name="lineOfText">the text to try parsing.</param>
        /// <param name="sRecord">The result of parsing. null if not parsed.</param>
        /// <returns>true if successful</returns>
        // ReSharper disable once UnusedMemberInSuper.Global
        bool TryParse(string lineOfText, out SRecordData sRecord);
    }
}