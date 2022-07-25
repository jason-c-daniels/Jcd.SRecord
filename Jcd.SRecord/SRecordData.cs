using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;


namespace Jcd.SRecord
{
    /// <summary>
    /// Represents a single <c>SRecordData</c> entry in an s-record file. This is an immutable type.
    /// To edit the contents, create a new one with the altered data buffer, address, and/or type.
    /// </summary>
    /// <remarks>
    /// Further reading about the SRecordData format can be done
    /// <see href="https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html"> at the Ubuntu manpage</see>
    /// and <see href="https://en.wikipedia.org/wiki/SREC_(file_format)">the wikipedia page</see>.
    /// </remarks>
    public class SRecordData
    {
        /// <summary>
        /// The length of the checksum, in bytes.
        /// </summary>
        public const byte CheckSumByteLength = 0x01;
        
        /// <summary>
        /// The length of the count in bytes
        /// </summary>
        public const byte CountByteLength = 0x01;
        
        /// <summary>
        /// The length of the record key in characters.
        /// </summary>
        public const byte KeyCharLength = 0x02;
        
        /// <summary>
        /// The maximum value for the count field. 
        /// </summary>
        public const byte MaxValueForCount = 0xFF;

        /// <summary>
        /// The type of SRecordData
        /// </summary>
        public SRecordDataType Type { get; }
        
        /// <summary>
        /// The total count of the address, data, and checksum bytes.
        /// </summary>
        public byte CountOfRemainingBytes { get; }
        
        /// <summary>
        /// If applicable, the address for data to be written to, or in some cases, a count of preceding records.
        /// </summary>
        public uint Address { get; }
        
        /// <summary>
        /// The computed address of the last byte of data contained in this record.
        /// For records with 0 data length, this will contain the same value as Address. 
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public long EndAddress => Address + Data.Count;

        /// <summary>
        /// The data to be loaded into the address. (or in S0's case a descriptor for the file.)
        /// </summary>
        [NotNull]
        public ReadOnlyCollection<byte> Data { get; }
        
        /// <summary>
        /// The checksum for the type, address, and data.
        /// </summary>
        public byte Checksum { get; }
        
        /// <summary>
        /// Constructs a mew SRecordData instance.
        /// </summary>
        /// <param name="type">The type descriptor for the SRecordData</param>
        /// <param name="address">The data for the address field.</param>
        /// <param name="data">The data for the data field, if any.</param>
        public SRecordData(SRecordDataType type, uint address, byte[] data=null)
        {
            data ??= Array.Empty<byte>();
            if (data.Length > type.MaximumDataBytesAllowed) throw new ArgumentException(
                    $"{type.Key} records must contain at most {type.MaximumDataBytesAllowed.ToString(CultureInfo.InvariantCulture)} bytes of data {data.Length.ToString(CultureInfo.InvariantCulture)} bytes were provided.",
                    $"{nameof(data)}.Length"
                );
            
            Type = type;
            Address = address;
            Data = Array.AsReadOnly(data);
            CountOfRemainingBytes = (byte)(type.AddressLengthInBytes + CheckSumByteLength + Data.Count);
            Checksum = ComputeChecksum(type, CountOfRemainingBytes, address, data);
        }

        /// <summary>
        /// Computes the checksum for the record.
        /// </summary>
        /// <param name="type">The type descriptor for the record.</param>
        /// <param name="count">The count of bytes following</param>
        /// <param name="address">The data for the address field.</param>
        /// <param name="data">The data for the data field, if any.</param>
        /// <returns>The checksum</returns>
        private static byte ComputeChecksum(SRecordDataType type, byte count, uint address, [NotNull]byte[] data=null)
        {
            data ??= Array.Empty<byte>();
            ushort checksum = count;
            checksum += (byte)(address & 0xFF);
            if (type.AddressLengthInBytes > 1)
            {
                address >>= 8;
                checksum += (byte)(address & 0xFF);
            }
            if (type.AddressLengthInBytes > 2)
            {
                address >>= 8;
                checksum += (byte)(address & 0xFF);
            }
            
            checksum = data.Aggregate(checksum, (current, b) => (ushort)(current + b));
            return (byte)~(byte)(checksum & 0xFF);
        }
    }
}
