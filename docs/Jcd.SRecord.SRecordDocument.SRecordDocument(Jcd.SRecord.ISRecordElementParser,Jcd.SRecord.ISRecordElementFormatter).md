#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDocument](Jcd.SRecord.SRecordDocument.md 'Jcd.SRecord.SRecordDocument')

## SRecordDocument(ISRecordElementParser, ISRecordElementFormatter) Constructor

Creates an instance of an `SRecordDocument`.

```csharp
public SRecordDocument(Jcd.SRecord.ISRecordElementParser parser=null, Jcd.SRecord.ISRecordElementFormatter formatter=null);
```
#### Parameters

<a name='Jcd.SRecord.SRecordDocument.SRecordDocument(Jcd.SRecord.ISRecordElementParser,Jcd.SRecord.ISRecordElementFormatter).parser'></a>

`parser` [ISRecordElementParser](Jcd.SRecord.ISRecordElementParser.md 'Jcd.SRecord.ISRecordElementParser')

The parser to use for parsing `SRecordElement` text. If null the default one is used.

<a name='Jcd.SRecord.SRecordDocument.SRecordDocument(Jcd.SRecord.ISRecordElementParser,Jcd.SRecord.ISRecordElementFormatter).formatter'></a>

`formatter` [ISRecordElementFormatter](Jcd.SRecord.ISRecordElementFormatter.md 'Jcd.SRecord.ISRecordElementFormatter')

The formatter to use when writing `SRecordElement`s. If null the default one is used.