#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## SRecordFormatter Class

Encapsulates the formatting logic required to emit a single SRecord  
with consistent hex value casing.

```csharp
public class SRecordFormatter
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordFormatter

| Fields | |
| :--- | :--- |
| [LowercaseHex](Jcd.SRecord.SRecordFormatter.LowercaseHex.md 'Jcd.SRecord.SRecordFormatter.LowercaseHex') | An instance preconfigured to emit lowercase hex values. |
| [UppercaseHex](Jcd.SRecord.SRecordFormatter.UppercaseHex.md 'Jcd.SRecord.SRecordFormatter.UppercaseHex') | And instance preconfigured to emit uppercase hex values. |

| Properties | |
| :--- | :--- |
| [Default](Jcd.SRecord.SRecordFormatter.Default.md 'Jcd.SRecord.SRecordFormatter.Default') | The default (uppercase) method of emitting an SRecord. |
| [EmitHexNumbersInUpperCase](Jcd.SRecord.SRecordFormatter.EmitHexNumbersInUpperCase.md 'Jcd.SRecord.SRecordFormatter.EmitHexNumbersInUpperCase') | Indicates if the hex numbers should be uppercase (true) or lowercase (false) |

| Methods | |
| :--- | :--- |
| [Format(SRecord)](Jcd.SRecord.SRecordFormatter.Format(Jcd.SRecord.SRecord).md 'Jcd.SRecord.SRecordFormatter.Format(Jcd.SRecord.SRecord)') | Converts an SRecord into its ASCII-HEX representation. |
