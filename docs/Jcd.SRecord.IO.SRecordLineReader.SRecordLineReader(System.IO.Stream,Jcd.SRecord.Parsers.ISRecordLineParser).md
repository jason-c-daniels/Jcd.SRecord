#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordLineReader](Jcd.SRecord.IO.SRecordLineReader.md 'Jcd.SRecord.IO.SRecordLineReader')

## SRecordLineReader(Stream, ISRecordLineParser) Constructor

Constructs an `SRecordLineReader` from a stream.

```csharp
public SRecordLineReader(System.IO.Stream stream, Jcd.SRecord.Parsers.ISRecordLineParser parser);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(System.IO.Stream,Jcd.SRecord.Parsers.ISRecordLineParser).stream'></a>

`stream` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')

The stream to read from.

<a name='Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(System.IO.Stream,Jcd.SRecord.Parsers.ISRecordLineParser).parser'></a>

`parser` [ISRecordLineParser](Jcd.SRecord.Parsers.ISRecordLineParser.md 'Jcd.SRecord.Parsers.ISRecordLineParser')

The parser to use