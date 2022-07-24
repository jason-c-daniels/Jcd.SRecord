#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[ISRecordLineFormatter](Jcd.SRecord.IO.ISRecordLineFormatter.md 'Jcd.SRecord.IO.ISRecordLineFormatter')

## ISRecordLineFormatter.Format(SRecordLine) Method

Formats an `SRecordLine` as a line of text.

```csharp
string Format(Jcd.SRecord.Parsers.SRecordLine line);
```
#### Parameters

<a name='Jcd.SRecord.IO.ISRecordLineFormatter.Format(Jcd.SRecord.Parsers.SRecordLine).line'></a>

`line` [SRecordLine](Jcd.SRecord.Parsers.SRecordLine.md 'Jcd.SRecord.Parsers.SRecordLine')

the line to format.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Null indicates no line was generated. String.Empty indicates  
that a blank line was generated. `SRecordLineWriter`  
will discard null results. Depending on options settings, it may write  
blank lines.