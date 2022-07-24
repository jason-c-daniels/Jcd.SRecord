#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElementWriter](Jcd.SRecord.IO.SRecordElementWriter.md 'Jcd.SRecord.IO.SRecordElementWriter')

## SRecordElementWriter.WriteAsync(IEnumerable<SRecordElement>) Method

Writes a set of lines to a stream, asynchronously.

```csharp
public System.Threading.Tasks.Task WriteAsync(System.Collections.Generic.IEnumerable<Jcd.SRecord.IO.SRecordElement> lines);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordElementWriter.WriteAsync(System.Collections.Generic.IEnumerable_Jcd.SRecord.IO.SRecordElement_).lines'></a>

`lines` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[SRecordElement](Jcd.SRecord.IO.SRecordElement.md 'Jcd.SRecord.IO.SRecordElement')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The lines to write.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')