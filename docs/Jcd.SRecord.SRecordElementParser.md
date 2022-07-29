#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## SRecordElementParser Class

Provides a default mechanism for parsing a line of text into an `SRecordElement`.

```csharp
public class SRecordElementParser :
Jcd.SRecord.ISRecordElementParser
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordElementParser

Implements [ISRecordElementParser](Jcd.SRecord.ISRecordElementParser.md 'Jcd.SRecord.ISRecordElementParser')

| Constructors | |
| :--- | :--- |
| [SRecordElementParser(ISRecordDataParser, IEnumerable&lt;char&gt;)](Jcd.SRecord.SRecordElementParser.SRecordElementParser(Jcd.SRecord.ISRecordDataParser,System.Collections.Generic.IEnumerable_char_).md 'Jcd.SRecord.SRecordElementParser.SRecordElementParser(Jcd.SRecord.ISRecordDataParser, System.Collections.Generic.IEnumerable<char>)') | Constructs an `SRecordElementParser` from an `ISRecordDataParser` and an optional set of comment characters. |

| Fields | |
| :--- | :--- |
| [DefaultCommentCharacters](Jcd.SRecord.SRecordElementParser.DefaultCommentCharacters.md 'Jcd.SRecord.SRecordElementParser.DefaultCommentCharacters') | The default set of comment characters we'll parse. |
| [Flexible](Jcd.SRecord.SRecordElementParser.Flexible.md 'Jcd.SRecord.SRecordElementParser.Flexible') | An `SRecordElementParser` configured to accept either '#' or ';' as comment characters,  and to allow up to 250-252 (SRecordDataType dependent) data bytes in the `SRecordData` data. |
| [FlexibleNoComments](Jcd.SRecord.SRecordElementParser.FlexibleNoComments.md 'Jcd.SRecord.SRecordElementParser.FlexibleNoComments') | An `SRecordElementParser` configured to accept no comments, and to allow up to 250-252 (SRecordDataType dependent) data bytes in the `SRecordData` data. |
| [Strict](Jcd.SRecord.SRecordElementParser.Strict.md 'Jcd.SRecord.SRecordElementParser.Strict') | An `SRecordElementParser` configured to accept either '#' or ';' as comment characters,  and to allow up to 32 (SRecordDataType dependent) data bytes in the `SRecordData` data. |
| [StrictNoComments](Jcd.SRecord.SRecordElementParser.StrictNoComments.md 'Jcd.SRecord.SRecordElementParser.StrictNoComments') | An `SRecordElementParser` configured to accept no comments, and to allow up to 250-252 (SRecordDataType dependent) data bytes in the `SRecordData` data. |

| Properties | |
| :--- | :--- |
| [AllowComments](Jcd.SRecord.SRecordElementParser.AllowComments.md 'Jcd.SRecord.SRecordElementParser.AllowComments') | Indicates if comments are allowed. To Allow comments pass a set of recognized comment characters in to the constructor. |
| [CommentCharacters](Jcd.SRecord.SRecordElementParser.CommentCharacters.md 'Jcd.SRecord.SRecordElementParser.CommentCharacters') | Gets a copy of the comment characters in use. |
| [Default](Jcd.SRecord.SRecordElementParser.Default.md 'Jcd.SRecord.SRecordElementParser.Default') | A default instance configured with reasonable, flexible, defaults. It should parse most any line. |
| [RecordParser](Jcd.SRecord.SRecordElementParser.RecordParser.md 'Jcd.SRecord.SRecordElementParser.RecordParser') | Gets the `ISRecordDataParser` instance used to parse the `SRecordData` data from a line of text. |

| Methods | |
| :--- | :--- |
| [Parse(int, string)](Jcd.SRecord.SRecordElementParser.Parse(int,string).md 'Jcd.SRecord.SRecordElementParser.Parse(int, string)') | Parses a line of text into an SRecordElement. |

| Events | |
| :--- | :--- |
| [Parsed](Jcd.SRecord.SRecordElementParser.Parsed.md 'Jcd.SRecord.SRecordElementParser.Parsed') | An event indicating parsing has finished.<br/>The data on the argument is the element resulting from parsing. |
| [Parsing](Jcd.SRecord.SRecordElementParser.Parsing.md 'Jcd.SRecord.SRecordElementParser.Parsing') | An event indicating parsing of a line of text has begun.<br/>The data on the argument is the original line of text. |
