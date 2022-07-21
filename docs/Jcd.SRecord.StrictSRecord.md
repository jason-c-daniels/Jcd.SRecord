### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## StrictSRecord Class

Provides a collection and lookup mechanism for instances of [SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')  
configured to accept a maximum of 32 data bytes per record for S0, S1, S2, S3, and S4  
record types. NOTE: S4 types always require special, implementation defined, handling.

```csharp
public static class StrictSRecord
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; StrictSRecord

| Fields | |
| :--- | :--- |
| [S0](Jcd.SRecord.StrictSRecord.S0.md 'Jcd.SRecord.StrictSRecord.S0') | The identifier for S0 records. Address is 2 bytes, should always be 0. Maximum data bytes allowed 32 bytes. |
| [S1](Jcd.SRecord.StrictSRecord.S1.md 'Jcd.SRecord.StrictSRecord.S1') | The identifier for S1 records. Address is 2 bytes. Maximum data bytes allowed 32 bytes.<br/>This record contains data that starts at the 16-bit address field. |
| [S2](Jcd.SRecord.StrictSRecord.S2.md 'Jcd.SRecord.StrictSRecord.S2') | The identifier for S2 records. Address is 3 bytes. Maximum data bytes allowed 32 bytes.<br/>This record contains data that starts at a 24-bit address. |
| [S3](Jcd.SRecord.StrictSRecord.S3.md 'Jcd.SRecord.StrictSRecord.S3') | The identifier for S3 records. Address is 4 bytes. Maximum data bytes allowed 32 bytes.<br/>This record contains data that starts at a 32-bit address. |
| [S4](Jcd.SRecord.StrictSRecord.S4.md 'Jcd.SRecord.StrictSRecord.S4') | The identifier for S4 records. Address is 4 bytes. Maximum data bytes allowed 32 bytes.<br/>Special handling required. This is vendor defined/reserved. |
| [S5](Jcd.SRecord.StrictSRecord.S5.md 'Jcd.SRecord.StrictSRecord.S5') | The identifier for S5 records. Address is 2 bytes. No data allowed.<br/>This contains a 16-bit count of all S1, S2, or S3 records.<br/>This record is used if the record count is less than or equal to 0xFFFF. |
| [S6](Jcd.SRecord.StrictSRecord.S6.md 'Jcd.SRecord.StrictSRecord.S6') | The identifier for S6 records. Address is 3 bytes. No data allowed.<br/>This contains a 24-bit count of all S1, S2, or S3 records.<br/>This record is used if the record count is less than or equal to 16,777,215 (0xFFFFFF) and <br/>greater than 65,535 (0xFFFF) records. |
| [S7](Jcd.SRecord.StrictSRecord.S7.md 'Jcd.SRecord.StrictSRecord.S7') | The identifier for S7 records. Address is 4 bytes. Maximum data bytes allowed 32 bytes.<br/>This is used to terminate a series of S3 records. If a SRecord file is only used to program<br/>a memory device and the execution location is ignored, then an address of zero could be<br/>used. |
| [S8](Jcd.SRecord.StrictSRecord.S8.md 'Jcd.SRecord.StrictSRecord.S8') | The identifier for S8 records. Address is 3 bytes. Maximum data bytes allowed 32 bytes.<br/>This is used to terminate a series of S2 records. If a SRecord file is only used to program<br/>a memory device and the execution location is ignored, then an address of zero could be used. |
| [S9](Jcd.SRecord.StrictSRecord.S9.md 'Jcd.SRecord.StrictSRecord.S9') | The identifier for S8 records. Address is 3 bytes. Maximum data bytes allowed 32 bytes. |
| [TypeLookup](Jcd.SRecord.StrictSRecord.TypeLookup.md 'Jcd.SRecord.StrictSRecord.TypeLookup') | A key-based lookup for known Strict (32 byte data max) `SRecordType` instances. |

| Methods | |
| :--- | :--- |
| [FromKey(string)](Jcd.SRecord.StrictSRecord.FromKey(string).md 'Jcd.SRecord.StrictSRecord.FromKey(string)') | Given a key, return an SRecordType instance describing it.<br/>Invalid keys will return |
