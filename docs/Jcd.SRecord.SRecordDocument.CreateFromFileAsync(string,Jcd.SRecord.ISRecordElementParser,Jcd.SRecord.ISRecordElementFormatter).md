#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDocument](Jcd.SRecord.SRecordDocument.md 'Jcd.SRecord.SRecordDocument')

## SRecordDocument.CreateFromFileAsync(string, ISRecordElementParser, ISRecordElementFormatter) Method

Creates the `SRecordDocument` using the provided parser and formatter, then asynchronously loads data from the specified file path.

```csharp
public static System.Threading.Tasks.Task<Jcd.SRecord.SRecordDocument> CreateFromFileAsync(string filePath, Jcd.SRecord.ISRecordElementParser parser=null, Jcd.SRecord.ISRecordElementFormatter formatter=null);
```
#### Parameters

<a name='Jcd.SRecord.SRecordDocument.CreateFromFileAsync(string,Jcd.SRecord.ISRecordElementParser,Jcd.SRecord.ISRecordElementFormatter).filePath'></a>

`filePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The file to read.

<a name='Jcd.SRecord.SRecordDocument.CreateFromFileAsync(string,Jcd.SRecord.ISRecordElementParser,Jcd.SRecord.ISRecordElementFormatter).parser'></a>

`parser` [ISRecordElementParser](Jcd.SRecord.ISRecordElementParser.md 'Jcd.SRecord.ISRecordElementParser')

The parser. If null the default one is used.

<a name='Jcd.SRecord.SRecordDocument.CreateFromFileAsync(string,Jcd.SRecord.ISRecordElementParser,Jcd.SRecord.ISRecordElementFormatter).formatter'></a>

`formatter` [ISRecordElementFormatter](Jcd.SRecord.ISRecordElementFormatter.md 'Jcd.SRecord.ISRecordElementFormatter')

The formatter to used. If null the default one is used.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[SRecordDocument](Jcd.SRecord.SRecordDocument.md 'Jcd.SRecord.SRecordDocument')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The new `SRecordDocument` instance