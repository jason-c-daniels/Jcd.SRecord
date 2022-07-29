namespace Jcd.SRecord
{
    /// <summary>
    /// Defines the operations necessary to support formatting an <c>SRecordData</c> into text.
    /// </summary>
    public interface ISRecordDataFormatter
    {
        /// <summary>
        /// Indicates if the hex numbers should be uppercase (true) or lowercase (false).
        /// </summary>
        // ReSharper disable once UnusedMemberInSuper.Global
        bool EmitHexNumbersInUpperCase { get; }

        /// <summary>
        /// Converts an SRecordData into its ASCII-HEX representation.
        /// </summary>
        /// <param name="sRecord">the record to format</param>
        /// <returns>The formatted string (S0030000FC...etc)</returns>
        string Format(SRecordData sRecord);
    }
}