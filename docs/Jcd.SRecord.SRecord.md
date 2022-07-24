#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## SRecord Class

Represents a single SRecord entry in an srecord file. This is an immutable type. To edit the contents, create a new one with the altered data buffer, address, and/or type.

```csharp
public class SRecord
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecord

### Remarks
Further reading about the SRecord format can be done  
[ at the Ubuntu manpage](https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html 'https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html')  
and [the wikipedia page](https://en.wikipedia.org/wiki/SREC_(file_format) 'https://en.wikipedia.org/wiki/SREC_(file_format)').

| Constructors | |
| :--- | :--- |
| [SRecord(SRecordType, uint, byte[])](Jcd.SRecord.SRecord.SRecord(Jcd.SRecord.SRecordType,uint,byte[]).md 'Jcd.SRecord.SRecord.SRecord(Jcd.SRecord.SRecordType, uint, byte[])') | Constructs a mew SRecord instance. |

| Fields | |
| :--- | :--- |
| [CheckSumByteLength](Jcd.SRecord.SRecord.CheckSumByteLength.md 'Jcd.SRecord.SRecord.CheckSumByteLength') | The length of the checksum, in bytes. |
| [CountByteLength](Jcd.SRecord.SRecord.CountByteLength.md 'Jcd.SRecord.SRecord.CountByteLength') | The length of the count in bytes |
| [KeyCharLength](Jcd.SRecord.SRecord.KeyCharLength.md 'Jcd.SRecord.SRecord.KeyCharLength') | The length of the record key in characters. |
| [MaxValueForCount](Jcd.SRecord.SRecord.MaxValueForCount.md 'Jcd.SRecord.SRecord.MaxValueForCount') | The maximum value for the count field. |

| Properties | |
| :--- | :--- |
| [Address](Jcd.SRecord.SRecord.Address.md 'Jcd.SRecord.SRecord.Address') | If applicable, the address for data to be written to, or in some cases, a count of preceding records. |
| [Checksum](Jcd.SRecord.SRecord.Checksum.md 'Jcd.SRecord.SRecord.Checksum') | The checksum for the type, address, and data. |
| [CountOfRemainingBytes](Jcd.SRecord.SRecord.CountOfRemainingBytes.md 'Jcd.SRecord.SRecord.CountOfRemainingBytes') | The total count of the address, data, and checksum bytes. |
| [Data](Jcd.SRecord.SRecord.Data.md 'Jcd.SRecord.SRecord.Data') | The data to be loaded into the address. (or in S0's case a descriptor for the file.) |
| [EndAddress](Jcd.SRecord.SRecord.EndAddress.md 'Jcd.SRecord.SRecord.EndAddress') | The computed address of the last byte of data contained in this record.<br/>For records with 0 data length, this will contain the same value as Address. |
| [Type](Jcd.SRecord.SRecord.Type.md 'Jcd.SRecord.SRecord.Type') | The type of SRecord |

| Methods | |
| :--- | :--- |
| [ComputeChecksum(byte[])](Jcd.SRecord.SRecord.ComputeChecksum(byte[]).md 'Jcd.SRecord.SRecord.ComputeChecksum(byte[])') | Computes the checksum for the concatenated bytes contained in the address<br/>and data fields. |
| [ComputeChecksum(SRecordType, byte, uint, byte[])](Jcd.SRecord.SRecord.ComputeChecksum(Jcd.SRecord.SRecordType,byte,uint,byte[]).md 'Jcd.SRecord.SRecord.ComputeChecksum(Jcd.SRecord.SRecordType, byte, uint, byte[])') | Computes the checksum for the record. |
