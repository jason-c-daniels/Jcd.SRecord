#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType').[Flexible](Jcd.SRecord.SRecordDataType.Flexible.md 'Jcd.SRecord.SRecordDataType.Flexible')

## SRecordDataType.Flexible.S9 Field

The identifier for S8 records. Address is 3 bytes. Maximum data bytes allowed 32 bytes.

```csharp
public static readonly SRecordDataType S9;
```

#### Field Value
[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')

### Remarks
This is used to terminate a series of S1 records. If a SRecordData file is only used to program  
a memory device and the execution location is ignored, then an address of zero could be used.