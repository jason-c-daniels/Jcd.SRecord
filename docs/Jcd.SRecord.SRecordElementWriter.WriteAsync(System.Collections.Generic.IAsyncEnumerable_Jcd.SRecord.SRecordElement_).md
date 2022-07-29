#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordElementWriter](Jcd.SRecord.SRecordElementWriter.md 'Jcd.SRecord.SRecordElementWriter')

## SRecordElementWriter.WriteAsync(IAsyncEnumerable<SRecordElement>) Method

Writes a set of lines, obtained asynchronously, to a stream, asynchronously.

```csharp
public System.Threading.Tasks.Task WriteAsync(System.Collections.Generic.IAsyncEnumerable<Jcd.SRecord.SRecordElement> lines);
```
#### Parameters

<a name='Jcd.SRecord.SRecordElementWriter.WriteAsync(System.Collections.Generic.IAsyncEnumerable_Jcd.SRecord.SRecordElement_).lines'></a>

`lines` [System.Collections.Generic.IAsyncEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IAsyncEnumerable-1 'System.Collections.Generic.IAsyncEnumerable`1')[SRecordElement](Jcd.SRecord.SRecordElement.md 'Jcd.SRecord.SRecordElement')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IAsyncEnumerable-1 'System.Collections.Generic.IAsyncEnumerable`1')

The lines to write.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')