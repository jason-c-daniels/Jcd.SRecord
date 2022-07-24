#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## ISRecordParser Interface

Defines the operations necessary in order to support parsing text into  
`SRecord` instances.

```csharp
public interface ISRecordParser
```

Derived  
&#8627; [SRecordParser](Jcd.SRecord.SRecordParser.md 'Jcd.SRecord.SRecordParser')

| Methods | |
| :--- | :--- |
| [Parse(string)](Jcd.SRecord.ISRecordParser.Parse(string).md 'Jcd.SRecord.ISRecordParser.Parse(string)') | Parses a line of text into an `SRecord, ignoring trailing whitespace.` |
| [TryParse(string, SRecord)](Jcd.SRecord.ISRecordParser.TryParse(string,Jcd.SRecord.SRecord).md 'Jcd.SRecord.ISRecordParser.TryParse(string, Jcd.SRecord.SRecord)') | Tries parsing a line of text into an `SRecord` |
