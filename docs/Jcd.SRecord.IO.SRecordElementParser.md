#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO')

## SRecordElementParser Class

Provides a default mechanism for parsing a line of text into  
an `SRecordElement`.

```csharp
public class SRecordElementParser :
Jcd.SRecord.IO.ISRecordElementParser
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordElementParser

Implements [ISRecordElementParser](Jcd.SRecord.IO.ISRecordElementParser.md 'Jcd.SRecord.IO.ISRecordElementParser')

| Constructors | |
| :--- | :--- |
| [SRecordElementParser(ISRecordParser, IEnumerable&lt;char&gt;)](Jcd.SRecord.IO.SRecordElementParser.SRecordElementParser(Jcd.SRecord.ISRecordParser,System.Collections.Generic.IEnumerable_char_).md 'Jcd.SRecord.IO.SRecordElementParser.SRecordElementParser(Jcd.SRecord.ISRecordParser, System.Collections.Generic.IEnumerable<char>)') | Constructs an `SRecordElementParser` from an `ISRecordParser`<br/>and an optional set of comment characters. |

| Fields | |
| :--- | :--- |
| [DefaultCommentCharacters](Jcd.SRecord.IO.SRecordElementParser.DefaultCommentCharacters.md 'Jcd.SRecord.IO.SRecordElementParser.DefaultCommentCharacters') | The default set of comment characters we'll parse. |
| [Flexible](Jcd.SRecord.IO.SRecordElementParser.Flexible.md 'Jcd.SRecord.IO.SRecordElementParser.Flexible') | An `SRecordElementParser` configured to accept either '#' or ';' as comment<br/>characters,  and to allow up to 250-252 (SRecordType dependent) data bytes in the<br/>`SRecord` data. |
| [FlexibleNoComments](Jcd.SRecord.IO.SRecordElementParser.FlexibleNoComments.md 'Jcd.SRecord.IO.SRecordElementParser.FlexibleNoComments') | An `SRecordElementParser` configured to accept no comments, and to allow up<br/>to 250-252 (SRecordType dependent) data bytes in the `SRecord` data. |
| [Strict](Jcd.SRecord.IO.SRecordElementParser.Strict.md 'Jcd.SRecord.IO.SRecordElementParser.Strict') | An `SRecordElementParser` configured to accept either '#' or ';' as comment<br/>characters,  and to allow up to 32 (SRecordType dependent) data bytes in the<br/>`SRecord` data. |
| [StrictNoComments](Jcd.SRecord.IO.SRecordElementParser.StrictNoComments.md 'Jcd.SRecord.IO.SRecordElementParser.StrictNoComments') | An `SRecordElementParser` configured to accept no comments, and to allow up<br/>to 250-252 (SRecordType dependent) data bytes in the `SRecord` data. |

| Properties | |
| :--- | :--- |
| [AllowComments](Jcd.SRecord.IO.SRecordElementParser.AllowComments.md 'Jcd.SRecord.IO.SRecordElementParser.AllowComments') | Indicates if comments are allowed. To Allow comments pass a set of<br/>recognized comment characters in to the constructor. |
| [CommentCharacters](Jcd.SRecord.IO.SRecordElementParser.CommentCharacters.md 'Jcd.SRecord.IO.SRecordElementParser.CommentCharacters') | Gets a copy of the comment characters in use. |
| [Default](Jcd.SRecord.IO.SRecordElementParser.Default.md 'Jcd.SRecord.IO.SRecordElementParser.Default') | A default instance configured with reasonable, flexible, defaults. It should parse<br/>most any line. |
| [RecordParser](Jcd.SRecord.IO.SRecordElementParser.RecordParser.md 'Jcd.SRecord.IO.SRecordElementParser.RecordParser') | Gets the `ISRecordParser` instance used to parse the `SRecord` data<br/>from a line of text. |

| Methods | |
| :--- | :--- |
| [Parse(int, string)](Jcd.SRecord.IO.SRecordElementParser.Parse(int,string).md 'Jcd.SRecord.IO.SRecordElementParser.Parse(int, string)') | Parses a line of text into an SRecordElement. |

| Events | |
| :--- | :--- |
| [Parsed](Jcd.SRecord.IO.SRecordElementParser.Parsed.md 'Jcd.SRecord.IO.SRecordElementParser.Parsed') | An event indicating parsing has finished.<br/>The data on the argument is the element resulting from parsing. |
| [Parsing](Jcd.SRecord.IO.SRecordElementParser.Parsing.md 'Jcd.SRecord.IO.SRecordElementParser.Parsing') | An event indicating parsing of a line of text has begun.<br/>The data on the argument is the original line of text. |
