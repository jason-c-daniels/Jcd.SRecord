using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Jcd.SRecord.Extensions;

namespace Jcd.SRecord
{
    /// <summary>
    /// Encapsulates the formatting logic required to emit a single SRecord
    /// with consistent hex value casing.
    /// </summary>
    public class SRecordFormatter : ISRecordFormatter
    {
        /// <summary>
        /// Indicates if the hex numbers should be uppercase (true) or lowercase (false)
        /// </summary>
        public bool EmitHexNumbersInUpperCase { get; }
        
        /// <summary>
        /// And instance preconfigured to emit uppercase hex values.
        /// </summary>
        public static readonly SRecordFormatter UppercaseHex = new SRecordFormatter(true);
        
        /// <summary>
        /// An instance preconfigured to emit lowercase hex values.
        /// </summary>
        public static readonly SRecordFormatter LowercaseHex = new SRecordFormatter();
        
        /// <summary>
        /// The default (uppercase) method of emitting an SRecord.
        /// </summary>
        public static SRecordFormatter Default => UppercaseHex;

        private SRecordFormatter(bool emitHexNumbersInUpperCase=false)
        {
            EmitHexNumbersInUpperCase = emitHexNumbersInUpperCase;
        }

        /// <summary>
        /// Converts an SRecord into its ASCII-HEX representation.
        /// </summary>
        /// <param name="sRecord">the record to format</param>
        /// <returns>The formatted string (S0030000FC...etc)</returns>
        public string Format(SRecord sRecord)
        {
            var sb = new StringBuilder(
                SRecordType.KeyLength +
                SRecord.CountByteLength * 2 +
                sRecord.Type.AddressLengthInBytes * 2 + 
                sRecord.Type.MaximumDataBytesAllowed * 2 +
                SRecord.CheckSumByteLength * 2
            );
            sb.Append(sRecord.Type.Key);
            AppendByte(sb, sRecord.CountOfRemainingBytes);
            AppendAddress(sb, sRecord);
            AppendBytes(sb, sRecord.Data);
            AppendByte(sb, sRecord.Checksum);
            return sb.ToString();
        }

        private void AppendByte(StringBuilder sb, byte value)
        {
            var format = EmitHexNumbersInUpperCase ? "X2" : "x2";
            sb.Append(value.ToString(format));
        }

        private void AppendBytes(StringBuilder sb, IEnumerable<byte> bytes)
        {
            sb.Append(bytes.BytesToHexString(EmitHexNumbersInUpperCase));
        }

        private void AppendAddress(StringBuilder sb, SRecord sRecord)
        {
            var charCount = sRecord.Type.AddressLengthInBytes * 2;
            var format = EmitHexNumbersInUpperCase ? $"X{charCount.ToString(CultureInfo.InvariantCulture)}" : $"x{charCount.ToString(CultureInfo.InvariantCulture)}";
            sb.Append(sRecord.Address.ToString(format));
        }
    }
}