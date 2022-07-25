#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType').[Flexible](Jcd.SRecord.SRecordDataType.Flexible.md 'Jcd.SRecord.SRecordDataType.Flexible')

## SRecordDataType.Flexible.S7 Field

The identifier for S7 records. Address is 4 bytes.  No data allowed.  
This is used to terminate a series of S3 records.

```csharp
public static readonly SRecordDataType S7;
```

#### Field Value
[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')

### Remarks
If an SRecordData file is only used to program a memory device and the execution location  
is ignored, then an address of zero could be used.