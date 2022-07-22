## Jcd.SRecord Namespace

| Classes | |
| :--- | :--- |
| [HexStringConversions](Jcd.SRecord.HexStringConversions.md 'Jcd.SRecord.HexStringConversions') | A set of extension methods to help in converting<br/>to and from hexadecimal representations of bytes |
| [SRecord](Jcd.SRecord.SRecord.md 'Jcd.SRecord.SRecord') | Represents a single SRecord entry in an srec file. |
| [SRecordFormatter](Jcd.SRecord.SRecordFormatter.md 'Jcd.SRecord.SRecordFormatter') | Encapsulates the formatting logic required to emit a single SRecord<br/>with consistent hex value casing. |
| [SRecordParser](Jcd.SRecord.SRecordParser.md 'Jcd.SRecord.SRecordParser') | Provides facilities for parsing the textual SRecord format into its<br/>binary representation. |
| [SRecordType.Flexible](Jcd.SRecord.SRecordType.Flexible.md 'Jcd.SRecord.SRecordType.Flexible') | Provides a collection and lookup mechanism for instances of [SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')<br/>configured to accept a flexible number of data bytes per record. The exact amount<br/>allowed varies per type and is 254 bytes minus the address length in bytes, for S0,<br/>S1, S2, S3, and S4. NOTE: S4 types always require special, implementation defined, handling. |
| [SRecordType.Strict](Jcd.SRecord.SRecordType.Strict.md 'Jcd.SRecord.SRecordType.Strict') | Provides a collection and lookup mechanism for instances of [SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')<br/>configured to accept a maximum of 32 data bytes per record for S0, S1, S2, S3, and S4<br/>record types. NOTE: S4 types always require special, implementation defined, handling. |

| Structs | |
| :--- | :--- |
| [SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType') | Represents the information required to identify and process various types of SRecords<br/>[
            as documented here
            ](https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html 'https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html') |
