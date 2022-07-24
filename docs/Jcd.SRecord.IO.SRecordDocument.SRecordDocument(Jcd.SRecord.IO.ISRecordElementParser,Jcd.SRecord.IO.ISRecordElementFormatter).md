#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordDocument](Jcd.SRecord.IO.SRecordDocument.md 'Jcd.SRecord.IO.SRecordDocument')

## SRecordDocument(ISRecordElementParser, ISRecordElementFormatter) Constructor

Creates an instance of an `SRecordDocument`.

```csharp
public SRecordDocument(Jcd.SRecord.IO.ISRecordElementParser parser=null, Jcd.SRecord.IO.ISRecordElementFormatter formatter=null);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordDocument.SRecordDocument(Jcd.SRecord.IO.ISRecordElementParser,Jcd.SRecord.IO.ISRecordElementFormatter).parser'></a>

`parser` [ISRecordElementParser](Jcd.SRecord.IO.ISRecordElementParser.md 'Jcd.SRecord.IO.ISRecordElementParser')

The parser to use for parsing `SRecordElement` text. If null the default one is used.

<a name='Jcd.SRecord.IO.SRecordDocument.SRecordDocument(Jcd.SRecord.IO.ISRecordElementParser,Jcd.SRecord.IO.ISRecordElementFormatter).formatter'></a>

`formatter` [ISRecordElementFormatter](Jcd.SRecord.IO.ISRecordElementFormatter.md 'Jcd.SRecord.IO.ISRecordElementFormatter')

The formatter to use when writing `SRecordElement`s. If null the default one is used.