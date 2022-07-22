### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')

## SRecordType.Flexible Class

Provides a collection and lookup mechanism for instances of [SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')  
configured to accept a flexible number of data bytes per record. The exact amount  
allowed varies per type and is 254 bytes minus the address length in bytes, for S0,  
S1, S2, S3, and S4. NOTE: S4 types always require special, implementation defined, handling.

```csharp
public static class SRecordType.Flexible
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Flexible

| Fields | |
| :--- | :--- |
| [S0](Jcd.SRecord.SRecordType.Flexible.S0.md 'Jcd.SRecord.SRecordType.Flexible.S0') | The identifier for S0 records. Address is 2 bytes, should always be 0. |
| [S1](Jcd.SRecord.SRecordType.Flexible.S1.md 'Jcd.SRecord.SRecordType.Flexible.S1') | The identifier for S1 records. Address is 2 bytes. <br/>This record contains data that starts at the 16-bit address field. |
| [S2](Jcd.SRecord.SRecordType.Flexible.S2.md 'Jcd.SRecord.SRecordType.Flexible.S2') | The identifier for S2 records. Address is 3 bytes. Maximum data bytes allowed 32 bytes.<br/>This record contains data that starts at a 24-bit address. |
| [S3](Jcd.SRecord.SRecordType.Flexible.S3.md 'Jcd.SRecord.SRecordType.Flexible.S3') | The identifier for S3 records. Address is 4 bytes. Maximum data bytes allowed 32 bytes.<br/>This record contains data that starts at a 32-bit address. |
| [S4](Jcd.SRecord.SRecordType.Flexible.S4.md 'Jcd.SRecord.SRecordType.Flexible.S4') | The identifier for S4 records. Address is 4 bytes. Maximum data bytes allowed 32 bytes.<br/>Special handling required. This is vendor defined/reserved. |
| [S5](Jcd.SRecord.SRecordType.Flexible.S5.md 'Jcd.SRecord.SRecordType.Flexible.S5') | The identifier for S5 records. Address is 2 bytes. No data allowed.<br/>This contains a 16-bit count of all S1, S2, or S3 records.<br/>This record is used if the record count is less than or equal to 0xFFFF. |
| [S6](Jcd.SRecord.SRecordType.Flexible.S6.md 'Jcd.SRecord.SRecordType.Flexible.S6') | The identifier for S6 records. Address is 3 bytes. No data allowed.<br/>This contains a 24-bit count of all S1, S2, or S3 records.<br/>This record is used if the record count is less than or equal to 16,777,215 (0xFFFFFF) and <br/>greater than 65,535 (0xFFFF) records. |
| [S7](Jcd.SRecord.SRecordType.Flexible.S7.md 'Jcd.SRecord.SRecordType.Flexible.S7') | The identifier for S7 records. Address is 4 bytes. <br/>This is used to terminate a series of S3 records. If a SRecord file is only used to program<br/>a memory device and the execution location is ignored, then an address of zero could be<br/>used. |
| [S8](Jcd.SRecord.SRecordType.Flexible.S8.md 'Jcd.SRecord.SRecordType.Flexible.S8') | The identifier for S8 records. Address is 3 bytes. <br/>This is used to terminate a series of S2 records. If a SRecord file is only used to program<br/>a memory device and the execution location is ignored, then an address of zero could be used. |
| [S9](Jcd.SRecord.SRecordType.Flexible.S9.md 'Jcd.SRecord.SRecordType.Flexible.S9') | The identifier for S8 records. Address is 3 bytes. |
| [TypeLookup](Jcd.SRecord.SRecordType.Flexible.TypeLookup.md 'Jcd.SRecord.SRecordType.Flexible.TypeLookup') | A key-based lookup for known Strict `SRecordType` instances. |

| Methods | |
| :--- | :--- |
| [FromKey(string)](Jcd.SRecord.SRecordType.Flexible.FromKey(string).md 'Jcd.SRecord.SRecordType.Flexible.FromKey(string)') | Given a key, return an SRecordType instance describing it.<br/>Invalid keys will return |
