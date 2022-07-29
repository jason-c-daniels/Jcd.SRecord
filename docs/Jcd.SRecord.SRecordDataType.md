#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## SRecordDataType Struct

Represents the information required to identify and process various types of SRecords  
[
            as documented here
            ](https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html 'https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html')

```csharp
public readonly struct SRecordDataType :
System.IEquatable<Jcd.SRecord.SRecordDataType>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [SRecordDataType(string, byte, bool, bool)](Jcd.SRecord.SRecordDataType.SRecordDataType(string,byte,bool,bool).md 'Jcd.SRecord.SRecordDataType.SRecordDataType(string, byte, bool, bool)') | Constructs an SRecordDataType, which identifies how to properly process and/or parse<br/>an SRecordData of the specified type, provided the key, address length. The maximum<br/>data length is computed from the following formula:<br/>MaximumDataBytesAllowed = SRecordData.MaxValueForCount - SRecordData.CheckSumByteLength - addressLengthInBytes; |
| [SRecordDataType(string, byte, byte, bool, bool)](Jcd.SRecord.SRecordDataType.SRecordDataType(string,byte,byte,bool,bool).md 'Jcd.SRecord.SRecordDataType.SRecordDataType(string, byte, byte, bool, bool)') | Constructs an SRecordDataType, which identifies how to properly process and/or parse<br/>an SRecordData of the specified type, provided the key, address length, and<br/>maximum data bytes allowed. |

| Fields | |
| :--- | :--- |
| [AddressLengthInBytes](Jcd.SRecord.SRecordDataType.AddressLengthInBytes.md 'Jcd.SRecord.SRecordDataType.AddressLengthInBytes') | The number of bytes used to represent the address. |
| [IsValid](Jcd.SRecord.SRecordDataType.IsValid.md 'Jcd.SRecord.SRecordDataType.IsValid') | Indicates if the type is valid and recognized. |
| [Key](Jcd.SRecord.SRecordDataType.Key.md 'Jcd.SRecord.SRecordDataType.Key') | The key for the type. |
| [KeyLength](Jcd.SRecord.SRecordDataType.KeyLength.md 'Jcd.SRecord.SRecordDataType.KeyLength') | The length of the key in characters. |
| [MaximumDataBytesAllowed](Jcd.SRecord.SRecordDataType.MaximumDataBytesAllowed.md 'Jcd.SRecord.SRecordDataType.MaximumDataBytesAllowed') | The maximum number of bytes allowed in the data section for this type. |
| [RecordStartCharacter](Jcd.SRecord.SRecordDataType.RecordStartCharacter.md 'Jcd.SRecord.SRecordDataType.RecordStartCharacter') | The mandatory character that all SRecordData types must start with 'S'. |
| [RequiresSpecialHandling](Jcd.SRecord.SRecordDataType.RequiresSpecialHandling.md 'Jcd.SRecord.SRecordDataType.RequiresSpecialHandling') | Indicates if the type requires special (i.e. non-standard handling. e.g. S4) |

| Methods | |
| :--- | :--- |
| [CreateLookup(byte)](Jcd.SRecord.SRecordDataType.CreateLookup(byte).md 'Jcd.SRecord.SRecordDataType.CreateLookup(byte)') | Creates a lookup table of `SRecordDataType`s. |
| [Equals(object)](Jcd.SRecord.SRecordDataType.Equals(object).md 'Jcd.SRecord.SRecordDataType.Equals(object)') | Indicates whether this instance and a specified object are equal. |
| [GetHashCode()](Jcd.SRecord.SRecordDataType.GetHashCode().md 'Jcd.SRecord.SRecordDataType.GetHashCode()') | Returns the hash code for this instance. |

| Operators | |
| :--- | :--- |
| [operator ==(SRecordDataType, SRecordDataType)](Jcd.SRecord.SRecordDataType.op_Equality(Jcd.SRecord.SRecordDataType,Jcd.SRecord.SRecordDataType).md 'Jcd.SRecord.SRecordDataType.op_Equality(Jcd.SRecord.SRecordDataType, Jcd.SRecord.SRecordDataType)') | Compares two operands to determine if they're equal. |
| [operator !=(SRecordDataType, SRecordDataType)](Jcd.SRecord.SRecordDataType.op_Inequality(Jcd.SRecord.SRecordDataType,Jcd.SRecord.SRecordDataType).md 'Jcd.SRecord.SRecordDataType.op_Inequality(Jcd.SRecord.SRecordDataType, Jcd.SRecord.SRecordDataType)') | Compares two operands to determine if they're not equal. |
