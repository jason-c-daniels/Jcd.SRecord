using System;

namespace Jcd.SRecord
{
    /// <summary>
    /// Defines the operations necessary in order to support parsing text into
    /// <c>SRecord</c> instances.
    /// </summary>
    public interface ISRecordParser
    {
        /// <summary>
        /// Parses a line of text into an <c>SRecord, ignoring trailing whitespace.</c>
        /// </summary>
        /// <param name="lineOfText">The line of text to parse.</param>
        /// <returns>An <c>SRecord</c> instance if it was successfully parsed.</returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="Exception"></exception>
        SRecord Parse(string lineOfText);

        /// <summary>
        /// Tries parsing a line of text into an <c>SRecord</c>
        /// </summary>
        /// <param name="lineOfText">the text to try parsing.</param>
        /// <param name="sRecord">The result of parsing. null if not parsed.</param>
        /// <returns>true if successful</returns>
        // ReSharper disable once UnusedMemberInSuper.Global
        bool TryParse(string lineOfText, out SRecord sRecord);
    }
}