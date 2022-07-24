#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElementParser](Jcd.SRecord.IO.SRecordElementParser.md 'Jcd.SRecord.IO.SRecordElementParser')

## SRecordElementParser.Parsing Event

An event indicating parsing of a line of text has begun.  
The data on the argument is the original line of text.

```csharp
public event EventHandler<SRecordElementParsingEventArgs> Parsing;
```

Implements [Parsing](Jcd.SRecord.IO.ISRecordElementParser.Parsing.md 'Jcd.SRecord.IO.ISRecordElementParser.Parsing')

#### Event Type
[System.EventHandler&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')[SRecordElementParsingEventArgs](Jcd.SRecord.IO.SRecordElementParsingEventArgs.md 'Jcd.SRecord.IO.SRecordElementParsingEventArgs')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')