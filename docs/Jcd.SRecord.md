#### [Jcd.SRecord](index.md 'index')

## Jcd.SRecord Namespace

Provides support for reading and writing [s-record](https://en.wikipedia.org/wiki/SREC_(file_format) 'https://en.wikipedia.org/wiki/SREC_(file_format)') files.

| Classes | |
| :--- | :--- |
| [SRecordData](Jcd.SRecord.SRecordData.md 'Jcd.SRecord.SRecordData') | Represents a single `SRecordData` entry in an s-record file. This is an immutable type.<br/>To edit the contents, create a new one with the altered data buffer, address, and/or type. |
| [SRecordDataFormatter](Jcd.SRecord.SRecordDataFormatter.md 'Jcd.SRecord.SRecordDataFormatter') | Implements the formatting logic required to emit a single SRecordData with consistent hex value casing. |
| [SRecordDataParser](Jcd.SRecord.SRecordDataParser.md 'Jcd.SRecord.SRecordDataParser') | Implements parsing of the textual SRecordData format into its binary representation. |
| [SRecordDataStatistics](Jcd.SRecord.SRecordDataStatistics.md 'Jcd.SRecord.SRecordDataStatistics') | Represents summary information about the contents of an any collection of SRecordData. |
| [SRecordDataType.Flexible](Jcd.SRecord.SRecordDataType.Flexible.md 'Jcd.SRecord.SRecordDataType.Flexible') | Provides a collection and lookup mechanism for instances of [SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType') configured to accept a flexible number of data bytes per record. The exact amount allowed varies per type and is 254 bytes minus the address length in bytes, for S0, S1, S2, S3, and S4. NOTE: S4 types always require special, implementation defined, handling. |
| [SRecordDataType.Strict](Jcd.SRecord.SRecordDataType.Strict.md 'Jcd.SRecord.SRecordDataType.Strict') | Provides a collection and lookup mechanism for instances of [SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType') configured to accept a maximum of 32 data bytes per record for S0, S1, S2, S3, and S4 record types. NOTE: S4 types always require special, implementation defined, handling. |
| [SRecordDocument](Jcd.SRecord.SRecordDocument.md 'Jcd.SRecord.SRecordDocument') | Represents an SRecordData document that contains all the records that were read. |
| [SRecordElement](Jcd.SRecord.SRecordElement.md 'Jcd.SRecord.SRecordElement') | Represents a single line in an `SRecordDocument`. |
| [SRecordElementFormattedEventArgs](Jcd.SRecord.SRecordElementFormattedEventArgs.md 'Jcd.SRecord.SRecordElementFormattedEventArgs') | Provides context for the SRecordElementFormatter.Formatted event. |
| [SRecordElementFormatter](Jcd.SRecord.SRecordElementFormatter.md 'Jcd.SRecord.SRecordElementFormatter') | Encapsulates the logic necessary to format an `SRecordElement` as a line of text. |
| [SRecordElementFormattingEventArgs](Jcd.SRecord.SRecordElementFormattingEventArgs.md 'Jcd.SRecord.SRecordElementFormattingEventArgs') | Provides context for the SRecordElementFormatter.Formatting event. |
| [SRecordElementParsedEventArgs](Jcd.SRecord.SRecordElementParsedEventArgs.md 'Jcd.SRecord.SRecordElementParsedEventArgs') | Provides context for the SRecordElementParser.Parsed event. |
| [SRecordElementParser](Jcd.SRecord.SRecordElementParser.md 'Jcd.SRecord.SRecordElementParser') | Provides a default mechanism for parsing a line of text into an `SRecordElement`. |
| [SRecordElementParsingEventArgs](Jcd.SRecord.SRecordElementParsingEventArgs.md 'Jcd.SRecord.SRecordElementParsingEventArgs') | Provides context for the SRecordElementParser.Parsing event. |
| [SRecordElementReader](Jcd.SRecord.SRecordElementReader.md 'Jcd.SRecord.SRecordElementReader') | A forward only `SRecordElement` stream/string reader.<br/>This class always disposes its TextReader when disposed. |
| [SRecordElementStatistics](Jcd.SRecord.SRecordElementStatistics.md 'Jcd.SRecord.SRecordElementStatistics') | Represents a set of statistics about a set of `SRecordElement` instances. |
| [SRecordElementWriter](Jcd.SRecord.SRecordElementWriter.md 'Jcd.SRecord.SRecordElementWriter') | Provides the logic necessary to write `SRecordElement`s to a `Stream` or `TextWriter`. |

| Structs | |
| :--- | :--- |
| [SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType') | Represents the information required to identify and process various types of SRecords [as documented here](https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html 'https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html') |
| [SRecordElementFormatter.Options](Jcd.SRecord.SRecordElementFormatter.Options.md 'Jcd.SRecord.SRecordElementFormatter.Options') | Represents the formatting options desired when writing `SRecordElement` contents<br/>to an `SRecordElementWriter`. |
| [SRecordElementType](Jcd.SRecord.SRecordElementType.md 'Jcd.SRecord.SRecordElementType') | Defines a set of flags that describe the results of parsing a line of text from an `SRecordDocument` |

| Interfaces | |
| :--- | :--- |
| [ISRecordDataFormatter](Jcd.SRecord.ISRecordDataFormatter.md 'Jcd.SRecord.ISRecordDataFormatter') | Defines the operations necessary to support formatting an `SRecordData` into text. |
| [ISRecordDataParser](Jcd.SRecord.ISRecordDataParser.md 'Jcd.SRecord.ISRecordDataParser') | Defines the operations necessary in order to support parsing text into `SRecordData` instances. |
| [ISRecordElementFormatter](Jcd.SRecord.ISRecordElementFormatter.md 'Jcd.SRecord.ISRecordElementFormatter') | Defines the operations necessary to support formatting `SRecordElement`s to lines of text. |
| [ISRecordElementParser](Jcd.SRecord.ISRecordElementParser.md 'Jcd.SRecord.ISRecordElementParser') | Defines the operations necessary to parse `SRecordElement`s from text. |
