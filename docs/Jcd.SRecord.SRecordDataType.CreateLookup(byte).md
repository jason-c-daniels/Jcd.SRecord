#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')

## SRecordDataType.CreateLookup(byte) Method

Creates a lookup table of `SRecordDataType`s.

```csharp
public static System.Collections.ObjectModel.ReadOnlyDictionary<string,Jcd.SRecord.SRecordDataType> CreateLookup(byte dataBytesPerRecord=250);
```
#### Parameters

<a name='Jcd.SRecord.SRecordDataType.CreateLookup(byte).dataBytesPerRecord'></a>

`dataBytesPerRecord` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The number of data bytes you want any S1,S2, or S3 record to hold.

#### Returns
[System.Collections.ObjectModel.ReadOnlyDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyDictionary-2 'System.Collections.ObjectModel.ReadOnlyDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyDictionary-2 'System.Collections.ObjectModel.ReadOnlyDictionary`2')[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyDictionary-2 'System.Collections.ObjectModel.ReadOnlyDictionary`2')  
Returns a lookup table for record types.