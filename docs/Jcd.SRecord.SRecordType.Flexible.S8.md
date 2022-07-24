#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType').[Flexible](Jcd.SRecord.SRecordType.Flexible.md 'Jcd.SRecord.SRecordType.Flexible')

## SRecordType.Flexible.S8 Field

The identifier for S8 records. Address is 3 bytes. No data allowed.  
This is used to terminate a series of S2 records.

```csharp
public static readonly SRecordType S8;
```

#### Field Value
[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')

### Remarks
If an SRecord file is only used to program a memory device and the execution location  
is ignored, then an address of zero could be used.