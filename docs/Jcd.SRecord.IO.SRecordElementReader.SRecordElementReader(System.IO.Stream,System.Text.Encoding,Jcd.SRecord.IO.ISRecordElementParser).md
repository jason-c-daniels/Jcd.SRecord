#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElementReader](Jcd.SRecord.IO.SRecordElementReader.md 'Jcd.SRecord.IO.SRecordElementReader')

## SRecordElementReader(Stream, Encoding, ISRecordElementParser) Constructor

Constructs an `SRecordElementReader` from a stream.

```csharp
public SRecordElementReader(System.IO.Stream stream, System.Text.Encoding encoding, Jcd.SRecord.IO.ISRecordElementParser parser);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordElementReader.SRecordElementReader(System.IO.Stream,System.Text.Encoding,Jcd.SRecord.IO.ISRecordElementParser).stream'></a>

`stream` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')

The stream to read from.

<a name='Jcd.SRecord.IO.SRecordElementReader.SRecordElementReader(System.IO.Stream,System.Text.Encoding,Jcd.SRecord.IO.ISRecordElementParser).encoding'></a>

`encoding` [System.Text.Encoding](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Encoding 'System.Text.Encoding')

The text encoding to use.

<a name='Jcd.SRecord.IO.SRecordElementReader.SRecordElementReader(System.IO.Stream,System.Text.Encoding,Jcd.SRecord.IO.ISRecordElementParser).parser'></a>

`parser` [ISRecordElementParser](Jcd.SRecord.IO.ISRecordElementParser.md 'Jcd.SRecord.IO.ISRecordElementParser')

The parser to use