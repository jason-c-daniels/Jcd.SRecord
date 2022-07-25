#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## ISRecordElementParser Interface

Defines the operations necessary to parse `SRecordElement`s  
from text.

```csharp
public interface ISRecordElementParser
```

Derived  
&#8627; [SRecordElementParser](Jcd.SRecord.SRecordElementParser.md 'Jcd.SRecord.SRecordElementParser')

| Properties | |
| :--- | :--- |
| [AllowComments](Jcd.SRecord.ISRecordElementParser.AllowComments.md 'Jcd.SRecord.ISRecordElementParser.AllowComments') | A flag indicating if comments will be parsed and removed before interpreting<br/>the `SRecordData` data. |

| Methods | |
| :--- | :--- |
| [Parse(int, string)](Jcd.SRecord.ISRecordElementParser.Parse(int,string).md 'Jcd.SRecord.ISRecordElementParser.Parse(int, string)') | Parses a line of text into an SRecordElement. |

| Events | |
| :--- | :--- |
| [Parsed](Jcd.SRecord.ISRecordElementParser.Parsed.md 'Jcd.SRecord.ISRecordElementParser.Parsed') | An event that indicates parsing has finished. |
| [Parsing](Jcd.SRecord.ISRecordElementParser.Parsing.md 'Jcd.SRecord.ISRecordElementParser.Parsing') | An event indicating that parsing has begun. |
