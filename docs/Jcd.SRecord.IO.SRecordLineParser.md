#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO')

## SRecordLineParser Class

Provides a simplistic manner of parsing SRecords

```csharp
public class SRecordLineParser :
Jcd.SRecord.Parsers.ISRecordLineParser
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordLineParser

Implements [ISRecordLineParser](Jcd.SRecord.Parsers.ISRecordLineParser.md 'Jcd.SRecord.Parsers.ISRecordLineParser')

| Constructors | |
| :--- | :--- |
| [SRecordLineParser(SRecordParser, IEnumerable&lt;char&gt;)](Jcd.SRecord.IO.SRecordLineParser.SRecordLineParser(Jcd.SRecord.SRecordParser,System.Collections.Generic.IEnumerable_char_).md 'Jcd.SRecord.IO.SRecordLineParser.SRecordLineParser(Jcd.SRecord.SRecordParser, System.Collections.Generic.IEnumerable<char>)') | Constructs an SRecordLineParser from an `SRecordParser`<br/>and an optional set of comment characters. |

| Fields | |
| :--- | :--- |
| [Default](Jcd.SRecord.IO.SRecordLineParser.Default.md 'Jcd.SRecord.IO.SRecordLineParser.Default') | A default instance configured with reasonable, flexible, defaults. It should parse most any line. |
| [DefaultCommentCharacters](Jcd.SRecord.IO.SRecordLineParser.DefaultCommentCharacters.md 'Jcd.SRecord.IO.SRecordLineParser.DefaultCommentCharacters') | The default set of comment characeters we'll parse. |
| [NoComments](Jcd.SRecord.IO.SRecordLineParser.NoComments.md 'Jcd.SRecord.IO.SRecordLineParser.NoComments') | A default instance configured with reasonable, flexible, defaults. It should parse most any line. |

| Properties | |
| :--- | :--- |
| [AllowComments](Jcd.SRecord.IO.SRecordLineParser.AllowComments.md 'Jcd.SRecord.IO.SRecordLineParser.AllowComments') | Indicates if comments are allowed. To Allow comments pass a set of<br/>recognized comment characters in to the constructor. |
| [CommentCharacters](Jcd.SRecord.IO.SRecordLineParser.CommentCharacters.md 'Jcd.SRecord.IO.SRecordLineParser.CommentCharacters') | Gets a copy of the comment characters in use. |

| Methods | |
| :--- | :--- |
| [Parse(int, string)](Jcd.SRecord.IO.SRecordLineParser.Parse(int,string).md 'Jcd.SRecord.IO.SRecordLineParser.Parse(int, string)') | Parses a line of text into an SRecordLine. |
