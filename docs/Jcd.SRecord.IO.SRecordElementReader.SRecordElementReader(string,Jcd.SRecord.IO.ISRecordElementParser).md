#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElementReader](Jcd.SRecord.IO.SRecordElementReader.md 'Jcd.SRecord.IO.SRecordElementReader')

## SRecordElementReader(string, ISRecordElementParser) Constructor

Constructs an `SRecordElementReader` from a block of text. The encoding is assumed to be UTF8.

```csharp
public SRecordElementReader(string linesOfText, Jcd.SRecord.IO.ISRecordElementParser parser);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordElementReader.SRecordElementReader(string,Jcd.SRecord.IO.ISRecordElementParser).linesOfText'></a>

`linesOfText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the block of text.

<a name='Jcd.SRecord.IO.SRecordElementReader.SRecordElementReader(string,Jcd.SRecord.IO.ISRecordElementParser).parser'></a>

`parser` [ISRecordElementParser](Jcd.SRecord.IO.ISRecordElementParser.md 'Jcd.SRecord.IO.ISRecordElementParser')

the line parser.