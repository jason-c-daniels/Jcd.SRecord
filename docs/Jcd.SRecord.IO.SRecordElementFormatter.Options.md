#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElementFormatter](Jcd.SRecord.IO.SRecordElementFormatter.md 'Jcd.SRecord.IO.SRecordElementFormatter')

## SRecordElementFormatter.Options Struct

Represents the formatting options desired when writing `SRecordElement` contents  
to an `SRecordElementWriter`.

```csharp
public struct SRecordElementFormatter.Options
```

| Constructors | |
| :--- | :--- |
| [Options(bool, bool, bool, bool, bool, bool, char)](Jcd.SRecord.IO.SRecordElementFormatter.Options.Options(bool,bool,bool,bool,bool,bool,char).md 'Jcd.SRecord.IO.SRecordElementFormatter.Options.Options(bool, bool, bool, bool, bool, bool, char)') | Constructs a set of options to control the behavior of SRecordElementFormatter. |

| Fields | |
| :--- | :--- |
| [CommentCharacter](Jcd.SRecord.IO.SRecordElementFormatter.Options.CommentCharacter.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options.CommentCharacter') | The character to use when emitting a comment. |
| [CommentOutErrorLines](Jcd.SRecord.IO.SRecordElementFormatter.Options.CommentOutErrorLines.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options.CommentOutErrorLines') | A convenience instance that is configured to emit `SRecord` line and comment data.<br/>As well `SRecordElement`s flagged as having an error will be emitted as commented out<br/>lines. (SRecordElement.OriginalLine is used, otherwise preserving the whole line.) |
| [EmitBlankLineAsEmptyString](Jcd.SRecord.IO.SRecordElementFormatter.Options.EmitBlankLineAsEmptyString.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options.EmitBlankLineAsEmptyString') | Indicates if the formatter should emit a blank line as an empty string or null.<br/>When false, lines that would format to an empty string, become null instead. |
| [EmitComment](Jcd.SRecord.IO.SRecordElementFormatter.Options.EmitComment.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options.EmitComment') | Tells the formatter if end of line comments should be emitted. |
| [EmitErrorLineAsCommentLine](Jcd.SRecord.IO.SRecordElementFormatter.Options.EmitErrorLineAsCommentLine.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options.EmitErrorLineAsCommentLine') | Indicates if the formatter should emit an error line as a commented out line.<br/>In order for a comment line to be emitted, EmitComment must also be true.<br/>If false, a blank line or null will be generated for error lines (depending on blank line handling). |
| [EmitOriginalText](Jcd.SRecord.IO.SRecordElementFormatter.Options.EmitOriginalText.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options.EmitOriginalText') | Tells the formatter to ignore all other directives, and just emit the original line of text. |
| [EmitSpaceBeforeEndOfLineComment](Jcd.SRecord.IO.SRecordElementFormatter.Options.EmitSpaceBeforeEndOfLineComment.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options.EmitSpaceBeforeEndOfLineComment') | Tells the formatter if a space should be emitted before an end of line comment. |
| [EmitSRecordAndCommentData](Jcd.SRecord.IO.SRecordElementFormatter.Options.EmitSRecordAndCommentData.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options.EmitSRecordAndCommentData') | A convenience instance that is configured to emit `SRecord` line and comment data. |
| [EmitSRecordAndCommentDataWithSpace](Jcd.SRecord.IO.SRecordElementFormatter.Options.EmitSRecordAndCommentDataWithSpace.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options.EmitSRecordAndCommentDataWithSpace') | A convenience instance that is configured to emit `SRecord`<br/>line and comment data. For end of line comments after `SRecord`<br/>data, a space is inserted before the comment character. |
| [EmitSRecordContent](Jcd.SRecord.IO.SRecordElementFormatter.Options.EmitSRecordContent.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options.EmitSRecordContent') | Tells the formatter to emit the SRecord when present. This is usually true. |
| [OnlyEmitCommentData](Jcd.SRecord.IO.SRecordElementFormatter.Options.OnlyEmitCommentData.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options.OnlyEmitCommentData') | A convenience instance that is configured to only emit comment data. |
| [OnlyEmitOriginalText](Jcd.SRecord.IO.SRecordElementFormatter.Options.OnlyEmitOriginalText.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options.OnlyEmitOriginalText') | A convenience instance that is configured to only emit the original text. |
| [OnlyEmitSRecordData](Jcd.SRecord.IO.SRecordElementFormatter.Options.OnlyEmitSRecordData.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options.OnlyEmitSRecordData') | A convenience instance that is configured to only emit `SRecord` line and only the `SRecord` data. |

| Properties | |
| :--- | :--- |
| [DefaultOptions](Jcd.SRecord.IO.SRecordElementFormatter.Options.DefaultOptions.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options.DefaultOptions') | See `EmitSRecordAndCommentDataWithSpace` |
