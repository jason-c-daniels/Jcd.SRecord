### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[FlexibleSRecord](Jcd.SRecord.FlexibleSRecord.md 'Jcd.SRecord.FlexibleSRecord')

## FlexibleSRecord.S7 Field

The identifier for S7 records. Address is 4 bytes.   
This is used to terminate a series of S3 records. If a SRecord file is only used to program  
a memory device and the execution location is ignored, then an address of zero could be  
used.

```csharp
public static readonly SRecordType S7;
```

#### Field Value
[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')

### Remarks