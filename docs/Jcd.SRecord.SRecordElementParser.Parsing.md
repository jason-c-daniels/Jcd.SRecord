#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordElementParser](Jcd.SRecord.SRecordElementParser.md 'Jcd.SRecord.SRecordElementParser')

## SRecordElementParser.Parsing Event

An event indicating parsing of a line of text has begun.  
The data on the argument is the original line of text.

```csharp
public event EventHandler<SRecordElementParsingEventArgs> Parsing;
```

Implements [Parsing](Jcd.SRecord.ISRecordElementParser.Parsing.md 'Jcd.SRecord.ISRecordElementParser.Parsing')

#### Event Type
[System.EventHandler&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')[SRecordElementParsingEventArgs](Jcd.SRecord.SRecordElementParsingEventArgs.md 'Jcd.SRecord.SRecordElementParsingEventArgs')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')