#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordDocument](Jcd.SRecord.IO.SRecordDocument.md 'Jcd.SRecord.IO.SRecordDocument')

## SRecordDocument.CreateFromFile(string, ISRecordElementParser, ISRecordElementFormatter) Method

Creates a `SRecordDocument` using the provided parser and formatter  
Then loads data from the specified file path.

```csharp
public static Jcd.SRecord.IO.SRecordDocument CreateFromFile(string filePath, Jcd.SRecord.IO.ISRecordElementParser parser=null, Jcd.SRecord.IO.ISRecordElementFormatter formatter=null);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordDocument.CreateFromFile(string,Jcd.SRecord.IO.ISRecordElementParser,Jcd.SRecord.IO.ISRecordElementFormatter).filePath'></a>

`filePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The file to read.

<a name='Jcd.SRecord.IO.SRecordDocument.CreateFromFile(string,Jcd.SRecord.IO.ISRecordElementParser,Jcd.SRecord.IO.ISRecordElementFormatter).parser'></a>

`parser` [ISRecordElementParser](Jcd.SRecord.IO.ISRecordElementParser.md 'Jcd.SRecord.IO.ISRecordElementParser')

The parser. If null the default one is used.

<a name='Jcd.SRecord.IO.SRecordDocument.CreateFromFile(string,Jcd.SRecord.IO.ISRecordElementParser,Jcd.SRecord.IO.ISRecordElementFormatter).formatter'></a>

`formatter` [ISRecordElementFormatter](Jcd.SRecord.IO.ISRecordElementFormatter.md 'Jcd.SRecord.IO.ISRecordElementFormatter')

The formatter to used. If null the default one is used.

#### Returns
[SRecordDocument](Jcd.SRecord.IO.SRecordDocument.md 'Jcd.SRecord.IO.SRecordDocument')  
The new `SRecordDocument` instance