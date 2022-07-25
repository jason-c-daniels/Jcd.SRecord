#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## SRecordDataFormatter Class

Encapsulates the formatting logic required to emit a single SRecordData  
with consistent hex value casing.

```csharp
public class SRecordDataFormatter :
Jcd.SRecord.ISRecordDataFormatter
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordDataFormatter

Implements [ISRecordDataFormatter](Jcd.SRecord.ISRecordDataFormatter.md 'Jcd.SRecord.ISRecordDataFormatter')

| Fields | |
| :--- | :--- |
| [LowercaseHex](Jcd.SRecord.SRecordDataFormatter.LowercaseHex.md 'Jcd.SRecord.SRecordDataFormatter.LowercaseHex') | An instance preconfigured to emit lowercase hex values. |
| [UppercaseHex](Jcd.SRecord.SRecordDataFormatter.UppercaseHex.md 'Jcd.SRecord.SRecordDataFormatter.UppercaseHex') | And instance preconfigured to emit uppercase hex values. |

| Properties | |
| :--- | :--- |
| [Default](Jcd.SRecord.SRecordDataFormatter.Default.md 'Jcd.SRecord.SRecordDataFormatter.Default') | The default (uppercase) method of emitting an SRecordData. |
| [EmitHexNumbersInUpperCase](Jcd.SRecord.SRecordDataFormatter.EmitHexNumbersInUpperCase.md 'Jcd.SRecord.SRecordDataFormatter.EmitHexNumbersInUpperCase') | Indicates if the hex numbers should be uppercase (true) or lowercase (false) |

| Methods | |
| :--- | :--- |
| [Format(SRecordData)](Jcd.SRecord.SRecordDataFormatter.Format(Jcd.SRecord.SRecordData).md 'Jcd.SRecord.SRecordDataFormatter.Format(Jcd.SRecord.SRecordData)') | Converts an SRecordData into its ASCII-HEX representation. |
