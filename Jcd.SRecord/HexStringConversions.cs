using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Jcd.Validations;

namespace Jcd.SRecord
{
    /// <summary>
    /// A set of extension methods to help in converting
    /// to and from hexadecimal representations of bytes 
    /// </summary>
    public static class HexStringConversions
    {
        /// <summary>
        /// Converts a sequence of hexadecimal characters into the equivalent bytes. 
        /// </summary>
        /// <param name="hexString">the text to convert.</param>
        /// <returns>The sequence of bytes represented by the hex string.</returns>
        public static IEnumerable<byte> HexStringToBytes(this string hexString)
        {
            Argument.IsNotNullWhitespaceOrEmpty(hexString, nameof(hexString));
            Argument.AreEqual(hexString.Length % 2, 0, nameof(hexString),
                $"{nameof(hexString)}.Length must contain an even number of hexadecimal characters.");
            var bufferMax = hexString.Length / 2;
            var bytes = new byte[bufferMax];
            var j = 0;
            var hb = new char[2];  
            for (var i = 0; i < hexString.Length; i += 2)
            {
                hb[0] = hexString[i];
                hb[1] = hexString[i + 1];
                var b=byte.Parse(hb,NumberStyles.HexNumber);
                bytes[j] = b;
                j++;
            }

            return bytes;
        }

        /// <summary>
        /// Convert a sequence of bytes into a string of hexadecimal values. 
        /// </summary>
        /// <param name="bytes">the bytes to convert</param>
        /// <param name="makeUppercase">makes the A-F range uppercase when true, lowercase otherwise</param>
        /// <returns>The hexadecimal text representation</returns>
        public static string BytesToHexString(this IEnumerable<byte> bytes, bool makeUppercase=true)
        {
            if (bytes == null) return string.Empty;
            var ba = bytes.ToArray();
            var sb = new StringBuilder();
            foreach (var b in bytes)
            {
                var format = makeUppercase ? "{0:X2}" : "{0:x2}";
                sb.AppendFormat(format, b);
            }

            return sb.ToString();
        }
    }
}