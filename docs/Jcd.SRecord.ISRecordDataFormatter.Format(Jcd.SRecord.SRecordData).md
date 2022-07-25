#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[ISRecordDataFormatter](Jcd.SRecord.ISRecordDataFormatter.md 'Jcd.SRecord.ISRecordDataFormatter')

## ISRecordDataFormatter.Format(SRecordData) Method

Converts an SRecordData into its ASCII-HEX representation.

```csharp
string Format(Jcd.SRecord.SRecordData sRecord);
```
#### Parameters

<a name='Jcd.SRecord.ISRecordDataFormatter.Format(Jcd.SRecord.SRecordData).sRecord'></a>

`sRecord` [SRecordData](Jcd.SRecord.SRecordData.md 'Jcd.SRecord.SRecordData')

the record to format

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The formatted string (S0030000FC...etc)