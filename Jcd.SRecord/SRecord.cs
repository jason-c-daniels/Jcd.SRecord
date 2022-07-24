using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Jcd.SRecord.Extensions;
using Jcd.Validations;


namespace Jcd.SRecord
{
    /// <summary>
    /// Represents a single <c>SRecord</c> entry in an s-record file. This is an immutable type.
    /// To edit the contents, create a new one with the altered data buffer, address, and/or type.
    /// </summary>
    /// <remarks>
    /// Further reading about the SRecord format can be done
    /// <see href="https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html"> at the Ubuntu manpage</see>
    /// and <see href="https://en.wikipedia.org/wiki/SREC_(file_format)">the wikipedia page</see>.
    /// </remarks>
    public class SRecord
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
        /// The type of SRecord
        /// </summary>
        public SRecordType Type { get; }
        
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
        /// Constructs a mew SRecord instance.
        /// </summary>
        /// <param name="type">The type descriptor for the SRecord</param>
        /// <param name="address">The data for the address field.</param>
        /// <param name="data">The data for the data field, if any.</param>
        public SRecord(SRecordType type, uint address, byte[] data=null)
        {
            data ??= Array.Empty<byte>();
            Argument.IsLessThanOrEqual(data.Length, type.MaximumDataBytesAllowed, 
                $"{nameof(data)}.Length",
                $"{type.Key} records must contain at most {type.MaximumDataBytesAllowed} bytes of data {data.Length} bytes were provided.");
            
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
        private static byte ComputeChecksum(SRecordType type, byte count ,uint address, byte[] data=null)
        {
            data ??= Array.Empty<byte>();
            return ComputeChecksum(
                new []{count}
                    .Concat(address.ToBigEndianByteArray().TakeLast(type.AddressLengthInBytes))
                    .Concat(data));
        }
        
        /// <summary>
        /// Computes the checksum for the concatenated bytes contained in the address
        /// and data fields.
        /// </summary>
        /// <param name="countAddressAndDataBytes">The concatenated list of bytes from the address and data.</param>
        /// <returns>The checksum</returns>
        private static byte ComputeChecksum(IEnumerable<byte> countAddressAndDataBytes)
        {
            var checksum = countAddressAndDataBytes.Aggregate<byte, ushort>(0x00, (current, b) => (ushort)(current + b));
            return (byte)~(byte)(checksum & 0xFF);
        }
    }
}
