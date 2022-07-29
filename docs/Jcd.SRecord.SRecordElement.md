#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## SRecordElement Class

Represents a single line in an `SRecordDocument`.

```csharp
public class SRecordElement
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordElement

| Constructors | |
| :--- | :--- |
| [SRecordElement(int, SRecordElementType, SRecordData, string, string, string, Exception)](Jcd.SRecord.SRecordElement.SRecordElement(int,Jcd.SRecord.SRecordElementType,Jcd.SRecord.SRecordData,string,string,string,System.Exception).md 'Jcd.SRecord.SRecordElement.SRecordElement(int, Jcd.SRecord.SRecordElementType, Jcd.SRecord.SRecordData, string, string, string, System.Exception)') | Constructs an instance of an `SRecordElement` |

| Properties | |
| :--- | :--- |
| [Comment](Jcd.SRecord.SRecordElement.Comment.md 'Jcd.SRecord.SRecordElement.Comment') | The comment text (lines starting with a ';' '#' ...etc are comment lines.) |
| [ElementType](Jcd.SRecord.SRecordElement.ElementType.md 'Jcd.SRecord.SRecordElement.ElementType') | True if the line recognized as an SRecordData and/or comment. False otherwise.<br/>When false, OriginalLine should be populated with the extracted line of text, without end of line character(s).<br/>Also, ErrorMessage should be populated with the error encountered while trying to parse the line. |
| [ErrorMessage](Jcd.SRecord.SRecordElement.ErrorMessage.md 'Jcd.SRecord.SRecordElement.ErrorMessage') | Contains a parser specific error message associated with attempting to parse this line. |
| [Exception](Jcd.SRecord.SRecordElement.Exception.md 'Jcd.SRecord.SRecordElement.Exception') | An exception that happened while trying to parse the line of text. |
| [LineNumber](Jcd.SRecord.SRecordElement.LineNumber.md 'Jcd.SRecord.SRecordElement.LineNumber') | The line in the file where the text was found. |
| [OriginalLine](Jcd.SRecord.SRecordElement.OriginalLine.md 'Jcd.SRecord.SRecordElement.OriginalLine') | The original line of text. A well constructed parser will always provide this. The default one does. |
| [SRecordData](Jcd.SRecord.SRecordElement.SRecordData.md 'Jcd.SRecord.SRecordElement.SRecordData') | The SRecordData parsed from the line (if any) |
