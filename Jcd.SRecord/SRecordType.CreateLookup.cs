using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Jcd.SRecord
{
    public partial struct SRecordType
    {
        private const byte MaxS3DataBytes = 250;
        private const byte StrictDataByteSize = 32;
        private const byte MinS0S1S2S3S4DataBytes = 1;

        private static readonly Dictionary<byte, ReadOnlyDictionary<string, SRecordType>> TypeLookupCache
            = new Dictionary<byte, ReadOnlyDictionary<string, SRecordType>>
            {
                { MaxS3DataBytes  , Flexible.TypeLookup },
                { MaxS3DataBytes+1, Flexible.TypeLookup },
                { MaxS3DataBytes+2, Flexible.TypeLookup },
                { MaxS3DataBytes+3, Flexible.TypeLookup },
                { MaxS3DataBytes+4, Flexible.TypeLookup },
                { MaxS3DataBytes+5, Flexible.TypeLookup },
                { StrictDataByteSize, Strict.TypeLookup }
            };

        /// <summary>
        /// Creates a lookup table of <c>SRecordType</c>s.
        /// </summary>
        /// <param name="dataBytesPerRecord">The number of data bytes you want any S1,S2, or S3 record to hold.</param>
        /// <returns>Returns a lookup table for record types.</returns>
        public static ReadOnlyDictionary<string, SRecordType> CreateLookup(byte dataBytesPerRecord = MaxS3DataBytes)
        {
            if (!TypeLookupCache.ContainsKey(dataBytesPerRecord))
                TypeLookupCache.Add(dataBytesPerRecord, InternalCreate(dataBytesPerRecord));

            return TypeLookupCache[dataBytesPerRecord];
        }

        private static ReadOnlyDictionary<string, SRecordType> InternalCreate(byte dataBytesPerRecord)
        {
            if (dataBytesPerRecord > MaxS3DataBytes)
                throw new ArgumentException(
                    $"{MaxS3DataBytes} bytes is the most an S3 record can hold. If you meant to use the Flexible definition (i.e. max data size varies for: S0,S1,S2,S3,S4) Please use SRecordType.Flexible.TypeLookup instead.");

            if (dataBytesPerRecord < MinS0S1S2S3S4DataBytes)
                throw new ArgumentException(
                    $"Data records must contain at least {MinS0S1S2S3S4DataBytes} byte(s). Note: Data sizes below 32 bytes may not be compatible with S4 records.");

            var s0 = new SRecordType("S0", 2, dataBytesPerRecord);
            var s1 = new SRecordType("S1", 2, dataBytesPerRecord);
            var s2 = new SRecordType("S2", 3, dataBytesPerRecord);
            var s3 = new SRecordType("S3", 4, dataBytesPerRecord);
            var s4 = new SRecordType("S4", 4, dataBytesPerRecord, true);
            var s5 = new SRecordType("S5", 2, 0);
            var s6 = new SRecordType("S6", 3, 0);
            var s7 = new SRecordType("S7", 4, 0);
            var s8 = new SRecordType("S8", 3, 0);
            var s9 = new SRecordType("S9", 2, 0);

            return new ReadOnlyDictionary<string, SRecordType>(new Dictionary<string, SRecordType>
                {
                    { s0.Key, s0 },
                    { s1.Key, s1 },
                    { s2.Key, s2 },
                    { s3.Key, s3 },
                    { s4.Key, s4 },
                    { s5.Key, s5 },
                    { s6.Key, s6 },
                    { s7.Key, s7 },
                    { s8.Key, s8 },
                    { s9.Key, s9 }
                }
            );
        }
    }
}
