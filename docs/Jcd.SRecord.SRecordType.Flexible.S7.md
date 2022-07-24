#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType').[Flexible](Jcd.SRecord.SRecordType.Flexible.md 'Jcd.SRecord.SRecordType.Flexible')

## SRecordType.Flexible.S7 Field

The identifier for S7 records. Address is 4 bytes.  No data allowed.  
This is used to terminate a series of S3 records.

```csharp
public static readonly SRecordType S7;
```

#### Field Value
[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')

### Remarks
If an SRecord file is only used to program a memory device and the execution location  
is ignored, then an address of zero could be used.