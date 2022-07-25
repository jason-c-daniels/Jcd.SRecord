#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordParser](Jcd.SRecord.SRecordParser.md 'Jcd.SRecord.SRecordParser')

## SRecordParser.Create(byte) Method

Creates a new instance of an SRecordParser configured to parse records  
containing the configured maxDataBytesPerRecord.

```csharp
public static Jcd.SRecord.SRecordParser Create(byte maxDataBytesPerRecord=byte.MaxValue);
```
#### Parameters

<a name='Jcd.SRecord.SRecordParser.Create(byte).maxDataBytesPerRecord'></a>

`maxDataBytesPerRecord` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

#### Returns
[SRecordParser](Jcd.SRecord.SRecordParser.md 'Jcd.SRecord.SRecordParser')  
The new, or stock, instance of the SRecordParser

### Remarks
When maxDataBytesPerRecord is greater than 250, the Flexible instance is used instead of creating a new one.