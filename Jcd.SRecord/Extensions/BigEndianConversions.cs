using System;
using System.Collections.Generic;

namespace Jcd.SRecord.Extensions
{
    public static class BigEndianConversions
    {
        #region Ints from Big Endian Byte Array
        
        public static uint ToUInt32(this ReadOnlySpan<byte> bytes)
        {
            uint result = 0;
            for(int i=0;i<bytes.Length;i++)
            {
                result |= bytes[i];
                if (i+1<bytes.Length) result <<= 8;
            }

            return result;
        }

        #endregion
    }
}