#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.Parsers](Jcd.SRecord.Parsers.md 'Jcd.SRecord.Parsers').[SRecordLine](Jcd.SRecord.Parsers.SRecordLine.md 'Jcd.SRecord.Parsers.SRecordLine')

## SRecordLine.LineType Property

True if the line recognized as an SRecord and/or comment. False otherwise.  
When false, OriginalLine should be populated with the extracted line of text, without end of line character(s).  
Also, ErrorMessage should be populated with the error encountered while trying to parse the line.

```csharp
public Jcd.SRecord.IO.SRecordLineType LineType { get; set; }
```

#### Property Value
[SRecordLineType](Jcd.SRecord.IO.SRecordLineType.md 'Jcd.SRecord.IO.SRecordLineType')