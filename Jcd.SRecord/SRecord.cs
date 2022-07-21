using System;
using System.Linq;
using Jcd.Validations;


namespace Jcd.SRecord
{
    /// <summary>
    /// Represents a single SRecord entry in an srec file.
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
        /// The data to be loaded into the address. (or in S0's case a descriptor for the file.)
        /// </summary>
        public byte[] Data { get; }
        
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
            Data = ReferenceEquals(Array.Empty<byte>(), data) ? data : (byte[])data.Clone(); // copy the data, if there is any. 
            CountOfRemainingBytes = (byte)(type.AddressLengthInBytes + CheckSumByteLength + Data.Length);
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
        public static byte ComputeChecksum(SRecordType type, byte count ,uint address, byte[] data=null)
        {
            data ??= Array.Empty<byte>();
            return ComputeChecksum(
                new []{count}
                    .Concat(address.ToBigEndianByteArray().TakeLast(type.AddressLengthInBytes))
                    .Concat(data)
                    .ToArray());
        }
        
        /// <summary>
        /// Computes the checksum for the concatenated bytes contained in the address
        /// and data fields.
        /// </summary>
        /// <param name="countAddressAndDataBytes">The concatenated list of bytes from the address and data.</param>
        /// <returns>The checksum</returns>
        public static byte ComputeChecksum(byte[] countAddressAndDataBytes)
        {
            ushort checksum = 0x00;
            foreach (var b in countAddressAndDataBytes)
            {
                checksum += b;
            }
            return (byte)~((byte)(checksum & 0xFF));
        }
    }
}
