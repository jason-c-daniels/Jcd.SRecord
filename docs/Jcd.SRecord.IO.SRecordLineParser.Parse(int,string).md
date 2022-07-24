#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordLineParser](Jcd.SRecord.IO.SRecordLineParser.md 'Jcd.SRecord.IO.SRecordLineParser')

## SRecordLineParser.Parse(int, string) Method

Parses a line of text into an SRecordLine.

```csharp
public Jcd.SRecord.Parsers.SRecordLine Parse(int lineNumber, string lineOfText);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordLineParser.Parse(int,string).lineNumber'></a>

`lineNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The line number.

<a name='Jcd.SRecord.IO.SRecordLineParser.Parse(int,string).lineOfText'></a>

`lineOfText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The raw text.

Implements [Parse(int, string)](Jcd.SRecord.Parsers.ISRecordLineParser.Parse(int,string).md 'Jcd.SRecord.Parsers.ISRecordLineParser.Parse(int, string)')

#### Returns
[SRecordLine](Jcd.SRecord.Parsers.SRecordLine.md 'Jcd.SRecord.Parsers.SRecordLine')  
an SRecordLine describing the parsing results.