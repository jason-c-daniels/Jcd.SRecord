#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDataParser](Jcd.SRecord.SRecordDataParser.md 'Jcd.SRecord.SRecordDataParser')

## SRecordDataParser.Create(byte) Method

Creates a new instance of an SRecordDataParser configured to parse records  
containing the configured maxDataBytesPerRecord.

```csharp
public static Jcd.SRecord.SRecordDataParser Create(byte maxDataBytesPerRecord=byte.MaxValue);
```
#### Parameters

<a name='Jcd.SRecord.SRecordDataParser.Create(byte).maxDataBytesPerRecord'></a>

`maxDataBytesPerRecord` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

#### Returns
[SRecordDataParser](Jcd.SRecord.SRecordDataParser.md 'Jcd.SRecord.SRecordDataParser')  
The new, or stock, instance of the SRecordDataParser

### Remarks
When maxDataBytesPerRecord is greater than 250, the Flexible instance is used instead of creating a new one.