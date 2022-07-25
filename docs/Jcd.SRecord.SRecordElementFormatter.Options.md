#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordElementFormatter](Jcd.SRecord.SRecordElementFormatter.md 'Jcd.SRecord.SRecordElementFormatter')

## SRecordElementFormatter.Options Struct

Represents the formatting options desired when writing `SRecordElement` contents  
to an `SRecordElementWriter`.

```csharp
public struct SRecordElementFormatter.Options
```

| Constructors | |
| :--- | :--- |
| [Options(bool, bool, bool, bool, bool, bool, char)](Jcd.SRecord.SRecordElementFormatter.Options.Options(bool,bool,bool,bool,bool,bool,char).md 'Jcd.SRecord.SRecordElementFormatter.Options.Options(bool, bool, bool, bool, bool, bool, char)') | Constructs a set of options to control the behavior of SRecordElementFormatter. |

| Fields | |
| :--- | :--- |
| [CommentCharacter](Jcd.SRecord.SRecordElementFormatter.Options.CommentCharacter.md 'Jcd.SRecord.SRecordElementFormatter.Options.CommentCharacter') | The character to use when emitting a comment. |
| [CommentOutErrorLines](Jcd.SRecord.SRecordElementFormatter.Options.CommentOutErrorLines.md 'Jcd.SRecord.SRecordElementFormatter.Options.CommentOutErrorLines') | A convenience instance that is configured to emit `SRecordData` line and comment data.<br/>As well `SRecordElement`s flagged as having an error will be emitted as commented out<br/>lines. (SRecordElement.OriginalLine is used, otherwise preserving the whole line.) |
| [EmitBlankLineAsEmptyString](Jcd.SRecord.SRecordElementFormatter.Options.EmitBlankLineAsEmptyString.md 'Jcd.SRecord.SRecordElementFormatter.Options.EmitBlankLineAsEmptyString') | Indicates if the formatter should emit a blank line as an empty string or null.<br/>When false, lines that would format to an empty string, become null instead. |
| [EmitComment](Jcd.SRecord.SRecordElementFormatter.Options.EmitComment.md 'Jcd.SRecord.SRecordElementFormatter.Options.EmitComment') | Tells the formatter if end of line comments should be emitted. |
| [EmitErrorLineAsCommentLine](Jcd.SRecord.SRecordElementFormatter.Options.EmitErrorLineAsCommentLine.md 'Jcd.SRecord.SRecordElementFormatter.Options.EmitErrorLineAsCommentLine') | Indicates if the formatter should emit an error line as a commented out line.<br/>In order for a comment line to be emitted, EmitComment must also be true.<br/>If false, a blank line or null will be generated for error lines (depending on blank line handling). |
| [EmitOriginalText](Jcd.SRecord.SRecordElementFormatter.Options.EmitOriginalText.md 'Jcd.SRecord.SRecordElementFormatter.Options.EmitOriginalText') | Tells the formatter to ignore all other directives, and just emit the original line of text. |
| [EmitSpaceBeforeEndOfLineComment](Jcd.SRecord.SRecordElementFormatter.Options.EmitSpaceBeforeEndOfLineComment.md 'Jcd.SRecord.SRecordElementFormatter.Options.EmitSpaceBeforeEndOfLineComment') | Tells the formatter if a space should be emitted before an end of line comment. |
| [EmitSRecordAndCommentData](Jcd.SRecord.SRecordElementFormatter.Options.EmitSRecordAndCommentData.md 'Jcd.SRecord.SRecordElementFormatter.Options.EmitSRecordAndCommentData') | A convenience instance that is configured to emit `SRecordData` line and comment data. |
| [EmitSRecordAndCommentDataWithSpace](Jcd.SRecord.SRecordElementFormatter.Options.EmitSRecordAndCommentDataWithSpace.md 'Jcd.SRecord.SRecordElementFormatter.Options.EmitSRecordAndCommentDataWithSpace') | A convenience instance that is configured to emit `SRecordData`<br/>line and comment data. For end of line comments after `SRecordData`<br/>data, a space is inserted before the comment character. |
| [EmitSRecordContent](Jcd.SRecord.SRecordElementFormatter.Options.EmitSRecordContent.md 'Jcd.SRecord.SRecordElementFormatter.Options.EmitSRecordContent') | Tells the formatter to emit the SRecordData when present. This is usually true. |
| [OnlyEmitCommentData](Jcd.SRecord.SRecordElementFormatter.Options.OnlyEmitCommentData.md 'Jcd.SRecord.SRecordElementFormatter.Options.OnlyEmitCommentData') | A convenience instance that is configured to only emit comment data. |
| [OnlyEmitOriginalText](Jcd.SRecord.SRecordElementFormatter.Options.OnlyEmitOriginalText.md 'Jcd.SRecord.SRecordElementFormatter.Options.OnlyEmitOriginalText') | A convenience instance that is configured to only emit the original text. |
| [OnlyEmitSRecordData](Jcd.SRecord.SRecordElementFormatter.Options.OnlyEmitSRecordData.md 'Jcd.SRecord.SRecordElementFormatter.Options.OnlyEmitSRecordData') | A convenience instance that is configured to only emit `SRecordData` line and only the `SRecordData` data. |

| Properties | |
| :--- | :--- |
| [DefaultOptions](Jcd.SRecord.SRecordElementFormatter.Options.DefaultOptions.md 'Jcd.SRecord.SRecordElementFormatter.Options.DefaultOptions') | See `EmitSRecordAndCommentDataWithSpace` |
