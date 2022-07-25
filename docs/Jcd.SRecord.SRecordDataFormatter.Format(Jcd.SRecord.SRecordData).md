#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDataFormatter](Jcd.SRecord.SRecordDataFormatter.md 'Jcd.SRecord.SRecordDataFormatter')

## SRecordDataFormatter.Format(SRecordData) Method

Converts an SRecordData into its ASCII-HEX representation.

```csharp
public string Format(Jcd.SRecord.SRecordData sRecord);
```
#### Parameters

<a name='Jcd.SRecord.SRecordDataFormatter.Format(Jcd.SRecord.SRecordData).sRecord'></a>

`sRecord` [SRecordData](Jcd.SRecord.SRecordData.md 'Jcd.SRecord.SRecordData')

the record to format

Implements [Format(SRecordData)](Jcd.SRecord.ISRecordDataFormatter.Format(Jcd.SRecord.SRecordData).md 'Jcd.SRecord.ISRecordDataFormatter.Format(Jcd.SRecord.SRecordData)')

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The formatted string (S0030000FC...etc)