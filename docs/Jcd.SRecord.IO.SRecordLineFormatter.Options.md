#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordLineFormatter](Jcd.SRecord.IO.SRecordLineFormatter.md 'Jcd.SRecord.IO.SRecordLineFormatter')

## SRecordLineFormatter.Options Struct

Represents the formatting options desired when writing `SRecordLine` contents  
to an `SRecordLineWriter`.

```csharp
public struct SRecordLineFormatter.Options
```

| Constructors | |
| :--- | :--- |
| [Options(bool, bool, bool, bool, bool, bool, char)](Jcd.SRecord.IO.SRecordLineFormatter.Options.Options(bool,bool,bool,bool,bool,bool,char).md 'Jcd.SRecord.IO.SRecordLineFormatter.Options.Options(bool, bool, bool, bool, bool, bool, char)') | Constructs a set of options to control the behavior of SRecordLineFormatter. |

| Fields | |
| :--- | :--- |
| [CommentCharacter](Jcd.SRecord.IO.SRecordLineFormatter.Options.CommentCharacter.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options.CommentCharacter') | The character to use when emitting a comment. |
| [CommentOutErrorLines](Jcd.SRecord.IO.SRecordLineFormatter.Options.CommentOutErrorLines.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options.CommentOutErrorLines') | A convenience instance that is configured to emit `SRecord` line and comment data.<br/>As well `SRecordLine`s flagged as having an error will be emitted as commented out<br/>lines. (SRecordLine.OriginalLine is used, otherwise preserving the whole line.) |
| [EmitBlankLineAsEmptyString](Jcd.SRecord.IO.SRecordLineFormatter.Options.EmitBlankLineAsEmptyString.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options.EmitBlankLineAsEmptyString') | Indicates if the formatter should emit a blank line as an empty string or null.<br/>When false, lines that would format to an empty string, become null instead. |
| [EmitComment](Jcd.SRecord.IO.SRecordLineFormatter.Options.EmitComment.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options.EmitComment') | Tells the formatter if end of line comments should be emitted. |
| [EmitErrorLineAsCommentLine](Jcd.SRecord.IO.SRecordLineFormatter.Options.EmitErrorLineAsCommentLine.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options.EmitErrorLineAsCommentLine') | Indicates if the formatter should emit an error line as a commented out line.<br/>In order for a comment line to be emitted, EmitComment must also be true.<br/>If false, a blank line or null will be generated for error lines (depending on blank line handling). |
| [EmitOriginalText](Jcd.SRecord.IO.SRecordLineFormatter.Options.EmitOriginalText.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options.EmitOriginalText') | Tells the formatter to ignore all other directives, and just emit the original line of text. |
| [EmitSpaceBeforeEndOfLineComment](Jcd.SRecord.IO.SRecordLineFormatter.Options.EmitSpaceBeforeEndOfLineComment.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options.EmitSpaceBeforeEndOfLineComment') | Tells the formatter if a space should be emitted before an end of line comment. |
| [EmitSRecordAndCommentData](Jcd.SRecord.IO.SRecordLineFormatter.Options.EmitSRecordAndCommentData.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options.EmitSRecordAndCommentData') | A convenience instance that is configured to emit `SRecord` line and comment data. |
| [EmitSRecordAndCommentDataWithSpace](Jcd.SRecord.IO.SRecordLineFormatter.Options.EmitSRecordAndCommentDataWithSpace.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options.EmitSRecordAndCommentDataWithSpace') | A convenience instance that is configured to emit `SRecord`<br/>line and comment data. For end of line comments after `SRecord`<br/>data, a space is inserted before the comment character. |
| [EmitSRecordContent](Jcd.SRecord.IO.SRecordLineFormatter.Options.EmitSRecordContent.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options.EmitSRecordContent') | Tells the formatter to emit the SRecord when present. This is usually true. |
| [OnlyEmitCommentData](Jcd.SRecord.IO.SRecordLineFormatter.Options.OnlyEmitCommentData.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options.OnlyEmitCommentData') | A convenience instance that is configured to only emit comment data. |
| [OnlyEmitOriginalText](Jcd.SRecord.IO.SRecordLineFormatter.Options.OnlyEmitOriginalText.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options.OnlyEmitOriginalText') | A convenience instance that is configured to only emit the original text. |
| [OnlyEmitSRecordData](Jcd.SRecord.IO.SRecordLineFormatter.Options.OnlyEmitSRecordData.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options.OnlyEmitSRecordData') | A convenience instance that is configured to only emit `SRecord` line and only the `SRecord` data. |

| Properties | |
| :--- | :--- |
| [DefaultOptions](Jcd.SRecord.IO.SRecordLineFormatter.Options.DefaultOptions.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options.DefaultOptions') | See `EmitSRecordAndCommentDataWithSpace` |
