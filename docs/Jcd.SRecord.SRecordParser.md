#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## SRecordParser Class

Provides facilities for parsing the textual SRecord format into its  
binary representation.

```csharp
public class SRecordParser :
Jcd.SRecord.ISRecordParser
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordParser

Implements [ISRecordParser](Jcd.SRecord.ISRecordParser.md 'Jcd.SRecord.ISRecordParser')

| Constructors | |
| :--- | :--- |
| [SRecordParser(IDictionary&lt;string,SRecordType&gt;)](Jcd.SRecord.SRecordParser.SRecordParser(System.Collections.Generic.IDictionary_string,Jcd.SRecord.SRecordType_).md 'Jcd.SRecord.SRecordParser.SRecordParser(System.Collections.Generic.IDictionary<string,Jcd.SRecord.SRecordType>)') | Constructs an SRecordParser from a defined sRecord type lookup table. |

| Fields | |
| :--- | :--- |
| [Default](Jcd.SRecord.SRecordParser.Default.md 'Jcd.SRecord.SRecordParser.Default') | An default instance. This is the same as Flexible. |
| [Flexible](Jcd.SRecord.SRecordParser.Flexible.md 'Jcd.SRecord.SRecordParser.Flexible') | An instance configured to use Flexible definitions. |
| [Strict](Jcd.SRecord.SRecordParser.Strict.md 'Jcd.SRecord.SRecordParser.Strict') | An instance configured to use Strict definitions. |

| Methods | |
| :--- | :--- |
| [Create(byte)](Jcd.SRecord.SRecordParser.Create(byte).md 'Jcd.SRecord.SRecordParser.Create(byte)') | Creates a new instance of an SRecordParser configured to parse records<br/>containing the configured maxDataBytesPerRecord. |
| [Parse(string)](Jcd.SRecord.SRecordParser.Parse(string).md 'Jcd.SRecord.SRecordParser.Parse(string)') | Parses a line of text into an `SRecord, ignoring trailing whitespace.` |
| [TryParse(string, SRecord)](Jcd.SRecord.SRecordParser.TryParse(string,Jcd.SRecord.SRecord).md 'Jcd.SRecord.SRecordParser.TryParse(string, Jcd.SRecord.SRecord)') | Tries parsing a line of text into an `SRecord` |
