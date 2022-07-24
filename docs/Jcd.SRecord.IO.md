#### [Jcd.SRecord](index.md 'index')

## Jcd.SRecord.IO Namespace

| Classes | |
| :--- | :--- |
| [SRecordDocument](Jcd.SRecord.IO.SRecordDocument.md 'Jcd.SRecord.IO.SRecordDocument') | Represents an SRecord document. This is a simple document reader/writer.<br/>No S37, or other semantics are enforced. |
| [SRecordElement](Jcd.SRecord.IO.SRecordElement.md 'Jcd.SRecord.IO.SRecordElement') | Represents a single line in an `SRecordDocument` |
| [SRecordElementFormattedEventArgs](Jcd.SRecord.IO.SRecordElementFormattedEventArgs.md 'Jcd.SRecord.IO.SRecordElementFormattedEventArgs') | [System.EventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.EventArgs 'System.EventArgs') is the base class for classes containing event data. |
| [SRecordElementFormatter](Jcd.SRecord.IO.SRecordElementFormatter.md 'Jcd.SRecord.IO.SRecordElementFormatter') | Encapsulates the logic necessary to format an `SRecordElement`<br/>as a line of text. |
| [SRecordElementFormattingEventArgs](Jcd.SRecord.IO.SRecordElementFormattingEventArgs.md 'Jcd.SRecord.IO.SRecordElementFormattingEventArgs') | [System.EventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.EventArgs 'System.EventArgs') is the base class for classes containing event data. |
| [SRecordElementParsedEventArgs](Jcd.SRecord.IO.SRecordElementParsedEventArgs.md 'Jcd.SRecord.IO.SRecordElementParsedEventArgs') | [System.EventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.EventArgs 'System.EventArgs') is the base class for classes containing event data. |
| [SRecordElementParser](Jcd.SRecord.IO.SRecordElementParser.md 'Jcd.SRecord.IO.SRecordElementParser') | Provides a default mechanism for parsing a line of text into<br/>an `SRecordElement`. |
| [SRecordElementParsingEventArgs](Jcd.SRecord.IO.SRecordElementParsingEventArgs.md 'Jcd.SRecord.IO.SRecordElementParsingEventArgs') | [System.EventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.EventArgs 'System.EventArgs') is the base class for classes containing event data. |
| [SRecordElementReader](Jcd.SRecord.IO.SRecordElementReader.md 'Jcd.SRecord.IO.SRecordElementReader') | A forward only `SRecordElement` stream/string reader.<br/>This class always disposes its TextReader when disposed. |
| [SRecordElementWriter](Jcd.SRecord.IO.SRecordElementWriter.md 'Jcd.SRecord.IO.SRecordElementWriter') | Writes `SRecordElement`s to a stream or `TextWriter`. |

| Structs | |
| :--- | :--- |
| [SRecordElementFormatter.Options](Jcd.SRecord.IO.SRecordElementFormatter.Options.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options') | Represents the formatting options desired when writing `SRecordElement` contents<br/>to an `SRecordElementWriter`. |
| [SRecordElementType](Jcd.SRecord.IO.SRecordElementType.md 'Jcd.SRecord.IO.SRecordElementType') | Defines a set of flags that describe the results of parsing a line<br/>of text from an `SRecordDocument` |

| Interfaces | |
| :--- | :--- |
| [ISRecordElementFormatter](Jcd.SRecord.IO.ISRecordElementFormatter.md 'Jcd.SRecord.IO.ISRecordElementFormatter') | Defines the operations necessary to support formatting<br/>`SRecordElement`s to lines of text. |
| [ISRecordElementParser](Jcd.SRecord.IO.ISRecordElementParser.md 'Jcd.SRecord.IO.ISRecordElementParser') | Defines the operations necessary to parse `SRecordElement`s<br/>from text. |
