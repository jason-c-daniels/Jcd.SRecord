#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

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
| [SRecordElementWriter(Stream, ISRecordElementFormatter)](Jcd.SRecord.SRecordElementWriter.SRecordElementWriter(System.IO.Stream,Jcd.SRecord.ISRecordElementFormatter).md 'Jcd.SRecord.SRecordElementWriter.SRecordElementWriter(System.IO.Stream, Jcd.SRecord.ISRecordElementFormatter)') | Constructs an instance from a stream and element formatter. |
| [SRecordElementWriter(Stream, Encoding, ISRecordElementFormatter)](Jcd.SRecord.SRecordElementWriter.SRecordElementWriter(System.IO.Stream,System.Text.Encoding,Jcd.SRecord.ISRecordElementFormatter).md 'Jcd.SRecord.SRecordElementWriter.SRecordElementWriter(System.IO.Stream, System.Text.Encoding, Jcd.SRecord.ISRecordElementFormatter)') | Constructs an instance from a stream, an encoding, and element formatter. |
| [SRecordElementWriter(TextWriter, ISRecordElementFormatter)](Jcd.SRecord.SRecordElementWriter.SRecordElementWriter(System.IO.TextWriter,Jcd.SRecord.ISRecordElementFormatter).md 'Jcd.SRecord.SRecordElementWriter.SRecordElementWriter(System.IO.TextWriter, Jcd.SRecord.ISRecordElementFormatter)') | Constructs an instance from a `StreamWriter` and an `ISRecordElementFormatter` |

| Methods | |
| :--- | :--- |
| [Dispose()](Jcd.SRecord.SRecordElementWriter.Dispose().md 'Jcd.SRecord.SRecordElementWriter.Dispose()') | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. |
| [Write(SRecordElement)](Jcd.SRecord.SRecordElementWriter.Write(Jcd.SRecord.SRecordElement).md 'Jcd.SRecord.SRecordElementWriter.Write(Jcd.SRecord.SRecordElement)') | Format and write an SRecordElement to the stream. |
| [Write(IEnumerable&lt;SRecordElement&gt;)](Jcd.SRecord.SRecordElementWriter.Write(System.Collections.Generic.IEnumerable_Jcd.SRecord.SRecordElement_).md 'Jcd.SRecord.SRecordElementWriter.Write(System.Collections.Generic.IEnumerable<Jcd.SRecord.SRecordElement>)') | Writes a set of lines to the stream. |
| [WriteAsync(SRecordElement)](Jcd.SRecord.SRecordElementWriter.WriteAsync(Jcd.SRecord.SRecordElement).md 'Jcd.SRecord.SRecordElementWriter.WriteAsync(Jcd.SRecord.SRecordElement)') | Formats and writes a element to the stream, asynchronously. |
| [WriteAsync(IAsyncEnumerable&lt;SRecordElement&gt;)](Jcd.SRecord.SRecordElementWriter.WriteAsync(System.Collections.Generic.IAsyncEnumerable_Jcd.SRecord.SRecordElement_).md 'Jcd.SRecord.SRecordElementWriter.WriteAsync(System.Collections.Generic.IAsyncEnumerable<Jcd.SRecord.SRecordElement>)') | Writes a set of lines, obtained asynchronously, to a stream, asynchronously. |
| [WriteAsync(IEnumerable&lt;SRecordElement&gt;)](Jcd.SRecord.SRecordElementWriter.WriteAsync(System.Collections.Generic.IEnumerable_Jcd.SRecord.SRecordElement_).md 'Jcd.SRecord.SRecordElementWriter.WriteAsync(System.Collections.Generic.IEnumerable<Jcd.SRecord.SRecordElement>)') | Writes a set of lines to a stream, asynchronously. |
