#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDocument](Jcd.SRecord.SRecordDocument.md 'Jcd.SRecord.SRecordDocument')

## SRecordDocument.CreateFromString(string, ISRecordElementParser, ISRecordElementFormatter) Method

Creates a `SRecordDocument` using the provided parser and formatter, then loads data from the string.

```csharp
public static Jcd.SRecord.SRecordDocument CreateFromString(string text, Jcd.SRecord.ISRecordElementParser parser=null, Jcd.SRecord.ISRecordElementFormatter formatter=null);
```
#### Parameters

<a name='Jcd.SRecord.SRecordDocument.CreateFromString(string,Jcd.SRecord.ISRecordElementParser,Jcd.SRecord.ISRecordElementFormatter).text'></a>

`text` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The string to load.

<a name='Jcd.SRecord.SRecordDocument.CreateFromString(string,Jcd.SRecord.ISRecordElementParser,Jcd.SRecord.ISRecordElementFormatter).parser'></a>

`parser` [ISRecordElementParser](Jcd.SRecord.ISRecordElementParser.md 'Jcd.SRecord.ISRecordElementParser')

The parser. If null the default one is used.

<a name='Jcd.SRecord.SRecordDocument.CreateFromString(string,Jcd.SRecord.ISRecordElementParser,Jcd.SRecord.ISRecordElementFormatter).formatter'></a>

`formatter` [ISRecordElementFormatter](Jcd.SRecord.ISRecordElementFormatter.md 'Jcd.SRecord.ISRecordElementFormatter')

The formatter to used. If null the default one is used.

#### Returns
[SRecordDocument](Jcd.SRecord.SRecordDocument.md 'Jcd.SRecord.SRecordDocument')  
The new `SRecordDocument` instance