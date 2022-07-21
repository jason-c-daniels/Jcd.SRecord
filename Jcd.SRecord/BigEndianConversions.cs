using System;

namespace Jcd.SRecord
{
    internal static class BigEndianConversions
    {
        #region ToBigEndianByteArray
        
        public static byte[] ToBigEndianByteArray(this ulong value)
        {    
            // Value in bytes... in your system's endianness (let's say: little endian)
            byte[] bytes = BitConverter.GetBytes(value);

            // If it was little endian, reverse it
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes); 

            return bytes;
        }
        
        public static byte[] ToBigEndianByteArray(this long value)
        {    
            // Value in bytes... in your system's endianness (let's say: little endian)
            byte[] bytes = BitConverter.GetBytes(value);

            // If it was little endian, reverse it
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes); 

            return bytes;
        }
        
        public static byte[] ToBigEndianByteArray(this uint value)
        {    
            // Value in bytes... in your system's endianness (let's say: little endian)
            byte[] bytes = BitConverter.GetBytes(value);

            // If it was little endian, reverse it
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes); 

            return bytes;
        }
        
        public static byte[] ToBigEndianByteArray(this int value)
        {    
            // Value in bytes... in your system's endianness (let's say: little endian)
            byte[] bytes = BitConverter.GetBytes(value);

            // If it was little endian, reverse it
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes); 

            return bytes;
        }
        
        public static byte[] ToBigEndianByteArray(this ushort value)
        {    
            // Value in bytes... in your system's endianness (let's say: little endian)
            byte[] bytes = BitConverter.GetBytes(value);

            // If it was little endian, reverse it
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes); 

            return bytes;
        }
        
        public static byte[] ToBigEndianByteArray(this short value)
        {    
            // Value in bytes... in your system's endianness (let's say: little endian)
            byte[] bytes = BitConverter.GetBytes(value);

            // If it was little endian, reverse it
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes); 

            return bytes;
        }
        
        public static byte[] ToBigEndianByteArray(this float value)
        {    
            // Value in bytes... in your system's endianness (let's say: little endian)
            byte[] bytes = BitConverter.GetBytes(value);

            // If it was little endian, reverse it
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes); 

            return bytes;
        }

        public static byte[] ToBigEndianByteArray(this double value)
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

        public static UInt64 UInt64FromBigEndianByteArray(this byte[] bytes)
        {
            // If the system architecture is little-endian (that is, little end first),
            // reverse the byte array.
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            return BitConverter.ToUInt64(bytes, 0);            
        }

        public static Int64 Int64FromBigEndianByteArray(this byte[] bytes)
        {
            // If the system architecture is little-endian (that is, little end first),
            // reverse the byte array.
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            return BitConverter.ToInt64(bytes, 0);            
        }
        
        public static UInt32 UInt32FromBigEndianByteArray(this byte[] bytes)
        {
            // If the system architecture is little-endian (that is, little end first),
            // reverse the byte array.
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            return BitConverter.ToUInt32(bytes, 0);            
        }

        public static Int32 Int32FromBigEndianByteArray(this byte[] bytes)
        {
            // If the system architecture is little-endian (that is, little end first),
            // reverse the byte array.
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            return BitConverter.ToInt32(bytes, 0);            
        }
        
        public static UInt16 UInt16FromBigEndianByteArray(this byte[] bytes)
        {
            // If the system architecture is little-endian (that is, little end first),
            // reverse the byte array.
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            return BitConverter.ToUInt16(bytes, 0);            
        }

        public static Int16 Int16FromBigEndianByteArray(this byte[] bytes)
        {
            // If the system architecture is little-endian (that is, little end first),
            // reverse the byte array.
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            return BitConverter.ToInt16(bytes, 0);            
        }

        #endregion
    }
}