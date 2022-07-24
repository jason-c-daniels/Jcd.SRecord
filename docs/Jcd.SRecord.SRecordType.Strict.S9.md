#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType').[Strict](Jcd.SRecord.SRecordType.Strict.md 'Jcd.SRecord.SRecordType.Strict')

## SRecordType.Strict.S9 Field

The identifier for S8 records. Address is 3 bytes.  No data allowed.

```csharp
public static readonly SRecordType S9;
```

#### Field Value
[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')

### Remarks
This is used to terminate a series of S1 records. If a SRecord file is only used to program  
a memory device and the execution location is ignored, then an address of zero could be used.