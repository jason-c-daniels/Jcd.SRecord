### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType').[Strict](Jcd.SRecord.SRecordType.Strict.md 'Jcd.SRecord.SRecordType.Strict')

## SRecordType.Strict.S6 Field

The identifier for S6 records. Address is 3 bytes. No data allowed.  
This contains a 24-bit count of all S1, S2, or S3 records.  
This record is used if the record count is less than or equal to 16,777,215 (0xFFFFFF) and   
greater than 65,535 (0xFFFF) records.

```csharp
public static readonly SRecordType S6;
```

#### Field Value
[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')

### Remarks