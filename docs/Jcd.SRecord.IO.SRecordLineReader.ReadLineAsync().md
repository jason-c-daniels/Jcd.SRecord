#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordLineReader](Jcd.SRecord.IO.SRecordLineReader.md 'Jcd.SRecord.IO.SRecordLineReader')

## SRecordLineReader.ReadLineAsync() Method

Reads an `SRecordLine` from the stream.

```csharp
public System.Threading.Tasks.Task<Jcd.SRecord.Parsers.SRecordLine> ReadLineAsync();
```

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[SRecordLine](Jcd.SRecord.Parsers.SRecordLine.md 'Jcd.SRecord.Parsers.SRecordLine')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The `SRecordLine`, null if end of stream has been reached.