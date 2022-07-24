using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Jcd.SRecord
{
    public partial struct SRecordType
    {
        /// <summary>
        /// Provides a collection and lookup mechanism for instances of <see cref="SRecordType"/>
        /// configured to accept a flexible number of data bytes per record. The exact amount
        /// allowed varies per type and is 254 bytes minus the address length in bytes, for S0,
        /// S1, S2, S3, and S4. NOTE: S4 types always require special, implementation defined, handling.
        /// </summary>
        public static class Flexible
        {
            /// <summary>
            /// The maximum data any data bearing record may have
            /// </summary>
            public const byte MaxDataLength = 32;

            /// <summary>
            /// The identifier for S0 records. Address is 2 bytes, should always be 0. Maximum data bytes allowed 252 bytes.
            /// </summary>
            /// <remarks>
            /// This record contains vendor specific ASCII text comment represented as a series of hex digit pairs.
            /// There is a spec, seldom conformed to, outlined in the <see href="https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html">Ubuntu manpage</see>.
            /// </remarks>
            public static readonly SRecordType S0 = new SRecordType("S0", 2);

            /// <summary>
            /// The identifier for S1 records. Address is 2 bytes. Maximum data bytes allowed 252 bytes.
            /// </summary>
            /// <remarks>
            /// This record type contains data that starts at the 16-bit address field.
            /// </remarks>
            public static readonly SRecordType S1 = new SRecordType("S1", 2);

            /// <summary>
            /// The identifier for S2 records. Address is 3 bytes. Maximum data bytes allowed 251 bytes.
            /// </summary>
            /// <remarks>
            /// This record type contains data that starts at a 24-bit address.
            /// </remarks>
            public static readonly SRecordType S2 = new SRecordType("S2", 3);

            /// <summary>
            /// The identifier for S3 records. Address is 4 bytes. Maximum data bytes allowed 250 bytes.
            /// </summary>
            /// <remarks>
            /// This record type contains data that starts at a 32-bit address.
            /// </remarks>
            public static readonly SRecordType S3 = new SRecordType("S3", 4);

            /// <summary>
            /// The identifier for S4 records. Address is 4 bytes. Maximum data bytes allowed 250 bytes.
            /// </summary>
            /// <remarks>
            /// Special handling required. This is vendor defined/reserved.
            /// </remarks>
            public static readonly SRecordType S4 = new SRecordType("S4", 4, MaxDataLength, true);

            /// <summary>
            /// The identifier for S5 records. Address is 2 bytes. No data allowed.
            /// </summary>
            /// <remarks>
            /// This record type is used to contain a 16-bit count of all S1, S2, or S3 records,
            /// stored in the address field. There are no data bytes for this record type.
            /// This record is used if the record count is less than or equal to 65,535 (0xFFFF).
            /// </remarks>
            public static readonly SRecordType S5 = new SRecordType("S5", 2, 0);

            /// <summary>
            /// The identifier for S6 records. Address is 3 bytes. No data allowed.
            /// </summary>
            /// <remarks>
            /// This record type is used to contain a 24-bit count of all S1, S2, or S3 records,
            /// stored in the address field. There are no data bytes for this record type.
            /// This record is used if the record count is less than or equal to 16,777,215 (0xFFFFFF) and 
            /// greater than 65,535 (0xFFFF) records.
            /// </remarks>
            public static readonly SRecordType S6 = new SRecordType("S6", 3, 0);

            /// <summary>
            /// The identifier for S7 records. Address is 4 bytes.  No data allowed.
            /// This is used to terminate a series of S3 records. 
            /// </summary>
            /// <remarks>
            /// If an SRecord file is only used to program a memory device and the execution location
            /// is ignored, then an address of zero could be used.
            /// </remarks>
            public static readonly SRecordType S7 = new SRecordType("S7", 4, 0);

            /// <summary>
            /// The identifier for S8 records. Address is 3 bytes. No data allowed.
            /// This is used to terminate a series of S2 records.
            /// </summary>
            /// <remarks>
            /// If an SRecord file is only used to program a memory device and the execution location
            /// is ignored, then an address of zero could be used.
            /// </remarks>
            public static readonly SRecordType S8 = new SRecordType("S8", 3, 0);


            /// <summary>
            /// The identifier for S8 records. Address is 3 bytes. Maximum data bytes allowed 32 bytes.
            /// </summary>
            /// <remarks>
            /// This is used to terminate a series of S1 records. If a SRecord file is only used to program
            /// a memory device and the execution location is ignored, then an address of zero could be used.
            /// </remarks>
            public static readonly SRecordType S9 = new SRecordType("S9", 2, 0);

            /// <summary>
            /// A key-based lookup for known Flexible (250-252 byte data max depending on record type) <c>SRecordType</c> instances.
            /// </summary>
            public static readonly ReadOnlyDictionary<string, SRecordType> TypeLookup =
                new ReadOnlyDictionary<string, SRecordType>(new Dictionary<string, SRecordType>
                    {
                        { S0.Key, S0 },
                        { S1.Key, S1 },
                        { S2.Key, S2 },
                        { S3.Key, S3 },
                        { S4.Key, S4 },
                        { S5.Key, S5 },
                        { S6.Key, S6 },
                        { S7.Key, S7 },
                        { S8.Key, S8 },
                        { S9.Key, S9 },
                    }
                );

            /// <summary>
            /// Given a key, return an SRecordType instance describing it.
            /// Invalid keys will return  
            /// </summary>
            /// <param name="key"></param>
            /// <returns>A matching <c>SRecordType</c> or a new instance with IsValid set to false.</returns>
            public static SRecordType FromKey(string key)
            {
                if (TypeLookup.ContainsKey(key))
                    return TypeLookup[key];
                return new SRecordType(key, 0, 0, true, false);
            }
        }
    }
}