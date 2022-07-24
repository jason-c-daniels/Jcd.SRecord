#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordLineReader](Jcd.SRecord.IO.SRecordLineReader.md 'Jcd.SRecord.IO.SRecordLineReader')

## SRecordLineReader(string, ISRecordLineParser) Constructor

Constructs an `SRecordLineReader` from a block of text. The encoding is assumed to be UTF8.

```csharp
public SRecordLineReader(string linesOfText, Jcd.SRecord.Parsers.ISRecordLineParser parser);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(string,Jcd.SRecord.Parsers.ISRecordLineParser).linesOfText'></a>

`linesOfText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the block of text.

<a name='Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(string,Jcd.SRecord.Parsers.ISRecordLineParser).parser'></a>

`parser` [ISRecordLineParser](Jcd.SRecord.Parsers.ISRecordLineParser.md 'Jcd.SRecord.Parsers.ISRecordLineParser')

the line parser.