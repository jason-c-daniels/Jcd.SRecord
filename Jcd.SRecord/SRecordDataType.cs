using System;
using System.Globalization;
using Jcd.Validations;

namespace Jcd.SRecord
{
    /// <summary>
    /// Represents the information required to identify and process various types of SRecords <see href="https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html">as documented here</see>
    /// </summary>
    public readonly partial struct SRecordDataType : IEquatable<SRecordDataType>
    {
        /// <summary>
        /// The length of the key in characters.
        /// </summary>
        public const int KeyLength=2;

        /// <summary>
        /// The mandatory character that all SRecordData types must start with 'S'. 
        /// </summary>
        public const char RecordStartCharacter = 'S';
        
        /// <summary>
        /// The key for the type.
        /// </summary>
        public readonly string Key;
        
        /// <summary>
        /// The number of bytes used to represent the address.
        /// </summary>
        public readonly byte AddressLengthInBytes;
        
        /// <summary>
        /// The maximum number of bytes allowed in the data section for this type.
        /// </summary>
        public readonly byte MaximumDataBytesAllowed;
        
        /// <summary>
        /// Indicates if the type is valid and recognized. 
        /// </summary>
        /// <remarks>
        /// This is set by whatever is constructing the type. Usually this will be set
        /// at compile time. See, <c>Strict</c> and <c>Flexible</c> for examples.
        /// </remarks>
        public readonly bool IsValid;
        
        /// <summary>
        /// Indicates if the type requires special (i.e. non-standard handling. e.g. S4)
        /// </summary>
        public readonly bool RequiresSpecialHandling;
        
        /// <summary>
        /// Constructs an SRecordDataType, which identifies how to properly process and/or parse
        /// an SRecordData of the specified type, provided the key, address length, and
        /// maximum data bytes allowed.
        /// </summary>
        /// <remarks>
        /// This constructor is only intended to be used by people who will use it correctly.
        /// Typically you'll want to use Strict.FromKey or Flexible.FromKey instead.
        /// </remarks>
        /// <param name="key">The two character SRecordData identifier. (S0..S9)</param>
        /// <param name="addressLengthInBytes">The byte length of the address</param>
        /// <param name="maximumDataBytesAllowed">The maximum number of data bytes allowed.</param>
        /// <param name="requiresSpecialHandling">Indicates if the type requires special handling. (S4 does)</param>
        /// <param name="isValid">Indicates if parsing recognized the key.</param>
        public SRecordDataType(string key, byte addressLengthInBytes, byte maximumDataBytesAllowed, bool requiresSpecialHandling=false, bool isValid=true)
        {
            Argument.AreEqual(key.Length, KeyLength, nameof(key), $"{nameof(key)} must be exactly {KeyLength.ToString(CultureInfo.InvariantCulture)} characters in length.");
            Argument.AreEqual( key[0],RecordStartCharacter, nameof(key), $"The first letter of {nameof(key)} must be '{RecordStartCharacter.ToString(CultureInfo.InvariantCulture)}' found '{key[0].ToString(CultureInfo.InvariantCulture)}' instead.");
            Argument.InRange(key[1], '0', '9', nameof(key), $"The second letter of {nameof(key)} must be '0' to '9' found '{key[1].ToString(CultureInfo.InvariantCulture)}' instead.");
            Argument.IsLessThanOrEqual(maximumDataBytesAllowed,
                SRecordData.MaxValueForCount - addressLengthInBytes - SRecordData.CheckSumByteLength, nameof(maximumDataBytesAllowed),$"Total byte size for address({addressLengthInBytes.ToString(CultureInfo.InvariantCulture)}), checksum({SRecordData.CheckSumByteLength.ToString(CultureInfo.InvariantCulture)}) and data({maximumDataBytesAllowed.ToString(CultureInfo.InvariantCulture)}) exceeds {SRecordData.MaxValueForCount.ToString(CultureInfo.InvariantCulture)}.");
            Key = key;
            AddressLengthInBytes = addressLengthInBytes;
            MaximumDataBytesAllowed = maximumDataBytesAllowed;
            IsValid = isValid;
            RequiresSpecialHandling = requiresSpecialHandling;
        }

        /// <summary>
        /// Constructs an SRecordDataType, which identifies how to properly process and/or parse an SRecordData of the specified type, provided the key, address length.
        /// </summary>
        /// <remarks>
        /// - This constructor is only intended to be used by people who will use it correctly.
        /// - Typically you'll want to use Strict.FromKey or Flexible.FromKey instead.
        /// - The maximum data length is computed from the following formula:
        /// -- MaximumDataBytesAllowed = SRecordData.MaxValueForCount - SRecordData.CheckSumByteLength - addressLengthInBytes;
        /// </remarks>
        /// <param name="key">The two character SRecordData identifier. (S0..S9)</param>
        /// <param name="addressLengthInBytes">The byte length of the address</param>
        /// <param name="requiresSpecialHandling">Indicates if the type requires special handling. (S4 does)</param>
        /// <param name="isValid">Indicates if parsing recognized the key.</param>
        public SRecordDataType(string key, byte addressLengthInBytes, bool requiresSpecialHandling=false, bool isValid=true)
            : this(key,addressLengthInBytes,(byte)(SRecordData.MaxValueForCount-addressLengthInBytes-SRecordData.CheckSumByteLength),requiresSpecialHandling,isValid)
        {
        }
        
        #region Equality operators.

        /// <inheritdoc />
        public bool Equals(SRecordDataType other)
        {
            return Key == other.Key && AddressLengthInBytes == other.AddressLengthInBytes && MaximumDataBytesAllowed == other.MaximumDataBytesAllowed && IsValid == other.IsValid && RequiresSpecialHandling == other.RequiresSpecialHandling;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return obj is SRecordDataType other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return HashCode.Combine(Key, AddressLengthInBytes, MaximumDataBytesAllowed, IsValid, RequiresSpecialHandling);
        }

        /// <summary>
        /// Compares two operands to determine if they're equal.
        /// </summary>
        /// <param name="left">the left hand operand</param>
        /// <param name="right">the right hand operand</param>
        /// <returns>True if they are equal</returns>
        public static bool operator ==(SRecordDataType left, SRecordDataType right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two operands to determine if they're not equal.
        /// </summary>
        /// <param name="left">the left hand operand</param>
        /// <param name="right">the right hand operand</param>
        /// <returns>True if they are not equal</returns>
        public static bool operator !=(SRecordDataType left, SRecordDataType right)
        {
            return !left.Equals(right);
        }
        #endregion
    }
}