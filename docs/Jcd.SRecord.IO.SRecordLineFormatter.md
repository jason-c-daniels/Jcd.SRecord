#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO')

## SRecordLineFormatter Class

Encapsulates the logic necessary to format an `SRecordLine`  
as a line of text.

```csharp
public class SRecordLineFormatter :
Jcd.SRecord.IO.ISRecordLineFormatter
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordLineFormatter

Implements [ISRecordLineFormatter](Jcd.SRecord.IO.ISRecordLineFormatter.md 'Jcd.SRecord.IO.ISRecordLineFormatter')

| Constructors | |
| :--- | :--- |
| [SRecordLineFormatter(Nullable&lt;Options&gt;, SRecordFormatter)](Jcd.SRecord.IO.SRecordLineFormatter.SRecordLineFormatter(System.Nullable_Jcd.SRecord.IO.SRecordLineFormatter.Options_,Jcd.SRecord.SRecordFormatter).md 'Jcd.SRecord.IO.SRecordLineFormatter.SRecordLineFormatter(System.Nullable<Jcd.SRecord.IO.SRecordLineFormatter.Options>, Jcd.SRecord.SRecordFormatter)') | Constructs an instance of `SRecordLineFormatter` with the specified<br/>options and SRecordFormatter. |

| Fields | |
| :--- | :--- |
| [DefaultFormatter](Jcd.SRecord.IO.SRecordLineFormatter.DefaultFormatter.md 'Jcd.SRecord.IO.SRecordLineFormatter.DefaultFormatter') | Gets the default instance of `SRecordLineFormatter` |

| Properties | |
| :--- | :--- |
| [CurrentOptions](Jcd.SRecord.IO.SRecordLineFormatter.CurrentOptions.md 'Jcd.SRecord.IO.SRecordLineFormatter.CurrentOptions') | Gets the currently configured options. |
| [SRecordFormatter](Jcd.SRecord.IO.SRecordLineFormatter.SRecordFormatter.md 'Jcd.SRecord.IO.SRecordLineFormatter.SRecordFormatter') | Gets the currently configured SRecordFormatter |

| Methods | |
| :--- | :--- |
| [Format(SRecordLine)](Jcd.SRecord.IO.SRecordLineFormatter.Format(Jcd.SRecord.Parsers.SRecordLine).md 'Jcd.SRecord.IO.SRecordLineFormatter.Format(Jcd.SRecord.Parsers.SRecordLine)') | Formats an `SRecordLine` as a line of text. |
