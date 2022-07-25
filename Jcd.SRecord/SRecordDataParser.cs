using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using Jcd.SRecord.Extensions;

namespace Jcd.SRecord
{
    /// <summary>
    /// Provides facilities for parsing the textual SRecordData format into its
    /// binary representation.
    /// </summary>
    public class SRecordDataParser : ISRecordDataParser
    {
        
        [NotNull]
        private readonly IDictionary<string, SRecordDataType> _typeLookup;
        
        /// <summary>
        /// Constructs an SRecordDataParser from a defined sRecord type lookup table.
        /// </summary>
        /// <param name="typeLookup">The S0-S9 definitions used during parsing.</param>
        public SRecordDataParser(IDictionary<string, SRecordDataType> typeLookup)
        {
            if (typeLookup?.Count == 0)
                throw new ArgumentException($"{nameof(typeLookup)} must had at least one entry", nameof(typeLookup));
            _typeLookup = typeLookup ?? throw new ArgumentNullException(nameof(typeLookup));
        }
        
        /// <summary>
        /// Parses a line of text into an <c>SRecordData, ignoring trailing whitespace.</c>
        /// </summary>
        /// <param name="lineOfText">The line of text to parse.</param>
        /// <returns>An <c>SRecordData</c> instance if it was successfully parsed.</returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="Exception"></exception>
        public SRecordData Parse(string lineOfText)
        {
            if (string.IsNullOrWhiteSpace(lineOfText)) 
                throw new ArgumentException("Cannot parse an SRecordData from blank data.", nameof(lineOfText));
            lineOfText = lineOfText.TrimEnd(); // remove any possible trailing whitespace, such as CRLF, or spaced before a comment character.
            var minAddressByteLength = _typeLookup.Values!.Min(t => t.AddressLengthInBytes);
            var minTextLength=SRecordData.KeyCharLength + SRecordData.CountByteLength*2 + SRecordData.CheckSumByteLength*2 + minAddressByteLength * 2;
            if (lineOfText.Length<minTextLength) 
                throw new ArgumentException($"Length must be at least {minTextLength.ToString(CultureInfo.InvariantCulture)} characters in length.", nameof(lineOfText));
            if (lineOfText.Length % 2 != 0)
                throw new ArgumentException($"{nameof(lineOfText)} must be composed of an even number of characters.", nameof(lineOfText));
            
            // grab the first two characters
            var key = lineOfText[..SRecordData.KeyCharLength];
            // validate we have a key we know about
            if (!_typeLookup.ContainsKey(key)) 
                throw new ArgumentException($"Unknown SRecordData type {key}");
            var type = _typeLookup[key];
            // since we know the first two chars (type indicator) are valid, truncate the string to everything after the type indicator 
            var remainingText = lineOfText[SRecordData.KeyCharLength..];
            
            const int countCharLength = SRecordData.CountByteLength * 2;
            var countOfRemainingBytes = byte.Parse(remainingText[..countCharLength],NumberStyles.HexNumber);

            // get the text after the count.
            remainingText = remainingText[countCharLength..];
            
            // convert to byte array
            var remainingBytes = remainingText.HexStringToBytes();
            if (countOfRemainingBytes != remainingBytes.Length) 
                throw new ArgumentException($"Actual remaining byte count ({remainingBytes.Length}) does not match stored remaining byte count ({countOfRemainingBytes})");

            // extract address
            var addressBytes = remainingBytes[..type.AddressLengthInBytes];
            var address = addressBytes.UInt32FromBigEndianByteArray();
            remainingBytes = remainingBytes[type.AddressLengthInBytes..];

            // grab the data bytes and checksum from the remaining 
            var dataLength = countOfRemainingBytes - SRecordData.CheckSumByteLength - type.AddressLengthInBytes;
            var data = dataLength > 0 ? remainingBytes[..dataLength] : Array.Empty<byte>();
            var checkSum = remainingBytes[^1];
            var record = new SRecordData(type, address, data);

            // now confirm the parsed checksum and count match the data extracted from the text
            if (checkSum != record.Checksum) 
                throw new ArgumentException("Computed checksum doesn't match checksum stored within the record.");
            return record;
        }

        /// <summary>
        /// Tries parsing a line of text into an <c>SRecordData</c>
        /// </summary>
        /// <param name="lineOfText">the text to try parsing.</param>
        /// <param name="sRecord">The result of parsing. null if not parsed.</param>
        /// <returns>true if successful</returns>
        public bool TryParse(string lineOfText, out SRecordData sRecord)
        {
            sRecord = null;
            try
            {
                sRecord = Parse(lineOfText);
                return true;
            }
            catch
            {
                // ignored
            }

            return false;
        }

        /// <summary>
        /// An instance configured to use Strict definitions.
        /// </summary>
        public static readonly SRecordDataParser Strict = new SRecordDataParser(SRecordDataType.Strict.TypeLookup);
        
        /// <summary>
        /// An instance configured to use Flexible definitions.
        /// </summary>
        public static readonly SRecordDataParser Flexible = new SRecordDataParser(SRecordDataType.Flexible.TypeLookup);

        /// <summary>
        /// An default instance. This is the same as Flexible.
        /// </summary>
        public static readonly SRecordDataParser Default = Flexible;

        /// <summary>
        /// Creates a new instance of an SRecordDataParser configured to parse records
        /// containing the configured maxDataBytesPerRecord.
        /// </summary>
        /// <remarks>When maxDataBytesPerRecord is greater than 250, the Flexible instance is used instead of creating a new one.</remarks>
        /// <param name="maxDataBytesPerRecord"></param>
        /// <returns>The new, or stock, instance of the SRecordDataParser</returns>
        public static SRecordDataParser Create(byte maxDataBytesPerRecord = 0xFF) =>
            maxDataBytesPerRecord switch
            {
                var a when a > 250 => Flexible,
                32 => Strict,
                _ => new SRecordDataParser(SRecordDataType.CreateLookup(maxDataBytesPerRecord))
            };
    }
}