#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordLineWriter](Jcd.SRecord.IO.SRecordLineWriter.md 'Jcd.SRecord.IO.SRecordLineWriter')

## SRecordLineWriter.WriteLinesAsync(IEnumerable<SRecordLine>) Method

Writes a set of lines to a stream, asynchronously.

```csharp
public System.Threading.Tasks.Task WriteLinesAsync(System.Collections.Generic.IEnumerable<Jcd.SRecord.Parsers.SRecordLine> lines);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordLineWriter.WriteLinesAsync(System.Collections.Generic.IEnumerable_Jcd.SRecord.Parsers.SRecordLine_).lines'></a>

`lines` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[SRecordLine](Jcd.SRecord.Parsers.SRecordLine.md 'Jcd.SRecord.Parsers.SRecordLine')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The lines to write.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')