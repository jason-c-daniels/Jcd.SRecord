### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[StrictSRecord](Jcd.SRecord.StrictSRecord.md 'Jcd.SRecord.StrictSRecord')

## StrictSRecord.S8 Field

The identifier for S8 records. Address is 3 bytes. Maximum data bytes allowed 32 bytes.  
This is used to terminate a series of S2 records. If a SRecord file is only used to program  
a memory device and the execution location is ignored, then an address of zero could be used.

```csharp
public static readonly SRecordType S8;
```

#### Field Value
[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')

### Remarks