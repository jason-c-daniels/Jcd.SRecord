#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO')

## SRecordElementFormatter Class

Encapsulates the logic necessary to format an `SRecordElement`  
as a line of text.

```csharp
public class SRecordElementFormatter :
Jcd.SRecord.IO.ISRecordElementFormatter
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordElementFormatter

Implements [ISRecordElementFormatter](Jcd.SRecord.IO.ISRecordElementFormatter.md 'Jcd.SRecord.IO.ISRecordElementFormatter')

| Constructors | |
| :--- | :--- |
| [SRecordElementFormatter(Nullable&lt;Options&gt;, ISRecordFormatter)](Jcd.SRecord.IO.SRecordElementFormatter.SRecordElementFormatter(System.Nullable_Jcd.SRecord.IO.SRecordElementFormatter.Options_,Jcd.SRecord.ISRecordFormatter).md 'Jcd.SRecord.IO.SRecordElementFormatter.SRecordElementFormatter(System.Nullable<Jcd.SRecord.IO.SRecordElementFormatter.Options>, Jcd.SRecord.ISRecordFormatter)') | Constructs an instance of `SRecordElementFormatter` with the specified<br/>options and `ISRecordFormatter`. |

| Fields | |
| :--- | :--- |
| [Default](Jcd.SRecord.IO.SRecordElementFormatter.Default.md 'Jcd.SRecord.IO.SRecordElementFormatter.Default') | Gets the default instance of `SRecordElementFormatter` |

| Properties | |
| :--- | :--- |
| [CurrentOptions](Jcd.SRecord.IO.SRecordElementFormatter.CurrentOptions.md 'Jcd.SRecord.IO.SRecordElementFormatter.CurrentOptions') | Gets the currently configured options. |
| [RecordFormatter](Jcd.SRecord.IO.SRecordElementFormatter.RecordFormatter.md 'Jcd.SRecord.IO.SRecordElementFormatter.RecordFormatter') | Gets the currently configured `ISRecordFormatter` |

| Methods | |
| :--- | :--- |
| [Format(SRecordElement)](Jcd.SRecord.IO.SRecordElementFormatter.Format(Jcd.SRecord.IO.SRecordElement).md 'Jcd.SRecord.IO.SRecordElementFormatter.Format(Jcd.SRecord.IO.SRecordElement)') | Formats an `SRecordElement` as a element of text. |

| Events | |
| :--- | :--- |
| [Formatted](Jcd.SRecord.IO.SRecordElementFormatter.Formatted.md 'Jcd.SRecord.IO.SRecordElementFormatter.Formatted') | An event that indicates formatting has finished. |
| [Formatting](Jcd.SRecord.IO.SRecordElementFormatter.Formatting.md 'Jcd.SRecord.IO.SRecordElementFormatter.Formatting') | An event indicating that formatting has begun. |
