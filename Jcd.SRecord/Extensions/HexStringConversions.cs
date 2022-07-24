using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Jcd.Validations;

namespace Jcd.SRecord.Extensions
{
    /// <summary>
    /// A set of extension methods to help in converting
    /// to and from hexadecimal representations of bytes 
    /// </summary>
    public static class HexStringConversions
    {
        private static readonly char[] UppercaseHexLookup = 
            { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        
        private static readonly char[] LowercaseHexLookup = 
            { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };

        /// <summary>
        /// Converts a sequence of hexadecimal characters into the equivalent bytes. 
        /// </summary>
        /// <param name="hexString">the text to convert.</param>
        /// <returns>The sequence of bytes represented by the hex string.</returns>
        public static IEnumerable<byte> HexStringToBytes(this string hexString)
        {
            Argument.IsNotWhitespace(hexString, nameof(hexString));
            if (hexString == null) return null;
            if (string.Empty == hexString) return Array.Empty<byte>();
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
            if (bytes == null) return null;
            var count = bytes.Count();
            if (count == 0) return string.Empty;
            
            var lookup = makeUppercase ? UppercaseHexLookup : LowercaseHexLookup;
            
            var buffer = new char[count * 2];
            var i = 0;
            foreach (var b in bytes)
            {
                buffer[i++] = lookup[b >> 4 & 0xf];
                buffer[i++] = lookup[b & 0xf];
            }

            return new string(buffer);
        }
    }
}