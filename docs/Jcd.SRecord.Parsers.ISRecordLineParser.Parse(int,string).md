#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.Parsers](Jcd.SRecord.Parsers.md 'Jcd.SRecord.Parsers').[ISRecordLineParser](Jcd.SRecord.Parsers.ISRecordLineParser.md 'Jcd.SRecord.Parsers.ISRecordLineParser')

## ISRecordLineParser.Parse(int, string) Method

Parses a line of text into an SRecordLine.

```csharp
Jcd.SRecord.Parsers.SRecordLine Parse(int lineNumber, string lineOfText);
```
#### Parameters

<a name='Jcd.SRecord.Parsers.ISRecordLineParser.Parse(int,string).lineNumber'></a>

`lineNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The line number.

<a name='Jcd.SRecord.Parsers.ISRecordLineParser.Parse(int,string).lineOfText'></a>

`lineOfText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The raw text.

#### Returns
[SRecordLine](Jcd.SRecord.Parsers.SRecordLine.md 'Jcd.SRecord.Parsers.SRecordLine')  
an SRecordLine describing the parsing results.