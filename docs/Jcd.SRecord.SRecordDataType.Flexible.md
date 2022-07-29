#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')

## SRecordDataType.Flexible Class

Provides a collection and lookup mechanism for instances of [SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType') configured to accept a flexible number of data bytes per record. The exact amount allowed varies per type and is 254 bytes minus the address length in bytes, for S0, S1, S2, S3, and S4. NOTE: S4 types always require special, implementation defined, handling.

```csharp
public static class SRecordDataType.Flexible
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Flexible

| Fields | |
| :--- | :--- |
| [S0](Jcd.SRecord.SRecordDataType.Flexible.S0.md 'Jcd.SRecord.SRecordDataType.Flexible.S0') | The identifier for S0 records. Address is 2 bytes, should always be 0. Maximum data bytes allowed 252 bytes. |
| [S1](Jcd.SRecord.SRecordDataType.Flexible.S1.md 'Jcd.SRecord.SRecordDataType.Flexible.S1') | The identifier for S1 records. Address is 2 bytes. Maximum data bytes allowed 252 bytes. |
| [S2](Jcd.SRecord.SRecordDataType.Flexible.S2.md 'Jcd.SRecord.SRecordDataType.Flexible.S2') | The identifier for S2 records. Address is 3 bytes. Maximum data bytes allowed 251 bytes. |
| [S3](Jcd.SRecord.SRecordDataType.Flexible.S3.md 'Jcd.SRecord.SRecordDataType.Flexible.S3') | The identifier for S3 records. Address is 4 bytes. Maximum data bytes allowed 250 bytes. |
| [S4](Jcd.SRecord.SRecordDataType.Flexible.S4.md 'Jcd.SRecord.SRecordDataType.Flexible.S4') | The identifier for S4 records. Address is 4 bytes. Maximum data bytes allowed 250 bytes. |
| [S5](Jcd.SRecord.SRecordDataType.Flexible.S5.md 'Jcd.SRecord.SRecordDataType.Flexible.S5') | The identifier for S5 records. Address is 2 bytes. No data allowed. |
| [S6](Jcd.SRecord.SRecordDataType.Flexible.S6.md 'Jcd.SRecord.SRecordDataType.Flexible.S6') | The identifier for S6 records. Address is 3 bytes. No data allowed. |
| [S7](Jcd.SRecord.SRecordDataType.Flexible.S7.md 'Jcd.SRecord.SRecordDataType.Flexible.S7') | The identifier for S7 records. Address is 4 bytes.  No data allowed.<br/>This is used to terminate a series of S3 records. |
| [S8](Jcd.SRecord.SRecordDataType.Flexible.S8.md 'Jcd.SRecord.SRecordDataType.Flexible.S8') | The identifier for S8 records. Address is 3 bytes. No data allowed.<br/>This is used to terminate a series of S2 records. |
| [S9](Jcd.SRecord.SRecordDataType.Flexible.S9.md 'Jcd.SRecord.SRecordDataType.Flexible.S9') | The identifier for S8 records. Address is 3 bytes. Maximum data bytes allowed 32 bytes. |
| [TypeLookup](Jcd.SRecord.SRecordDataType.Flexible.TypeLookup.md 'Jcd.SRecord.SRecordDataType.Flexible.TypeLookup') | A key-based lookup for known Flexible (250-252 byte data max depending on record type) `SRecordDataType` instances. |

| Methods | |
| :--- | :--- |
| [FromKey(string)](Jcd.SRecord.SRecordDataType.Flexible.FromKey(string).md 'Jcd.SRecord.SRecordDataType.Flexible.FromKey(string)') | Given a key, return an SRecordDataType instance describing it.<br/>Invalid keys will return an instance with IsValid of false. |
