#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType').[Strict](Jcd.SRecord.SRecordDataType.Strict.md 'Jcd.SRecord.SRecordDataType.Strict')

## SRecordDataType.Strict.S9 Field

The identifier for S8 records. Address is 3 bytes.  No data allowed.

```csharp
public static readonly SRecordDataType S9;
```

#### Field Value
[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')

### Remarks
This is used to terminate a series of S1 records. If a SRecordData file is only used to program  
a memory device and the execution location is ignored, then an address of zero could be used.