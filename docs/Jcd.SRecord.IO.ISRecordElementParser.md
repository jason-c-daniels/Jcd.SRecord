#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO')

## ISRecordElementParser Interface

Defines the operations necessary to parse `SRecordElement`s  
from text.

```csharp
public interface ISRecordElementParser
```

Derived  
&#8627; [SRecordElementParser](Jcd.SRecord.IO.SRecordElementParser.md 'Jcd.SRecord.IO.SRecordElementParser')

| Properties | |
| :--- | :--- |
| [AllowComments](Jcd.SRecord.IO.ISRecordElementParser.AllowComments.md 'Jcd.SRecord.IO.ISRecordElementParser.AllowComments') | A flag indicating if comments will be parsed and removed before interpreting<br/>the `SRecord` data. |

| Methods | |
| :--- | :--- |
| [Parse(int, string)](Jcd.SRecord.IO.ISRecordElementParser.Parse(int,string).md 'Jcd.SRecord.IO.ISRecordElementParser.Parse(int, string)') | Parses a line of text into an SRecordElement. |

| Events | |
| :--- | :--- |
| [Parsed](Jcd.SRecord.IO.ISRecordElementParser.Parsed.md 'Jcd.SRecord.IO.ISRecordElementParser.Parsed') | An event that indicates parsing has finished. |
| [Parsing](Jcd.SRecord.IO.ISRecordElementParser.Parsing.md 'Jcd.SRecord.IO.ISRecordElementParser.Parsing') | An event indicating that parsing has begun. |
