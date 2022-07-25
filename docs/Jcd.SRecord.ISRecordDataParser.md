#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## ISRecordDataParser Interface

Defines the operations necessary in order to support parsing text into  
`SRecordData` instances.

```csharp
public interface ISRecordDataParser
```

Derived  
&#8627; [SRecordDataParser](Jcd.SRecord.SRecordDataParser.md 'Jcd.SRecord.SRecordDataParser')

| Methods | |
| :--- | :--- |
| [Parse(string)](Jcd.SRecord.ISRecordDataParser.Parse(string).md 'Jcd.SRecord.ISRecordDataParser.Parse(string)') | Parses a line of text into an `SRecordData, ignoring trailing whitespace.` |
| [TryParse(string, SRecordData)](Jcd.SRecord.ISRecordDataParser.TryParse(string,Jcd.SRecord.SRecordData).md 'Jcd.SRecord.ISRecordDataParser.TryParse(string, Jcd.SRecord.SRecordData)') | Tries parsing a line of text into an `SRecordData` |
