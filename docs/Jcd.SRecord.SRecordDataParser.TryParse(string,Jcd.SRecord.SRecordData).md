#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDataParser](Jcd.SRecord.SRecordDataParser.md 'Jcd.SRecord.SRecordDataParser')

## SRecordDataParser.TryParse(string, SRecordData) Method

Tries parsing a line of text into an `SRecordData`

```csharp
public bool TryParse(string lineOfText, out Jcd.SRecord.SRecordData sRecord);
```
#### Parameters

<a name='Jcd.SRecord.SRecordDataParser.TryParse(string,Jcd.SRecord.SRecordData).lineOfText'></a>

`lineOfText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the text to try parsing.

<a name='Jcd.SRecord.SRecordDataParser.TryParse(string,Jcd.SRecord.SRecordData).sRecord'></a>

`sRecord` [SRecordData](Jcd.SRecord.SRecordData.md 'Jcd.SRecord.SRecordData')

The result of parsing. null if not parsed.

Implements [TryParse(string, SRecordData)](Jcd.SRecord.ISRecordDataParser.TryParse(string,Jcd.SRecord.SRecordData).md 'Jcd.SRecord.ISRecordDataParser.TryParse(string, Jcd.SRecord.SRecordData)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if successful