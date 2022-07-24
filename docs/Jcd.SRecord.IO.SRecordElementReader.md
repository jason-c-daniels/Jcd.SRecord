#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO')

## SRecordElementReader Class

A forward only `SRecordElement` stream/string reader.  
This class always disposes its TextReader when disposed.

```csharp
public class SRecordElementReader :
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordElementReader

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')

| Constructors | |
| :--- | :--- |
| [SRecordElementReader(string, ISRecordElementParser)](Jcd.SRecord.IO.SRecordElementReader.SRecordElementReader(string,Jcd.SRecord.IO.ISRecordElementParser).md 'Jcd.SRecord.IO.SRecordElementReader.SRecordElementReader(string, Jcd.SRecord.IO.ISRecordElementParser)') | Constructs an `SRecordElementReader` from a block of text. The encoding is assumed to be UTF8. |
| [SRecordElementReader(Stream, ISRecordElementParser)](Jcd.SRecord.IO.SRecordElementReader.SRecordElementReader(System.IO.Stream,Jcd.SRecord.IO.ISRecordElementParser).md 'Jcd.SRecord.IO.SRecordElementReader.SRecordElementReader(System.IO.Stream, Jcd.SRecord.IO.ISRecordElementParser)') | Constructs an `SRecordElementReader` from a stream. |
| [SRecordElementReader(Stream, Encoding, ISRecordElementParser)](Jcd.SRecord.IO.SRecordElementReader.SRecordElementReader(System.IO.Stream,System.Text.Encoding,Jcd.SRecord.IO.ISRecordElementParser).md 'Jcd.SRecord.IO.SRecordElementReader.SRecordElementReader(System.IO.Stream, System.Text.Encoding, Jcd.SRecord.IO.ISRecordElementParser)') | Constructs an `SRecordElementReader` from a stream. |
| [SRecordElementReader(TextReader, ISRecordElementParser)](Jcd.SRecord.IO.SRecordElementReader.SRecordElementReader(System.IO.TextReader,Jcd.SRecord.IO.ISRecordElementParser).md 'Jcd.SRecord.IO.SRecordElementReader.SRecordElementReader(System.IO.TextReader, Jcd.SRecord.IO.ISRecordElementParser)') | Constructs an `SRecordElementReader` from a stream reader and line parser. |

| Properties | |
| :--- | :--- |
| [CurrentLine](Jcd.SRecord.IO.SRecordElementReader.CurrentLine.md 'Jcd.SRecord.IO.SRecordElementReader.CurrentLine') | The line number of the most recently read line.<br/>This is 0 if nothing has been read and number of the last line in the file,<br/>if all lines have been read. |
| [EndOfData](Jcd.SRecord.IO.SRecordElementReader.EndOfData.md 'Jcd.SRecord.IO.SRecordElementReader.EndOfData') | Indicates if all of the data has been read. |

| Methods | |
| :--- | :--- |
| [Dispose()](Jcd.SRecord.IO.SRecordElementReader.Dispose().md 'Jcd.SRecord.IO.SRecordElementReader.Dispose()') | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. |
| [Read()](Jcd.SRecord.IO.SRecordElementReader.Read().md 'Jcd.SRecord.IO.SRecordElementReader.Read()') | Reads an `SRecordElement` from the stream. |
| [ReadAsync()](Jcd.SRecord.IO.SRecordElementReader.ReadAsync().md 'Jcd.SRecord.IO.SRecordElementReader.ReadAsync()') | Reads an `SRecordElement` from the stream. |
| [ReadToEnd()](Jcd.SRecord.IO.SRecordElementReader.ReadToEnd().md 'Jcd.SRecord.IO.SRecordElementReader.ReadToEnd()') | Get an enumerable of `SRecordElement`s from the input stream from the current position. |
| [ReadToEndAsync()](Jcd.SRecord.IO.SRecordElementReader.ReadToEndAsync().md 'Jcd.SRecord.IO.SRecordElementReader.ReadToEndAsync()') | Get an enumerable of `SRecordElement`s from the input stream, asynchronously |
