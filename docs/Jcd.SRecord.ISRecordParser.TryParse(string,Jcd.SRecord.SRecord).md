#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[ISRecordParser](Jcd.SRecord.ISRecordParser.md 'Jcd.SRecord.ISRecordParser')

## ISRecordParser.TryParse(string, SRecord) Method

Tries parsing a line of text into an `SRecord`

```csharp
bool TryParse(string lineOfText, out Jcd.SRecord.SRecord sRecord);
```
#### Parameters

<a name='Jcd.SRecord.ISRecordParser.TryParse(string,Jcd.SRecord.SRecord).lineOfText'></a>

`lineOfText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the text to try parsing.

<a name='Jcd.SRecord.ISRecordParser.TryParse(string,Jcd.SRecord.SRecord).sRecord'></a>

`sRecord` [SRecord](Jcd.SRecord.SRecord.md 'Jcd.SRecord.SRecord')

The result of parsing. null if not parsed.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if successful