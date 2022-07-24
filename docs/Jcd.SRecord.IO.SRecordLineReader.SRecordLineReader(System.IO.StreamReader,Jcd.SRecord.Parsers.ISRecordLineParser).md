#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordLineReader](Jcd.SRecord.IO.SRecordLineReader.md 'Jcd.SRecord.IO.SRecordLineReader')

## SRecordLineReader(StreamReader, ISRecordLineParser) Constructor

Constructs an `SRecordLineReader` from a stream reader and line parser.

```csharp
public SRecordLineReader(System.IO.StreamReader streamReader, Jcd.SRecord.Parsers.ISRecordLineParser parser);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(System.IO.StreamReader,Jcd.SRecord.Parsers.ISRecordLineParser).streamReader'></a>

`streamReader` [System.IO.StreamReader](https://docs.microsoft.com/en-us/dotnet/api/System.IO.StreamReader 'System.IO.StreamReader')

The reader

<a name='Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(System.IO.StreamReader,Jcd.SRecord.Parsers.ISRecordLineParser).parser'></a>

`parser` [ISRecordLineParser](Jcd.SRecord.Parsers.ISRecordLineParser.md 'Jcd.SRecord.Parsers.ISRecordLineParser')

The parser