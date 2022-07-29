#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[ISRecordDataParser](Jcd.SRecord.ISRecordDataParser.md 'Jcd.SRecord.ISRecordDataParser')

## ISRecordDataParser.Parse(string) Method

Parses a line of text into an `SRecordData`, ignoring trailing whitespace.

```csharp
Jcd.SRecord.SRecordData Parse(string lineOfText);
```
#### Parameters

<a name='Jcd.SRecord.ISRecordDataParser.Parse(string).lineOfText'></a>

`lineOfText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The line of text to parse.

#### Returns
[SRecordData](Jcd.SRecord.SRecordData.md 'Jcd.SRecord.SRecordData')  
An `SRecordData` instance if it was successfully parsed.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')

[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')