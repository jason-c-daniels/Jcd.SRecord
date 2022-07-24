#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElementReader](Jcd.SRecord.IO.SRecordElementReader.md 'Jcd.SRecord.IO.SRecordElementReader')

## SRecordElementReader.ReadAsync() Method

Reads an `SRecordElement` from the stream.

```csharp
public System.Threading.Tasks.Task<Jcd.SRecord.IO.SRecordElement> ReadAsync();
```

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[SRecordElement](Jcd.SRecord.IO.SRecordElement.md 'Jcd.SRecord.IO.SRecordElement')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The `SRecordElement`, null if end of stream has been reached.