using System;

namespace Jcd.SRecord.Extensions
{
    /// <summary>
    /// A set of extension methods to help in converting to and from hexadecimal representations of bytes 
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
        public static byte[] HexStringToBytes(this ReadOnlySpan<char> hexString)
        {
            // ReSharper disable once ConvertIfStatementToSwitchStatement
            if (hexString == null) return null;
            if (string.Empty == hexString) return Array.Empty<byte>();
            if (hexString.Length % 2!= 0)  
                throw new ArgumentException($"{nameof(hexString)}.Length must contain an even number of hexadecimal characters.", nameof(hexString));
            
            var bufferMax = hexString.Length / 2;
            var bytes = new byte[bufferMax];
            var j = 0;
            for (var i = 0; i < hexString.Length; i += 2)
            {
                bytes[j] = MakeByte(hexString[i], hexString[i + 1]);
                j++;
            }

            return bytes;
        }
        
        /// <summary>
        /// Converts a sequence of hexadecimal characters into the equivalent bytes. 
        /// </summary>
        /// <param name="hexString">the text to convert.</param>
        /// <returns>The sequence of bytes represented by the hex string.</returns>
        public static byte[] HexStringToBytes(this string hexString)
        {
            return hexString.AsSpan().HexStringToBytes();
        }

        /// <summary>
        /// Convert a sequence of bytes into a string of hexadecimal values. 
        /// </summary>
        /// <param name="bytes">the bytes to convert</param>
        /// <param name="makeUppercase">makes the A-F range uppercase when true, lowercase otherwise</param>
        /// <returns>The hexadecimal text representation</returns>
        public static string BytesToHexString(this ReadOnlySpan<byte> bytes, bool makeUppercase=true)
        {
            if (bytes == null) return null;
            var count = bytes.Length;
            if (count == 0) return string.Empty;
            
            var lookup = makeUppercase ? UppercaseHexLookup : LowercaseHexLookup;
            
            var buffer = new char[count * 2];
            var i = 0;
            // ReSharper disable once HeapView.ObjectAllocation.Possible
            foreach (var b in bytes)
            {
                buffer[i++] = lookup[b >> 4 & 0xf];
                buffer[i++] = lookup[b & 0xf];
            }

            return new string(buffer);
        }
        
        /// <summary>
        /// Given a pair of hexadecimal values encoded as chars, convert them into the single byte equivalent.
        /// </summary>
        /// <param name="highNybble">the high nybble (leftmost digit)</param>
        /// <param name="lowNybble">the low nybble (rightmost digit)</param>
        /// <returns>The converted value.</returns>
        public static byte MakeByte(char highNybble, char lowNybble)
        {
            return (byte)((byte)(highNybble.GetHexValue() << 4) | lowNybble.GetHexValue());
        }        
    }
}