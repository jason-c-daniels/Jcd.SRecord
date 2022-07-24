#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordDocument](Jcd.SRecord.IO.SRecordDocument.md 'Jcd.SRecord.IO.SRecordDocument')

## SRecordDocument.CreateFromString(string, ISRecordElementParser, ISRecordElementFormatter) Method

Creates a `SRecordDocument` using the provided parser and formatter  
Then loads data from the string.

```csharp
public static Jcd.SRecord.IO.SRecordDocument CreateFromString(string text, Jcd.SRecord.IO.ISRecordElementParser parser=null, Jcd.SRecord.IO.ISRecordElementFormatter formatter=null);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordDocument.CreateFromString(string,Jcd.SRecord.IO.ISRecordElementParser,Jcd.SRecord.IO.ISRecordElementFormatter).text'></a>

`text` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The string to load.

<a name='Jcd.SRecord.IO.SRecordDocument.CreateFromString(string,Jcd.SRecord.IO.ISRecordElementParser,Jcd.SRecord.IO.ISRecordElementFormatter).parser'></a>

`parser` [ISRecordElementParser](Jcd.SRecord.IO.ISRecordElementParser.md 'Jcd.SRecord.IO.ISRecordElementParser')

The parser. If null the default one is used.

<a name='Jcd.SRecord.IO.SRecordDocument.CreateFromString(string,Jcd.SRecord.IO.ISRecordElementParser,Jcd.SRecord.IO.ISRecordElementFormatter).formatter'></a>

`formatter` [ISRecordElementFormatter](Jcd.SRecord.IO.ISRecordElementFormatter.md 'Jcd.SRecord.IO.ISRecordElementFormatter')

The formatter to used. If null the default one is used.

#### Returns
[SRecordDocument](Jcd.SRecord.IO.SRecordDocument.md 'Jcd.SRecord.IO.SRecordDocument')  
The new `SRecordDocument` instance