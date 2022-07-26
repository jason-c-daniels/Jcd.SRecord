#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## SRecordData Class

Represents a single `SRecordData` entry in an s-record file. This is an immutable type.  
To edit the contents, create a new one with the altered data buffer, address, and/or type.

```csharp
public sealed class SRecordData
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordData

### Remarks
Further reading about the SRecordData format can be done  
[ at the Ubuntu manpage](https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html 'https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html')  
and [the wikipedia page](https://en.wikipedia.org/wiki/SREC_(file_format) 'https://en.wikipedia.org/wiki/SREC_(file_format)').

| Constructors | |
| :--- | :--- |
| [SRecordData(SRecordDataType, uint, byte[])](Jcd.SRecord.SRecordData.SRecordData(Jcd.SRecord.SRecordDataType,uint,byte[]).md 'Jcd.SRecord.SRecordData.SRecordData(Jcd.SRecord.SRecordDataType, uint, byte[])') | Constructs a mew SRecordData instance. |

| Fields | |
| :--- | :--- |
| [CheckSumByteLength](Jcd.SRecord.SRecordData.CheckSumByteLength.md 'Jcd.SRecord.SRecordData.CheckSumByteLength') | The length of the checksum, in bytes. |
| [CountByteLength](Jcd.SRecord.SRecordData.CountByteLength.md 'Jcd.SRecord.SRecordData.CountByteLength') | The length of the count in bytes |
| [KeyCharLength](Jcd.SRecord.SRecordData.KeyCharLength.md 'Jcd.SRecord.SRecordData.KeyCharLength') | The length of the record key in characters. |
| [MaxValueForCount](Jcd.SRecord.SRecordData.MaxValueForCount.md 'Jcd.SRecord.SRecordData.MaxValueForCount') | The maximum value for the count field. |

| Properties | |
| :--- | :--- |
| [Address](Jcd.SRecord.SRecordData.Address.md 'Jcd.SRecord.SRecordData.Address') | If applicable, the address for data to be written to, or in some cases, a count of preceding records. |
| [Checksum](Jcd.SRecord.SRecordData.Checksum.md 'Jcd.SRecord.SRecordData.Checksum') | The checksum for the type, address, and data. |
| [CountOfRemainingBytes](Jcd.SRecord.SRecordData.CountOfRemainingBytes.md 'Jcd.SRecord.SRecordData.CountOfRemainingBytes') | The total count of the address, data, and checksum bytes. |
| [Data](Jcd.SRecord.SRecordData.Data.md 'Jcd.SRecord.SRecordData.Data') | The data to be loaded into the address. (or in S0's case a descriptor for the file.) |
| [EndAddress](Jcd.SRecord.SRecordData.EndAddress.md 'Jcd.SRecord.SRecordData.EndAddress') | The computed address of the last byte of data contained in this record.<br/>For records with 0 data length, this will contain the same value as Address. |
| [Type](Jcd.SRecord.SRecordData.Type.md 'Jcd.SRecord.SRecordData.Type') | The type of SRecordData |

| Methods | |
| :--- | :--- |
| [ComputeChecksum(SRecordDataType, byte, uint, byte[])](Jcd.SRecord.SRecordData.ComputeChecksum(Jcd.SRecord.SRecordDataType,byte,uint,byte[]).md 'Jcd.SRecord.SRecordData.ComputeChecksum(Jcd.SRecord.SRecordDataType, byte, uint, byte[])') | Computes the checksum for the record. |
