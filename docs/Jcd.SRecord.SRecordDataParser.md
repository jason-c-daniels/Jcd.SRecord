#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## SRecordDataParser Class

Provides facilities for parsing the textual SRecordData format into its  
binary representation.

```csharp
public class SRecordDataParser :
Jcd.SRecord.ISRecordDataParser
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordDataParser

Implements [ISRecordDataParser](Jcd.SRecord.ISRecordDataParser.md 'Jcd.SRecord.ISRecordDataParser')

| Constructors | |
| :--- | :--- |
| [SRecordDataParser(IDictionary&lt;string,SRecordDataType&gt;)](Jcd.SRecord.SRecordDataParser.SRecordDataParser(System.Collections.Generic.IDictionary_string,Jcd.SRecord.SRecordDataType_).md 'Jcd.SRecord.SRecordDataParser.SRecordDataParser(System.Collections.Generic.IDictionary<string,Jcd.SRecord.SRecordDataType>)') | Constructs an SRecordDataParser from a defined sRecord type lookup table. |

| Fields | |
| :--- | :--- |
| [Default](Jcd.SRecord.SRecordDataParser.Default.md 'Jcd.SRecord.SRecordDataParser.Default') | An default instance. This is the same as Flexible. |
| [Flexible](Jcd.SRecord.SRecordDataParser.Flexible.md 'Jcd.SRecord.SRecordDataParser.Flexible') | An instance configured to use Flexible definitions. |
| [Strict](Jcd.SRecord.SRecordDataParser.Strict.md 'Jcd.SRecord.SRecordDataParser.Strict') | An instance configured to use Strict definitions. |

| Methods | |
| :--- | :--- |
| [Create(byte)](Jcd.SRecord.SRecordDataParser.Create(byte).md 'Jcd.SRecord.SRecordDataParser.Create(byte)') | Creates a new instance of an SRecordDataParser configured to parse records<br/>containing the configured maxDataBytesPerRecord. |
| [Parse(string)](Jcd.SRecord.SRecordDataParser.Parse(string).md 'Jcd.SRecord.SRecordDataParser.Parse(string)') | Parses a line of text into an `SRecordData, ignoring trailing whitespace.` |
| [TryParse(string, SRecordData)](Jcd.SRecord.SRecordDataParser.TryParse(string,Jcd.SRecord.SRecordData).md 'Jcd.SRecord.SRecordDataParser.TryParse(string, Jcd.SRecord.SRecordData)') | Tries parsing a line of text into an `SRecordData` |
