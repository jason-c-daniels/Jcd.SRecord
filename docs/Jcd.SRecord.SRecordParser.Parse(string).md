#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordParser](Jcd.SRecord.SRecordParser.md 'Jcd.SRecord.SRecordParser')

## SRecordParser.Parse(string) Method

Parses a line of text into an `SRecord, ignoring trailing whitespace.`

```csharp
public Jcd.SRecord.SRecord Parse(string lineOfText);
```
#### Parameters

<a name='Jcd.SRecord.SRecordParser.Parse(string).lineOfText'></a>

`lineOfText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The line of text to parse.

#### Returns
[SRecord](Jcd.SRecord.SRecord.md 'Jcd.SRecord.SRecord')  
An `SRecord` instance if it was successfully parsed.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')

[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')