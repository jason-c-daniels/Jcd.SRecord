#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO')

## SRecordLineReader Class

A forward only SRecordLine stream/string reader.  
This class always disposes its Stream/StreamReader when disposed.

```csharp
public class SRecordLineReader :
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordLineReader

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')

| Constructors | |
| :--- | :--- |
| [SRecordLineReader(string, ISRecordLineParser)](Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(string,Jcd.SRecord.Parsers.ISRecordLineParser).md 'Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(string, Jcd.SRecord.Parsers.ISRecordLineParser)') | Constructs an `SRecordLineReader` from a block of text. The encoding is assumed to be UTF8. |
| [SRecordLineReader(string, Encoding, ISRecordLineParser)](Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(string,System.Text.Encoding,Jcd.SRecord.Parsers.ISRecordLineParser).md 'Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(string, System.Text.Encoding, Jcd.SRecord.Parsers.ISRecordLineParser)') | Constructs an `SRecordLineReader` from a block of text. The encoding is assumed to be UTF8. |
| [SRecordLineReader(Stream, ISRecordLineParser)](Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(System.IO.Stream,Jcd.SRecord.Parsers.ISRecordLineParser).md 'Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(System.IO.Stream, Jcd.SRecord.Parsers.ISRecordLineParser)') | Constructs an `SRecordLineReader` from a stream. |
| [SRecordLineReader(Stream, Encoding, ISRecordLineParser)](Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(System.IO.Stream,System.Text.Encoding,Jcd.SRecord.Parsers.ISRecordLineParser).md 'Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(System.IO.Stream, System.Text.Encoding, Jcd.SRecord.Parsers.ISRecordLineParser)') | Constructs an `SRecordLineReader` from a stream. |
| [SRecordLineReader(StreamReader, ISRecordLineParser)](Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(System.IO.StreamReader,Jcd.SRecord.Parsers.ISRecordLineParser).md 'Jcd.SRecord.IO.SRecordLineReader.SRecordLineReader(System.IO.StreamReader, Jcd.SRecord.Parsers.ISRecordLineParser)') | Constructs an `SRecordLineReader` from a stream reader and line parser. |

| Properties | |
| :--- | :--- |
| [CurrentLine](Jcd.SRecord.IO.SRecordLineReader.CurrentLine.md 'Jcd.SRecord.IO.SRecordLineReader.CurrentLine') | The line number of the most recently read line.<br/>This is 0 if nothing has been read and number of the last line in the file,<br/>if all lines have been read. |
| [EndOfData](Jcd.SRecord.IO.SRecordLineReader.EndOfData.md 'Jcd.SRecord.IO.SRecordLineReader.EndOfData') | Indicates if all of the data has been read. |

| Methods | |
| :--- | :--- |
| [Dispose()](Jcd.SRecord.IO.SRecordLineReader.Dispose().md 'Jcd.SRecord.IO.SRecordLineReader.Dispose()') | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. |
| [ReadLine()](Jcd.SRecord.IO.SRecordLineReader.ReadLine().md 'Jcd.SRecord.IO.SRecordLineReader.ReadLine()') | Reads an `SRecordLine` from the stream. |
| [ReadLineAsync()](Jcd.SRecord.IO.SRecordLineReader.ReadLineAsync().md 'Jcd.SRecord.IO.SRecordLineReader.ReadLineAsync()') | Reads an `SRecordLine` from the stream. |
| [ReadRemainingLines()](Jcd.SRecord.IO.SRecordLineReader.ReadRemainingLines().md 'Jcd.SRecord.IO.SRecordLineReader.ReadRemainingLines()') | Get an enumerable of `SRecordLine`s from the input stream from the current position. |
| [ReadRemainingLinesAsync()](Jcd.SRecord.IO.SRecordLineReader.ReadRemainingLinesAsync().md 'Jcd.SRecord.IO.SRecordLineReader.ReadRemainingLinesAsync()') | Get an enumerable of `SRecordLine`s from the input stream, asynchronously |
