#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO')

## ISRecordElementFormatter Interface

Defines the operations necessary to support formatting  
`SRecordElement`s to lines of text.

```csharp
public interface ISRecordElementFormatter
```

Derived  
&#8627; [SRecordElementFormatter](Jcd.SRecord.IO.SRecordElementFormatter.md 'Jcd.SRecord.IO.SRecordElementFormatter')

| Methods | |
| :--- | :--- |
| [Format(SRecordElement)](Jcd.SRecord.IO.ISRecordElementFormatter.Format(Jcd.SRecord.IO.SRecordElement).md 'Jcd.SRecord.IO.ISRecordElementFormatter.Format(Jcd.SRecord.IO.SRecordElement)') | Formats an `SRecordElement` as a element of text. |

| Events | |
| :--- | :--- |
| [Formatted](Jcd.SRecord.IO.ISRecordElementFormatter.Formatted.md 'Jcd.SRecord.IO.ISRecordElementFormatter.Formatted') | An event that indicates formatting has finished. |
| [Formatting](Jcd.SRecord.IO.ISRecordElementFormatter.Formatting.md 'Jcd.SRecord.IO.ISRecordElementFormatter.Formatting') | An event indicating that formatting has begun. |
