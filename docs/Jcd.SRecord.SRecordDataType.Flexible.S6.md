#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType').[Flexible](Jcd.SRecord.SRecordDataType.Flexible.md 'Jcd.SRecord.SRecordDataType.Flexible')

## SRecordDataType.Flexible.S6 Field

The identifier for S6 records. Address is 3 bytes. No data allowed.

```csharp
public static readonly SRecordDataType S6;
```

#### Field Value
[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')

### Remarks
This record type is used to contain a 24-bit count of all S1, S2, or S3 records,  
stored in the address field. There are no data bytes for this record type.  
This record is used if the record count is less than or equal to 16,777,215 (0xFFFFFF) and   
greater than 65,535 (0xFFFF) records.