#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElementParser](Jcd.SRecord.IO.SRecordElementParser.md 'Jcd.SRecord.IO.SRecordElementParser')

## SRecordElementParser.Parsed Event

An event indicating parsing has finished.  
The data on the argument is the element resulting from parsing.

```csharp
public event EventHandler<SRecordElementParsedEventArgs> Parsed;
```

Implements [Parsed](Jcd.SRecord.IO.ISRecordElementParser.Parsed.md 'Jcd.SRecord.IO.ISRecordElementParser.Parsed')

#### Event Type
[System.EventHandler&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')[SRecordElementParsedEventArgs](Jcd.SRecord.IO.SRecordElementParsedEventArgs.md 'Jcd.SRecord.IO.SRecordElementParsedEventArgs')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')