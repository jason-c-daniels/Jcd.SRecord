#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

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
| [SRecordElementReader(string, ISRecordElementParser)](Jcd.SRecord.SRecordElementReader.SRecordElementReader(string,Jcd.SRecord.ISRecordElementParser).md 'Jcd.SRecord.SRecordElementReader.SRecordElementReader(string, Jcd.SRecord.ISRecordElementParser)') | Constructs an `SRecordElementReader` from a block of text. The encoding is assumed to be UTF8. |
| [SRecordElementReader(Stream, ISRecordElementParser)](Jcd.SRecord.SRecordElementReader.SRecordElementReader(System.IO.Stream,Jcd.SRecord.ISRecordElementParser).md 'Jcd.SRecord.SRecordElementReader.SRecordElementReader(System.IO.Stream, Jcd.SRecord.ISRecordElementParser)') | Constructs an `SRecordElementReader` from a stream. |
| [SRecordElementReader(Stream, Encoding, ISRecordElementParser)](Jcd.SRecord.SRecordElementReader.SRecordElementReader(System.IO.Stream,System.Text.Encoding,Jcd.SRecord.ISRecordElementParser).md 'Jcd.SRecord.SRecordElementReader.SRecordElementReader(System.IO.Stream, System.Text.Encoding, Jcd.SRecord.ISRecordElementParser)') | Constructs an `SRecordElementReader` from a stream. |
| [SRecordElementReader(TextReader, ISRecordElementParser)](Jcd.SRecord.SRecordElementReader.SRecordElementReader(System.IO.TextReader,Jcd.SRecord.ISRecordElementParser).md 'Jcd.SRecord.SRecordElementReader.SRecordElementReader(System.IO.TextReader, Jcd.SRecord.ISRecordElementParser)') | Constructs an `SRecordElementReader` from a stream reader and line parser. |

| Properties | |
| :--- | :--- |
| [CurrentLine](Jcd.SRecord.SRecordElementReader.CurrentLine.md 'Jcd.SRecord.SRecordElementReader.CurrentLine') | The line number of the most recently read line. |
| [EndOfData](Jcd.SRecord.SRecordElementReader.EndOfData.md 'Jcd.SRecord.SRecordElementReader.EndOfData') | Indicates if all of the data has been read. |

| Methods | |
| :--- | :--- |
| [Dispose()](Jcd.SRecord.SRecordElementReader.Dispose().md 'Jcd.SRecord.SRecordElementReader.Dispose()') | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. |
| [Read()](Jcd.SRecord.SRecordElementReader.Read().md 'Jcd.SRecord.SRecordElementReader.Read()') | Reads an `SRecordElement` from the stream. |
| [ReadAsync()](Jcd.SRecord.SRecordElementReader.ReadAsync().md 'Jcd.SRecord.SRecordElementReader.ReadAsync()') | Reads an `SRecordElement` from the stream. |
| [ReadToEnd()](Jcd.SRecord.SRecordElementReader.ReadToEnd().md 'Jcd.SRecord.SRecordElementReader.ReadToEnd()') | Get an enumerable of `SRecordElement`s from the input stream from the current position. |
| [ReadToEndAsync()](Jcd.SRecord.SRecordElementReader.ReadToEndAsync().md 'Jcd.SRecord.SRecordElementReader.ReadToEndAsync()') | Get an enumerable of `SRecordElement`s from the input stream, asynchronously |
