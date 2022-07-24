#### [Jcd.SRecord](index.md 'index')

## Jcd.SRecord Namespace

| Classes | |
| :--- | :--- |
| [SRecord](Jcd.SRecord.SRecord.md 'Jcd.SRecord.SRecord') | Represents a single SRecord entry in an srecord file. This is an immutable type. To edit the contents, create a new one with the altered data buffer, address, and/or type. |
| [SRecordFormatter](Jcd.SRecord.SRecordFormatter.md 'Jcd.SRecord.SRecordFormatter') | Encapsulates the formatting logic required to emit a single SRecord<br/>with consistent hex value casing. |
| [SRecordParser](Jcd.SRecord.SRecordParser.md 'Jcd.SRecord.SRecordParser') | Provides facilities for parsing the textual SRecord format into its<br/>binary representation. |
| [SRecordType.Flexible](Jcd.SRecord.SRecordType.Flexible.md 'Jcd.SRecord.SRecordType.Flexible') | Provides a collection and lookup mechanism for instances of [SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')<br/>configured to accept a flexible number of data bytes per record. The exact amount<br/>allowed varies per type and is 254 bytes minus the address length in bytes, for S0,<br/>S1, S2, S3, and S4. NOTE: S4 types always require special, implementation defined, handling. |
| [SRecordType.Strict](Jcd.SRecord.SRecordType.Strict.md 'Jcd.SRecord.SRecordType.Strict') | Provides a collection and lookup mechanism for instances of [SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')<br/>configured to accept a maximum of 32 data bytes per record for S0, S1, S2, S3, and S4<br/>record types. NOTE: S4 types always require special, implementation defined, handling. |

| Structs | |
| :--- | :--- |
| [SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType') | Represents the information required to identify and process various types of SRecords<br/>[
            as documented here
            ](https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html 'https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html') |

| Interfaces | |
| :--- | :--- |
| [ISRecordFormatter](Jcd.SRecord.ISRecordFormatter.md 'Jcd.SRecord.ISRecordFormatter') | Defines the operations necessary to support formatting an `SRecord`<br/>into text. |
| [ISRecordParser](Jcd.SRecord.ISRecordParser.md 'Jcd.SRecord.ISRecordParser') | Defines the operations necessary in order to support parsing text into<br/>`SRecord` instances. |
