#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordLineFormatter](Jcd.SRecord.IO.SRecordLineFormatter.md 'Jcd.SRecord.IO.SRecordLineFormatter')

## SRecordLineFormatter.Format(SRecordLine) Method

Formats an `SRecordLine` as a line of text.

```csharp
public string Format(Jcd.SRecord.Parsers.SRecordLine line);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordLineFormatter.Format(Jcd.SRecord.Parsers.SRecordLine).line'></a>

`line` [SRecordLine](Jcd.SRecord.Parsers.SRecordLine.md 'Jcd.SRecord.Parsers.SRecordLine')

the line to format.

Implements [Format(SRecordLine)](Jcd.SRecord.IO.ISRecordLineFormatter.Format(Jcd.SRecord.Parsers.SRecordLine).md 'Jcd.SRecord.IO.ISRecordLineFormatter.Format(Jcd.SRecord.Parsers.SRecordLine)')

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Null indicates no line was generated. String.Empty indicates  
that a blank line was generated. `SRecordLineWriter`  
will discard null results. Depending on options settings, it may write  
blank lines.