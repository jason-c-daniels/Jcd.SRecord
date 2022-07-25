#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## SRecordElementFormatter Class

Encapsulates the logic necessary to format an `SRecordElement`  
as a line of text.

```csharp
public class SRecordElementFormatter :
Jcd.SRecord.ISRecordElementFormatter
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordElementFormatter

Implements [ISRecordElementFormatter](Jcd.SRecord.ISRecordElementFormatter.md 'Jcd.SRecord.ISRecordElementFormatter')

| Constructors | |
| :--- | :--- |
| [SRecordElementFormatter(Nullable&lt;Options&gt;, ISRecordDataFormatter)](Jcd.SRecord.SRecordElementFormatter.SRecordElementFormatter(System.Nullable_Jcd.SRecord.SRecordElementFormatter.Options_,Jcd.SRecord.ISRecordDataFormatter).md 'Jcd.SRecord.SRecordElementFormatter.SRecordElementFormatter(System.Nullable<Jcd.SRecord.SRecordElementFormatter.Options>, Jcd.SRecord.ISRecordDataFormatter)') | Constructs an instance of `SRecordElementFormatter` with the specified<br/>options and `ISRecordDataFormatter`. |

| Fields | |
| :--- | :--- |
| [Default](Jcd.SRecord.SRecordElementFormatter.Default.md 'Jcd.SRecord.SRecordElementFormatter.Default') | Gets the default instance of `SRecordElementFormatter` |

| Properties | |
| :--- | :--- |
| [CurrentOptions](Jcd.SRecord.SRecordElementFormatter.CurrentOptions.md 'Jcd.SRecord.SRecordElementFormatter.CurrentOptions') | Gets the currently configured options. |
| [RecordFormatter](Jcd.SRecord.SRecordElementFormatter.RecordFormatter.md 'Jcd.SRecord.SRecordElementFormatter.RecordFormatter') | Gets the currently configured `ISRecordDataFormatter` |

| Methods | |
| :--- | :--- |
| [Format(SRecordElement)](Jcd.SRecord.SRecordElementFormatter.Format(Jcd.SRecord.SRecordElement).md 'Jcd.SRecord.SRecordElementFormatter.Format(Jcd.SRecord.SRecordElement)') | Formats an `SRecordElement` as a element of text. |

| Events | |
| :--- | :--- |
| [Formatted](Jcd.SRecord.SRecordElementFormatter.Formatted.md 'Jcd.SRecord.SRecordElementFormatter.Formatted') | An event that indicates formatting has finished. |
| [Formatting](Jcd.SRecord.SRecordElementFormatter.Formatting.md 'Jcd.SRecord.SRecordElementFormatter.Formatting') | An event indicating that formatting has begun. |
