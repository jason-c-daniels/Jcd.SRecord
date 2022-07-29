using System;

namespace Jcd.SRecord.Extensions
{
    /// <summary>
    /// Provides an extension method to convert data into a uint.
    /// </summary>
    public static class ByteSpanExtensions
    {
        #region Ints from Big Endian Byte Array
        
        /// <summary>
        /// Converts a ReadOnlySpan of bytes into a UInt32, regardless of the source number of bytes.
        /// This is endian independent.
        /// </summary>
        /// <param name="bytes">The source of the bytes.</param>
        /// <returns>The converted value.</returns>
        public static uint ToUInt32(this ReadOnlySpan<byte> bytes)
        {
            uint result = 0;
            for(var i=0;i<bytes.Length;i++)
            {
                result |= bytes[i];
                if (i+1<bytes.Length) result <<= 8;
            }

            return result;
        }

        #endregion
    }
}