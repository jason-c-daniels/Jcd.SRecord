#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO')

## SRecordLineWriter Class

Writes `SRecordLine`s to a stream.

```csharp
public class SRecordLineWriter :
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordLineWriter

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')

| Constructors | |
| :--- | :--- |
| [SRecordLineWriter(Stream, ISRecordLineFormatter)](Jcd.SRecord.IO.SRecordLineWriter.SRecordLineWriter(System.IO.Stream,Jcd.SRecord.IO.ISRecordLineFormatter).md 'Jcd.SRecord.IO.SRecordLineWriter.SRecordLineWriter(System.IO.Stream, Jcd.SRecord.IO.ISRecordLineFormatter)') | Constructs an instance from a stream and line formatter. |
| [SRecordLineWriter(Stream, Encoding, ISRecordLineFormatter)](Jcd.SRecord.IO.SRecordLineWriter.SRecordLineWriter(System.IO.Stream,System.Text.Encoding,Jcd.SRecord.IO.ISRecordLineFormatter).md 'Jcd.SRecord.IO.SRecordLineWriter.SRecordLineWriter(System.IO.Stream, System.Text.Encoding, Jcd.SRecord.IO.ISRecordLineFormatter)') | Constructs an instance from a stream, an encoding, and line formatter. |
| [SRecordLineWriter(StreamWriter, ISRecordLineFormatter)](Jcd.SRecord.IO.SRecordLineWriter.SRecordLineWriter(System.IO.StreamWriter,Jcd.SRecord.IO.ISRecordLineFormatter).md 'Jcd.SRecord.IO.SRecordLineWriter.SRecordLineWriter(System.IO.StreamWriter, Jcd.SRecord.IO.ISRecordLineFormatter)') | Constructs an instance from a `StreamWriter` and an `ISRecordLineFormatter` |

| Methods | |
| :--- | :--- |
| [Dispose()](Jcd.SRecord.IO.SRecordLineWriter.Dispose().md 'Jcd.SRecord.IO.SRecordLineWriter.Dispose()') | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. |
| [WriteLine(SRecordLine)](Jcd.SRecord.IO.SRecordLineWriter.WriteLine(Jcd.SRecord.Parsers.SRecordLine).md 'Jcd.SRecord.IO.SRecordLineWriter.WriteLine(Jcd.SRecord.Parsers.SRecordLine)') | Format and write an SRecordLine to the stream. |
| [WriteLineAsync(SRecordLine)](Jcd.SRecord.IO.SRecordLineWriter.WriteLineAsync(Jcd.SRecord.Parsers.SRecordLine).md 'Jcd.SRecord.IO.SRecordLineWriter.WriteLineAsync(Jcd.SRecord.Parsers.SRecordLine)') | Formats and writes a line to the stream, asynchronously. |
| [WriteLines(IEnumerable&lt;SRecordLine&gt;)](Jcd.SRecord.IO.SRecordLineWriter.WriteLines(System.Collections.Generic.IEnumerable_Jcd.SRecord.Parsers.SRecordLine_).md 'Jcd.SRecord.IO.SRecordLineWriter.WriteLines(System.Collections.Generic.IEnumerable<Jcd.SRecord.Parsers.SRecordLine>)') | Writes a set of lines to the stream. |
| [WriteLinesAsync(IEnumerable&lt;SRecordLine&gt;)](Jcd.SRecord.IO.SRecordLineWriter.WriteLinesAsync(System.Collections.Generic.IEnumerable_Jcd.SRecord.Parsers.SRecordLine_).md 'Jcd.SRecord.IO.SRecordLineWriter.WriteLinesAsync(System.Collections.Generic.IEnumerable<Jcd.SRecord.Parsers.SRecordLine>)') | Writes a set of lines to a stream, asynchronously. |
