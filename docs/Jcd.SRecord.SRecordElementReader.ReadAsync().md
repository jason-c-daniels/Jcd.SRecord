#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordElementReader](Jcd.SRecord.SRecordElementReader.md 'Jcd.SRecord.SRecordElementReader')

## SRecordElementReader.ReadAsync() Method

Reads an `SRecordElement` from the stream.

```csharp
public System.Threading.Tasks.Task<Jcd.SRecord.SRecordElement> ReadAsync();
```

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[SRecordElement](Jcd.SRecord.SRecordElement.md 'Jcd.SRecord.SRecordElement')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The `SRecordElement`, null if end of stream has been reached.

### Remarks
NOTE: This will overflow and depending on if it's used in an unchecked context, may or may not throw an exception if you try to parse more than int.MaxValue lines.