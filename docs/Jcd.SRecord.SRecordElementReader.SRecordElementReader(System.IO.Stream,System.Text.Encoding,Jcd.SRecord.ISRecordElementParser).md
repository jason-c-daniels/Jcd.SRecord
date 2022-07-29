#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordElementReader](Jcd.SRecord.SRecordElementReader.md 'Jcd.SRecord.SRecordElementReader')

## SRecordElementReader(Stream, Encoding, ISRecordElementParser) Constructor

Constructs an `SRecordElementReader` from a stream.

```csharp
public SRecordElementReader(System.IO.Stream stream, System.Text.Encoding encoding, Jcd.SRecord.ISRecordElementParser parser);
```
#### Parameters

<a name='Jcd.SRecord.SRecordElementReader.SRecordElementReader(System.IO.Stream,System.Text.Encoding,Jcd.SRecord.ISRecordElementParser).stream'></a>

`stream` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')

The stream to read from.

<a name='Jcd.SRecord.SRecordElementReader.SRecordElementReader(System.IO.Stream,System.Text.Encoding,Jcd.SRecord.ISRecordElementParser).encoding'></a>

`encoding` [System.Text.Encoding](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Encoding 'System.Text.Encoding')

The text encoding to use.

<a name='Jcd.SRecord.SRecordElementReader.SRecordElementReader(System.IO.Stream,System.Text.Encoding,Jcd.SRecord.ISRecordElementParser).parser'></a>

`parser` [ISRecordElementParser](Jcd.SRecord.ISRecordElementParser.md 'Jcd.SRecord.ISRecordElementParser')

The parser to use