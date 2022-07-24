#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordDocument](Jcd.SRecord.IO.SRecordDocument.md 'Jcd.SRecord.IO.SRecordDocument')

## SRecordDocument.CreateFromFileAsync(string, ISRecordElementParser, ISRecordElementFormatter) Method

Creates the `SRecordDocument` using the provided parser and formatter  
Then asynchronously loads data from the specified file path.

```csharp
public static System.Threading.Tasks.Task<Jcd.SRecord.IO.SRecordDocument> CreateFromFileAsync(string filePath, Jcd.SRecord.IO.ISRecordElementParser parser=null, Jcd.SRecord.IO.ISRecordElementFormatter formatter=null);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordDocument.CreateFromFileAsync(string,Jcd.SRecord.IO.ISRecordElementParser,Jcd.SRecord.IO.ISRecordElementFormatter).filePath'></a>

`filePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The file to read.

<a name='Jcd.SRecord.IO.SRecordDocument.CreateFromFileAsync(string,Jcd.SRecord.IO.ISRecordElementParser,Jcd.SRecord.IO.ISRecordElementFormatter).parser'></a>

`parser` [ISRecordElementParser](Jcd.SRecord.IO.ISRecordElementParser.md 'Jcd.SRecord.IO.ISRecordElementParser')

The parser. If null the default one is used.

<a name='Jcd.SRecord.IO.SRecordDocument.CreateFromFileAsync(string,Jcd.SRecord.IO.ISRecordElementParser,Jcd.SRecord.IO.ISRecordElementFormatter).formatter'></a>

`formatter` [ISRecordElementFormatter](Jcd.SRecord.IO.ISRecordElementFormatter.md 'Jcd.SRecord.IO.ISRecordElementFormatter')

The formatter to used. If null the default one is used.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[SRecordDocument](Jcd.SRecord.IO.SRecordDocument.md 'Jcd.SRecord.IO.SRecordDocument')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The new `SRecordDocument` instance