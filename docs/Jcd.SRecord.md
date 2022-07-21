## Jcd.SRecord Namespace

| Classes | |
| :--- | :--- |
| [FlexibleSRecord](Jcd.SRecord.FlexibleSRecord.md 'Jcd.SRecord.FlexibleSRecord') | Provides a collection and lookup mechanism for instances of [SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')<br/>configured to accept a flexible number of data bytes per record. The exact amount<br/>allowed varies per type and is 254 bytes minus the address length in bytes, for S0,<br/>S1, S2, S3, and S4. NOTE: S4 types always require special, implementation defined, handling. |
| [SRecord](Jcd.SRecord.SRecord.md 'Jcd.SRecord.SRecord') | Represents a single SRecord entry in an srec file. |
| [SRecordFormatter](Jcd.SRecord.SRecordFormatter.md 'Jcd.SRecord.SRecordFormatter') | Encapsulates the formatting logic required to emit a single SRecord<br/>with consistent hex value casing. |
| [SRecordParser](Jcd.SRecord.SRecordParser.md 'Jcd.SRecord.SRecordParser') | Provides facilities for parsing the textual SRecord format into its<br/>binary representation. |
| [StrictSRecord](Jcd.SRecord.StrictSRecord.md 'Jcd.SRecord.StrictSRecord') | Provides a collection and lookup mechanism for instances of [SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')<br/>configured to accept a maximum of 32 data bytes per record for S0, S1, S2, S3, and S4<br/>record types. NOTE: S4 types always require special, implementation defined, handling. |

| Structs | |
| :--- | :--- |
| [SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType') | Represents the information required to identify and process various types of SRecords<br/>[
            as documented here
            ](https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html 'https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html') |
