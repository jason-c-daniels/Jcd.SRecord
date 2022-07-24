#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.Parsers](Jcd.SRecord.Parsers.md 'Jcd.SRecord.Parsers')

## SRecordLine Class

Represents a single line read and parsed from an `SRecordLineReader`.

```csharp
public class SRecordLine
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordLine

| Constructors | |
| :--- | :--- |
| [SRecordLine(int, SRecordLineType, SRecord, string, string, string, Exception)](Jcd.SRecord.Parsers.SRecordLine.SRecordLine(int,Jcd.SRecord.IO.SRecordLineType,Jcd.SRecord.SRecord,string,string,string,System.Exception).md 'Jcd.SRecord.Parsers.SRecordLine.SRecordLine(int, Jcd.SRecord.IO.SRecordLineType, Jcd.SRecord.SRecord, string, string, string, System.Exception)') | Constructs an instance of an `SRecordLine` |

| Properties | |
| :--- | :--- |
| [Comment](Jcd.SRecord.Parsers.SRecordLine.Comment.md 'Jcd.SRecord.Parsers.SRecordLine.Comment') | The comment text (lines starting with a ';' '#' ...etc are comment lines.) |
| [ErrorMessage](Jcd.SRecord.Parsers.SRecordLine.ErrorMessage.md 'Jcd.SRecord.Parsers.SRecordLine.ErrorMessage') | Contains a parser specific error message associated with attempting to parse this line. |
| [Exception](Jcd.SRecord.Parsers.SRecordLine.Exception.md 'Jcd.SRecord.Parsers.SRecordLine.Exception') | An exception that happened while trying to parse the line of text. |
| [LineNumber](Jcd.SRecord.Parsers.SRecordLine.LineNumber.md 'Jcd.SRecord.Parsers.SRecordLine.LineNumber') | The line in the file where the text was found. |
| [LineType](Jcd.SRecord.Parsers.SRecordLine.LineType.md 'Jcd.SRecord.Parsers.SRecordLine.LineType') | True if the line recognized as an SRecord and/or comment. False otherwise.<br/>When false, OriginalLine should be populated with the extracted line of text, without end of line character(s).<br/>Also, ErrorMessage should be populated with the error encountered while trying to parse the line. |
| [OriginalLine](Jcd.SRecord.Parsers.SRecordLine.OriginalLine.md 'Jcd.SRecord.Parsers.SRecordLine.OriginalLine') | The original line of text. A well constructed parser will always provide this. The default one does. |
| [SRecord](Jcd.SRecord.Parsers.SRecordLine.SRecord.md 'Jcd.SRecord.Parsers.SRecordLine.SRecord') | The SRecord parsed from the line (if any) |
