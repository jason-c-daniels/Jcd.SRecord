#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[ISRecordDataParser](Jcd.SRecord.ISRecordDataParser.md 'Jcd.SRecord.ISRecordDataParser')

## ISRecordDataParser.TryParse(string, SRecordData) Method

Tries parsing a line of text into an `SRecordData`

```csharp
bool TryParse(string lineOfText, out Jcd.SRecord.SRecordData sRecord);
```
#### Parameters

<a name='Jcd.SRecord.ISRecordDataParser.TryParse(string,Jcd.SRecord.SRecordData).lineOfText'></a>

`lineOfText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the text to try parsing.

<a name='Jcd.SRecord.ISRecordDataParser.TryParse(string,Jcd.SRecord.SRecordData).sRecord'></a>

`sRecord` [SRecordData](Jcd.SRecord.SRecordData.md 'Jcd.SRecord.SRecordData')

The result of parsing. null if not parsed.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if successful