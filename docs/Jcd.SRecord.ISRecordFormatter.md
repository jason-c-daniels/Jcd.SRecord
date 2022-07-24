#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## ISRecordFormatter Interface

Defines the operations necessary to support formatting an `SRecord`  
into text.

```csharp
public interface ISRecordFormatter
```

Derived  
&#8627; [SRecordFormatter](Jcd.SRecord.SRecordFormatter.md 'Jcd.SRecord.SRecordFormatter')

| Properties | |
| :--- | :--- |
| [EmitHexNumbersInUpperCase](Jcd.SRecord.ISRecordFormatter.EmitHexNumbersInUpperCase.md 'Jcd.SRecord.ISRecordFormatter.EmitHexNumbersInUpperCase') | Indicates if the hex numbers should be uppercase (true)<br/>or lowercase (false). |

| Methods | |
| :--- | :--- |
| [Format(SRecord)](Jcd.SRecord.ISRecordFormatter.Format(Jcd.SRecord.SRecord).md 'Jcd.SRecord.ISRecordFormatter.Format(Jcd.SRecord.SRecord)') | Converts an SRecord into its ASCII-HEX representation. |
