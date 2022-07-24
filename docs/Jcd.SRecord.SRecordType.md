#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## SRecordType Struct

Represents the information required to identify and process various types of SRecords  
[
            as documented here
            ](https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html 'https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html')

```csharp
public struct SRecordType
```

| Constructors | |
| :--- | :--- |
| [SRecordType(string, byte, bool, bool)](Jcd.SRecord.SRecordType.SRecordType(string,byte,bool,bool).md 'Jcd.SRecord.SRecordType.SRecordType(string, byte, bool, bool)') | Constructs an SRecordType, which identifies how to properly process and/or parse<br/>an SRecord of the specified type, provided the key, address length. The maximum<br/>data length is computed from the following formula:<br/>MaximumDataBytesAllowed = SRecord.MaxValueForCount - SRecord.CheckSumByteLength - addressLengthInBytes; |
| [SRecordType(string, byte, byte, bool, bool)](Jcd.SRecord.SRecordType.SRecordType(string,byte,byte,bool,bool).md 'Jcd.SRecord.SRecordType.SRecordType(string, byte, byte, bool, bool)') | Constructs an SRecordType, which identifies how to properly process and/or parse<br/>an SRecord of the specified type, provided the key, address length, and<br/>maximum data bytes allowed. |

| Fields | |
| :--- | :--- |
| [AddressLengthInBytes](Jcd.SRecord.SRecordType.AddressLengthInBytes.md 'Jcd.SRecord.SRecordType.AddressLengthInBytes') | The number of bytes used to represent the address. |
| [IsValid](Jcd.SRecord.SRecordType.IsValid.md 'Jcd.SRecord.SRecordType.IsValid') | Indicates if the type is valid and recognized. |
| [Key](Jcd.SRecord.SRecordType.Key.md 'Jcd.SRecord.SRecordType.Key') | The key for the type. |
| [KeyLength](Jcd.SRecord.SRecordType.KeyLength.md 'Jcd.SRecord.SRecordType.KeyLength') | The length of the key in characters. |
| [MaximumDataBytesAllowed](Jcd.SRecord.SRecordType.MaximumDataBytesAllowed.md 'Jcd.SRecord.SRecordType.MaximumDataBytesAllowed') | The maximum number of bytes allowed in the data section for this type. |
| [RecordStartCharacter](Jcd.SRecord.SRecordType.RecordStartCharacter.md 'Jcd.SRecord.SRecordType.RecordStartCharacter') | The mandatory character that all SRecord types must start with 'S'. |
| [RequiresSpecialHandling](Jcd.SRecord.SRecordType.RequiresSpecialHandling.md 'Jcd.SRecord.SRecordType.RequiresSpecialHandling') | Indicates if the type requires special (i.e. non-standard handling. e.g. S4) |

| Methods | |
| :--- | :--- |
| [CreateLookup(byte)](Jcd.SRecord.SRecordType.CreateLookup(byte).md 'Jcd.SRecord.SRecordType.CreateLookup(byte)') | Creates a lookup table of `SRecordType`s. |
