#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDataParser](Jcd.SRecord.SRecordDataParser.md 'Jcd.SRecord.SRecordDataParser')

## SRecordDataParser.Parse(string) Method

Parses a line of text into an `SRecordData`, ignoring trailing whitespace.

```csharp
public Jcd.SRecord.SRecordData Parse(string lineOfText);
```
#### Parameters

<a name='Jcd.SRecord.SRecordDataParser.Parse(string).lineOfText'></a>

`lineOfText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The line of text to parse.

Implements [Parse(string)](Jcd.SRecord.ISRecordDataParser.Parse(string).md 'Jcd.SRecord.ISRecordDataParser.Parse(string)')

#### Returns
[SRecordData](Jcd.SRecord.SRecordData.md 'Jcd.SRecord.SRecordData')  
An `SRecordData` instance if it was successfully parsed.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When the passed in text can't be parsed for any reason.