#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[ISRecordParser](Jcd.SRecord.ISRecordParser.md 'Jcd.SRecord.ISRecordParser')

## ISRecordParser.Parse(string) Method

Parses a line of text into an `SRecord, ignoring trailing whitespace.`

```csharp
Jcd.SRecord.SRecord Parse(string lineOfText);
```
#### Parameters

<a name='Jcd.SRecord.ISRecordParser.Parse(string).lineOfText'></a>

`lineOfText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The line of text to parse.

#### Returns
[SRecord](Jcd.SRecord.SRecord.md 'Jcd.SRecord.SRecord')  
An `SRecord` instance if it was successfully parsed.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')

[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')