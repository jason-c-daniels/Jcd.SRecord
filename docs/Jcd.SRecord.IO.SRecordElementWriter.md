#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO')

## SRecordElementWriter Class

Writes `SRecordElement`s to a stream or `TextWriter`.

```csharp
public class SRecordElementWriter :
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordElementWriter

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')

| Constructors | |
| :--- | :--- |
| [SRecordElementWriter(Stream, ISRecordElementFormatter)](Jcd.SRecord.IO.SRecordElementWriter.SRecordElementWriter(System.IO.Stream,Jcd.SRecord.IO.ISRecordElementFormatter).md 'Jcd.SRecord.IO.SRecordElementWriter.SRecordElementWriter(System.IO.Stream, Jcd.SRecord.IO.ISRecordElementFormatter)') | Constructs an instance from a stream and element formatter. |
| [SRecordElementWriter(Stream, Encoding, ISRecordElementFormatter)](Jcd.SRecord.IO.SRecordElementWriter.SRecordElementWriter(System.IO.Stream,System.Text.Encoding,Jcd.SRecord.IO.ISRecordElementFormatter).md 'Jcd.SRecord.IO.SRecordElementWriter.SRecordElementWriter(System.IO.Stream, System.Text.Encoding, Jcd.SRecord.IO.ISRecordElementFormatter)') | Constructs an instance from a stream, an encoding, and element formatter. |
| [SRecordElementWriter(TextWriter, ISRecordElementFormatter)](Jcd.SRecord.IO.SRecordElementWriter.SRecordElementWriter(System.IO.TextWriter,Jcd.SRecord.IO.ISRecordElementFormatter).md 'Jcd.SRecord.IO.SRecordElementWriter.SRecordElementWriter(System.IO.TextWriter, Jcd.SRecord.IO.ISRecordElementFormatter)') | Constructs an instance from a `StreamWriter` and an `ISRecordElementFormatter` |

| Methods | |
| :--- | :--- |
| [Dispose()](Jcd.SRecord.IO.SRecordElementWriter.Dispose().md 'Jcd.SRecord.IO.SRecordElementWriter.Dispose()') | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. |
| [Write(SRecordElement)](Jcd.SRecord.IO.SRecordElementWriter.Write(Jcd.SRecord.IO.SRecordElement).md 'Jcd.SRecord.IO.SRecordElementWriter.Write(Jcd.SRecord.IO.SRecordElement)') | Format and write an SRecordElement to the stream. |
| [Write(IEnumerable&lt;SRecordElement&gt;)](Jcd.SRecord.IO.SRecordElementWriter.Write(System.Collections.Generic.IEnumerable_Jcd.SRecord.IO.SRecordElement_).md 'Jcd.SRecord.IO.SRecordElementWriter.Write(System.Collections.Generic.IEnumerable<Jcd.SRecord.IO.SRecordElement>)') | Writes a set of lines to the stream. |
| [WriteAsync(SRecordElement)](Jcd.SRecord.IO.SRecordElementWriter.WriteAsync(Jcd.SRecord.IO.SRecordElement).md 'Jcd.SRecord.IO.SRecordElementWriter.WriteAsync(Jcd.SRecord.IO.SRecordElement)') | Formats and writes a element to the stream, asynchronously. |
| [WriteAsync(IAsyncEnumerable&lt;SRecordElement&gt;)](Jcd.SRecord.IO.SRecordElementWriter.WriteAsync(System.Collections.Generic.IAsyncEnumerable_Jcd.SRecord.IO.SRecordElement_).md 'Jcd.SRecord.IO.SRecordElementWriter.WriteAsync(System.Collections.Generic.IAsyncEnumerable<Jcd.SRecord.IO.SRecordElement>)') | Writes a set of lines, obtained asynchronously, to a stream, asynchronously. |
| [WriteAsync(IEnumerable&lt;SRecordElement&gt;)](Jcd.SRecord.IO.SRecordElementWriter.WriteAsync(System.Collections.Generic.IEnumerable_Jcd.SRecord.IO.SRecordElement_).md 'Jcd.SRecord.IO.SRecordElementWriter.WriteAsync(System.Collections.Generic.IEnumerable<Jcd.SRecord.IO.SRecordElement>)') | Writes a set of lines to a stream, asynchronously. |
