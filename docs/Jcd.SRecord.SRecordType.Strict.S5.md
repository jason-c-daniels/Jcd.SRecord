#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType').[Strict](Jcd.SRecord.SRecordType.Strict.md 'Jcd.SRecord.SRecordType.Strict')

## SRecordType.Strict.S5 Field

The identifier for S5 records. Address is 2 bytes. No data allowed.

```csharp
public static readonly SRecordType S5;
```

#### Field Value
[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')

### Remarks
This record type is used to contain a 16-bit count of all S1, S2, or S3 records,  
stored in the address field. There are no data bytes for this record type.  
This record is used if the record count is less than or equal to 65,535 (0xFFFF).