#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType').[Strict](Jcd.SRecord.SRecordDataType.Strict.md 'Jcd.SRecord.SRecordDataType.Strict')

## SRecordDataType.Strict.S5 Field

The identifier for S5 records. Address is 2 bytes. No data allowed.

```csharp
public static readonly SRecordDataType S5;
```

#### Field Value
[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')

### Remarks
This record type is used to contain a 16-bit count of all S1, S2, or S3 records, stored in the address field. There are no data bytes for this record type. This record is used if the record count is less than or equal to 65,535 (0xFFFF).