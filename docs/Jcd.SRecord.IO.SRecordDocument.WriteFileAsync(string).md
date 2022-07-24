#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordDocument](Jcd.SRecord.IO.SRecordDocument.md 'Jcd.SRecord.IO.SRecordDocument')

## SRecordDocument.WriteFileAsync(string) Method

Asynchronously creates or replaces a file at the specified path and the  
writes all of the formatted `SRecordElement` data into the file.

```csharp
public System.Threading.Tasks.Task WriteFileAsync(string filePath);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordDocument.WriteFileAsync(string).filePath'></a>

`filePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path of the file to write.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')