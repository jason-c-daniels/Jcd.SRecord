using System;

namespace Jcd.SRecord
{
    internal static class BigEndianConversions
    {
        #region ToBigEndianByteArray
        
        public static byte[] ToBigEndianByteArray(this uint value)
        {    
            // Value in bytes... in your system's endianness (let's say: little endian)
            byte[] bytes = BitConverter.GetBytes(value);

            // If it was little endian, reverse it
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes); 

            return bytes;
        }
        
        #endregion
        
        #region Ints from Big Endian Byte Array
        
        public static UInt32 UInt32FromBigEndianByteArray(this byte[] bytes)
        {
            var buffer = MakeBuffer(bytes, 4);
            // If the system architecture is little-endian (that is, little end first),
            // reverse the byte array.
            if (BitConverter.IsLittleEndian)
                Array.Reverse(buffer);

            return BitConverter.ToUInt32(buffer, 0);
        }

        private static byte[] MakeBuffer(byte[] bytes, int bufferSize)
        {
            var buffer = new byte[bufferSize];
            int i = bytes.Length - 1;
            int j = buffer.Length - 1;
            for (; i >= 0 && j >= 0; i--, j--)
            {
                buffer[j] = bytes[i];
            }

            return buffer;
        }

        #endregion
    }
}