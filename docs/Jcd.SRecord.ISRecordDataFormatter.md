#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## ISRecordDataFormatter Interface

Defines the operations necessary to support formatting an `SRecordData` into text.

```csharp
public interface ISRecordDataFormatter
```

Derived  
&#8627; [SRecordDataFormatter](Jcd.SRecord.SRecordDataFormatter.md 'Jcd.SRecord.SRecordDataFormatter')

| Properties | |
| :--- | :--- |
| [EmitHexNumbersInUpperCase](Jcd.SRecord.ISRecordDataFormatter.EmitHexNumbersInUpperCase.md 'Jcd.SRecord.ISRecordDataFormatter.EmitHexNumbersInUpperCase') | Indicates if the hex numbers should be uppercase (true) or lowercase (false). |

| Methods | |
| :--- | :--- |
| [Format(SRecordData)](Jcd.SRecord.ISRecordDataFormatter.Format(Jcd.SRecord.SRecordData).md 'Jcd.SRecord.ISRecordDataFormatter.Format(Jcd.SRecord.SRecordData)') | Converts an SRecordData into its ASCII-HEX representation. |
