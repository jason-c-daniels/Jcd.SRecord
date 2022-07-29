#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordElementReader](Jcd.SRecord.SRecordElementReader.md 'Jcd.SRecord.SRecordElementReader')

## SRecordElementReader(string, ISRecordElementParser) Constructor

Constructs an `SRecordElementReader` from a block of text. The encoding is assumed to be UTF8.

```csharp
public SRecordElementReader(string linesOfText, Jcd.SRecord.ISRecordElementParser parser);
```
#### Parameters

<a name='Jcd.SRecord.SRecordElementReader.SRecordElementReader(string,Jcd.SRecord.ISRecordElementParser).linesOfText'></a>

`linesOfText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the block of text.

<a name='Jcd.SRecord.SRecordElementReader.SRecordElementReader(string,Jcd.SRecord.ISRecordElementParser).parser'></a>

`parser` [ISRecordElementParser](Jcd.SRecord.ISRecordElementParser.md 'Jcd.SRecord.ISRecordElementParser')

the line parser.