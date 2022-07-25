#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDocument](Jcd.SRecord.SRecordDocument.md 'Jcd.SRecord.SRecordDocument')

## SRecordDocument.CreateFromFile(string, ISRecordElementParser, ISRecordElementFormatter) Method

Creates a `SRecordDocument` using the provided parser and formatter  
Then loads data from the specified file path.

```csharp
public static Jcd.SRecord.SRecordDocument CreateFromFile(string filePath, Jcd.SRecord.ISRecordElementParser parser=null, Jcd.SRecord.ISRecordElementFormatter formatter=null);
```
#### Parameters

<a name='Jcd.SRecord.SRecordDocument.CreateFromFile(string,Jcd.SRecord.ISRecordElementParser,Jcd.SRecord.ISRecordElementFormatter).filePath'></a>

`filePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The file to read.

<a name='Jcd.SRecord.SRecordDocument.CreateFromFile(string,Jcd.SRecord.ISRecordElementParser,Jcd.SRecord.ISRecordElementFormatter).parser'></a>

`parser` [ISRecordElementParser](Jcd.SRecord.ISRecordElementParser.md 'Jcd.SRecord.ISRecordElementParser')

The parser. If null the default one is used.

<a name='Jcd.SRecord.SRecordDocument.CreateFromFile(string,Jcd.SRecord.ISRecordElementParser,Jcd.SRecord.ISRecordElementFormatter).formatter'></a>

`formatter` [ISRecordElementFormatter](Jcd.SRecord.ISRecordElementFormatter.md 'Jcd.SRecord.ISRecordElementFormatter')

The formatter to used. If null the default one is used.

#### Returns
[SRecordDocument](Jcd.SRecord.SRecordDocument.md 'Jcd.SRecord.SRecordDocument')  
The new `SRecordDocument` instance