### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')

## SRecordType.Strict Class

Provides a collection and lookup mechanism for instances of [SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')  
configured to accept a maximum of 32 data bytes per record for S0, S1, S2, S3, and S4  
record types. NOTE: S4 types always require special, implementation defined, handling.

```csharp
public static class SRecordType.Strict
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Strict

| Fields | |
| :--- | :--- |
| [MaxDataLength](Jcd.SRecord.SRecordType.Strict.MaxDataLength.md 'Jcd.SRecord.SRecordType.Strict.MaxDataLength') | The maximum data any data bearing record may have |
| [S0](Jcd.SRecord.SRecordType.Strict.S0.md 'Jcd.SRecord.SRecordType.Strict.S0') | The identifier for S0 records. Address is 2 bytes, should always be 0. Maximum data bytes allowed 32 bytes. |
| [S1](Jcd.SRecord.SRecordType.Strict.S1.md 'Jcd.SRecord.SRecordType.Strict.S1') | The identifier for S1 records. Address is 2 bytes. Maximum data bytes allowed 32 bytes.<br/>This record contains data that starts at the 16-bit address field. |
| [S2](Jcd.SRecord.SRecordType.Strict.S2.md 'Jcd.SRecord.SRecordType.Strict.S2') | The identifier for S2 records. Address is 3 bytes. Maximum data bytes allowed 32 bytes.<br/>This record contains data that starts at a 24-bit address. |
| [S3](Jcd.SRecord.SRecordType.Strict.S3.md 'Jcd.SRecord.SRecordType.Strict.S3') | The identifier for S3 records. Address is 4 bytes. Maximum data bytes allowed 32 bytes.<br/>This record contains data that starts at a 32-bit address. |
| [S4](Jcd.SRecord.SRecordType.Strict.S4.md 'Jcd.SRecord.SRecordType.Strict.S4') | The identifier for S4 records. Address is 4 bytes. Maximum data bytes allowed 32 bytes.<br/>Special handling required. This is vendor defined/reserved. |
| [S5](Jcd.SRecord.SRecordType.Strict.S5.md 'Jcd.SRecord.SRecordType.Strict.S5') | The identifier for S5 records. Address is 2 bytes. No data allowed.<br/>This contains a 16-bit count of all S1, S2, or S3 records.<br/>This record is used if the record count is less than or equal to 0xFFFF. |
| [S6](Jcd.SRecord.SRecordType.Strict.S6.md 'Jcd.SRecord.SRecordType.Strict.S6') | The identifier for S6 records. Address is 3 bytes. No data allowed.<br/>This contains a 24-bit count of all S1, S2, or S3 records.<br/>This record is used if the record count is less than or equal to 16,777,215 (0xFFFFFF) and <br/>greater than 65,535 (0xFFFF) records. |
| [S7](Jcd.SRecord.SRecordType.Strict.S7.md 'Jcd.SRecord.SRecordType.Strict.S7') | The identifier for S7 records. Address is 4 bytes. Maximum data bytes allowed 32 bytes.<br/>This is used to terminate a series of S3 records. If a SRecord file is only used to program<br/>a memory device and the execution location is ignored, then an address of zero could be<br/>used. |
| [S8](Jcd.SRecord.SRecordType.Strict.S8.md 'Jcd.SRecord.SRecordType.Strict.S8') | The identifier for S8 records. Address is 3 bytes. Maximum data bytes allowed 32 bytes.<br/>This is used to terminate a series of S2 records. If a SRecord file is only used to program<br/>a memory device and the execution location is ignored, then an address of zero could be used. |
| [S9](Jcd.SRecord.SRecordType.Strict.S9.md 'Jcd.SRecord.SRecordType.Strict.S9') | The identifier for S8 records. Address is 3 bytes. Maximum data bytes allowed 32 bytes. |
| [TypeLookup](Jcd.SRecord.SRecordType.Strict.TypeLookup.md 'Jcd.SRecord.SRecordType.Strict.TypeLookup') | A key-based lookup for known Strict (32 byte data max) `SRecordType` instances. |

| Methods | |
| :--- | :--- |
| [FromKey(string)](Jcd.SRecord.SRecordType.Strict.FromKey(string).md 'Jcd.SRecord.SRecordType.Strict.FromKey(string)') | Given a key, return an SRecordType instance describing it.<br/>Invalid keys will return |
