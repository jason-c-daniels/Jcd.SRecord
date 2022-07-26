#### [Jcd.SRecord](index.md 'index')

## Jcd.SRecord Namespace

| Classes | |
| :--- | :--- |
| [SRecordData](Jcd.SRecord.SRecordData.md 'Jcd.SRecord.SRecordData') | Represents a single `SRecordData` entry in an s-record file. This is an immutable type.<br/>To edit the contents, create a new one with the altered data buffer, address, and/or type. |
| [SRecordDataFormatter](Jcd.SRecord.SRecordDataFormatter.md 'Jcd.SRecord.SRecordDataFormatter') | Encapsulates the formatting logic required to emit a single SRecordData<br/>with consistent hex value casing. |
| [SRecordDataParser](Jcd.SRecord.SRecordDataParser.md 'Jcd.SRecord.SRecordDataParser') | Provides facilities for parsing the textual SRecordData format into its<br/>binary representation. |
| [SRecordDataStatistics](Jcd.SRecord.SRecordDataStatistics.md 'Jcd.SRecord.SRecordDataStatistics') | Represents summary information about the contents of<br/>an any collection of SRecordData. |
| [SRecordDataType.Flexible](Jcd.SRecord.SRecordDataType.Flexible.md 'Jcd.SRecord.SRecordDataType.Flexible') | Provides a collection and lookup mechanism for instances of [SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')<br/>configured to accept a flexible number of data bytes per record. The exact amount<br/>allowed varies per type and is 254 bytes minus the address length in bytes, for S0,<br/>S1, S2, S3, and S4. NOTE: S4 types always require special, implementation defined, handling. |
| [SRecordDataType.Strict](Jcd.SRecord.SRecordDataType.Strict.md 'Jcd.SRecord.SRecordDataType.Strict') | Provides a collection and lookup mechanism for instances of [SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')<br/>configured to accept a maximum of 32 data bytes per record for S0, S1, S2, S3, and S4<br/>record types. NOTE: S4 types always require special, implementation defined, handling. |
| [SRecordDocument](Jcd.SRecord.SRecordDocument.md 'Jcd.SRecord.SRecordDocument') | Represents an SRecordData document. This is a simple document reader/writer.<br/>No S37, or other semantics are enforced. |
| [SRecordElement](Jcd.SRecord.SRecordElement.md 'Jcd.SRecord.SRecordElement') | Represents a single line in an `SRecordDocument` |
| [SRecordElementFormattedEventArgs](Jcd.SRecord.SRecordElementFormattedEventArgs.md 'Jcd.SRecord.SRecordElementFormattedEventArgs') | [System.EventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.EventArgs 'System.EventArgs') is the base class for classes containing event data. |
| [SRecordElementFormatter](Jcd.SRecord.SRecordElementFormatter.md 'Jcd.SRecord.SRecordElementFormatter') | Encapsulates the logic necessary to format an `SRecordElement`<br/>as a line of text. |
| [SRecordElementFormattingEventArgs](Jcd.SRecord.SRecordElementFormattingEventArgs.md 'Jcd.SRecord.SRecordElementFormattingEventArgs') | [System.EventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.EventArgs 'System.EventArgs') is the base class for classes containing event data. |
| [SRecordElementParsedEventArgs](Jcd.SRecord.SRecordElementParsedEventArgs.md 'Jcd.SRecord.SRecordElementParsedEventArgs') | [System.EventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.EventArgs 'System.EventArgs') is the base class for classes containing event data. |
| [SRecordElementParser](Jcd.SRecord.SRecordElementParser.md 'Jcd.SRecord.SRecordElementParser') | Provides a default mechanism for parsing a line of text into<br/>an `SRecordElement`. |
| [SRecordElementParsingEventArgs](Jcd.SRecord.SRecordElementParsingEventArgs.md 'Jcd.SRecord.SRecordElementParsingEventArgs') | [System.EventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.EventArgs 'System.EventArgs') is the base class for classes containing event data. |
| [SRecordElementReader](Jcd.SRecord.SRecordElementReader.md 'Jcd.SRecord.SRecordElementReader') | A forward only `SRecordElement` stream/string reader.<br/>This class always disposes its TextReader when disposed. |
| [SRecordElementStatistics](Jcd.SRecord.SRecordElementStatistics.md 'Jcd.SRecord.SRecordElementStatistics') | Represents a set of statistics about a set of `SRecordElement` instances. |
| [SRecordElementWriter](Jcd.SRecord.SRecordElementWriter.md 'Jcd.SRecord.SRecordElementWriter') | Writes `SRecordElement`s to a stream or `TextWriter`. |

| Structs | |
| :--- | :--- |
| [SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType') | Represents the information required to identify and process various types of SRecords<br/>[
            as documented here
            ](https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html 'https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html') |
| [SRecordElementFormatter.Options](Jcd.SRecord.SRecordElementFormatter.Options.md 'Jcd.SRecord.SRecordElementFormatter.Options') | Represents the formatting options desired when writing `SRecordElement` contents<br/>to an `SRecordElementWriter`. |
| [SRecordElementType](Jcd.SRecord.SRecordElementType.md 'Jcd.SRecord.SRecordElementType') | Defines a set of flags that describe the results of parsing a line<br/>of text from an `SRecordDocument` |

| Interfaces | |
| :--- | :--- |
| [ISRecordDataFormatter](Jcd.SRecord.ISRecordDataFormatter.md 'Jcd.SRecord.ISRecordDataFormatter') | Defines the operations necessary to support formatting an `SRecordData`<br/>into text. |
| [ISRecordDataParser](Jcd.SRecord.ISRecordDataParser.md 'Jcd.SRecord.ISRecordDataParser') | Defines the operations necessary in order to support parsing text into<br/>`SRecordData` instances. |
| [ISRecordElementFormatter](Jcd.SRecord.ISRecordElementFormatter.md 'Jcd.SRecord.ISRecordElementFormatter') | Defines the operations necessary to support formatting<br/>`SRecordElement`s to lines of text. |
| [ISRecordElementParser](Jcd.SRecord.ISRecordElementParser.md 'Jcd.SRecord.ISRecordElementParser') | Defines the operations necessary to parse `SRecordElement`s<br/>from text. |
