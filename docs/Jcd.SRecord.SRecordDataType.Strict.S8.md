#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType').[Strict](Jcd.SRecord.SRecordDataType.Strict.md 'Jcd.SRecord.SRecordDataType.Strict')

## SRecordDataType.Strict.S8 Field

The identifier for S8 records. Address is 3 bytes.  No data allowed.  
This is used to terminate a series of S2 records.

```csharp
public static readonly SRecordDataType S8;
```

#### Field Value
[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')

### Remarks
If an SRecordData file is only used to program a memory device and the execution location is ignored, then an address of zero could be used.