#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordDocument](Jcd.SRecord.IO.SRecordDocument.md 'Jcd.SRecord.IO.SRecordDocument')

## SRecordDocument.LoadFileAsync(string) Method

Asynchronously loads data from the specified file path into the current  
`SRecordDocument`. This appends to any existing entries.

```csharp
public System.Threading.Tasks.Task LoadFileAsync(string filePath);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordDocument.LoadFileAsync(string).filePath'></a>

`filePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The file to read.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')