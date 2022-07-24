#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordLineReader](Jcd.SRecord.IO.SRecordLineReader.md 'Jcd.SRecord.IO.SRecordLineReader')

## SRecordLineReader(Stream, Encoding, ISRecordLineParser) Constructor

Constructs an `SRecordLineReader` from a stream.

```csharp
public SRecordLineReader(System.IO.Stream stream, System.Text.Encoding encoding, Jcd.SRecord.Parsers.ISRecordLineParser parser);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(System.IO.Stream,System.Text.Encoding,Jcd.SRecord.Parsers.ISRecordLineParser).stream'></a>

`stream` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')

The stream to read from.

<a name='Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(System.IO.Stream,System.Text.Encoding,Jcd.SRecord.Parsers.ISRecordLineParser).encoding'></a>

`encoding` [System.Text.Encoding](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Encoding 'System.Text.Encoding')

The text encoding to use.

<a name='Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(System.IO.Stream,System.Text.Encoding,Jcd.SRecord.Parsers.ISRecordLineParser).parser'></a>

`parser` [ISRecordLineParser](Jcd.SRecord.Parsers.ISRecordLineParser.md 'Jcd.SRecord.Parsers.ISRecordLineParser')

The parser to use