#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO')

## SRecordElement Class

Represents a single line in an `SRecordDocument`

```csharp
public class SRecordElement
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordElement

| Constructors | |
| :--- | :--- |
| [SRecordElement(int, SRecordElementType, SRecord, string, string, string, Exception)](Jcd.SRecord.IO.SRecordElement.SRecordElement(int,Jcd.SRecord.IO.SRecordElementType,Jcd.SRecord.SRecord,string,string,string,System.Exception).md 'Jcd.SRecord.IO.SRecordElement.SRecordElement(int, Jcd.SRecord.IO.SRecordElementType, Jcd.SRecord.SRecord, string, string, string, System.Exception)') | Constructs an instance of an `SRecordElement` |

| Properties | |
| :--- | :--- |
| [Comment](Jcd.SRecord.IO.SRecordElement.Comment.md 'Jcd.SRecord.IO.SRecordElement.Comment') | The comment text (lines starting with a ';' '#' ...etc are comment lines.) |
| [ElementType](Jcd.SRecord.IO.SRecordElement.ElementType.md 'Jcd.SRecord.IO.SRecordElement.ElementType') | True if the line recognized as an SRecord and/or comment. False otherwise.<br/>When false, OriginalLine should be populated with the extracted line of text, without end of line character(s).<br/>Also, ErrorMessage should be populated with the error encountered while trying to parse the line. |
| [ErrorMessage](Jcd.SRecord.IO.SRecordElement.ErrorMessage.md 'Jcd.SRecord.IO.SRecordElement.ErrorMessage') | Contains a parser specific error message associated with attempting to parse this line. |
| [Exception](Jcd.SRecord.IO.SRecordElement.Exception.md 'Jcd.SRecord.IO.SRecordElement.Exception') | An exception that happened while trying to parse the line of text. |
| [LineNumber](Jcd.SRecord.IO.SRecordElement.LineNumber.md 'Jcd.SRecord.IO.SRecordElement.LineNumber') | The line in the file where the text was found. |
| [OriginalLine](Jcd.SRecord.IO.SRecordElement.OriginalLine.md 'Jcd.SRecord.IO.SRecordElement.OriginalLine') | The original line of text. A well constructed parser will always provide this. The default one does. |
| [SRecord](Jcd.SRecord.IO.SRecordElement.SRecord.md 'Jcd.SRecord.IO.SRecordElement.SRecord') | The SRecord parsed from the line (if any) |
