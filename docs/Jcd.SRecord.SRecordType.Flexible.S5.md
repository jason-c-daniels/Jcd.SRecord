### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType').[Flexible](Jcd.SRecord.SRecordType.Flexible.md 'Jcd.SRecord.SRecordType.Flexible')

## SRecordType.Flexible.S5 Field

The identifier for S5 records. Address is 2 bytes. No data allowed.  
This contains a 16-bit count of all S1, S2, or S3 records.  
This record is used if the record count is less than or equal to 0xFFFF.

```csharp
public static readonly SRecordType S5;
```

#### Field Value
[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')

### Remarks