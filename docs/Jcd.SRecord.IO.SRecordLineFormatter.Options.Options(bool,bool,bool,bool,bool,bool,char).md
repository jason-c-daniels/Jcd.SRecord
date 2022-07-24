#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordLineFormatter](Jcd.SRecord.IO.SRecordLineFormatter.md 'Jcd.SRecord.IO.SRecordLineFormatter').[Options](Jcd.SRecord.IO.SRecordLineFormatter.Options.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options')

## Options(bool, bool, bool, bool, bool, bool, char) Constructor

Constructs a set of options to control the behavior of SRecordLineFormatter.

```csharp
public Options(bool emitSRecordContent=false, bool emitComment=false, bool emitSpaceBeforeEndOfLineComment=false, bool emitOriginalText=false, bool emitBlankLineAsEmptyString=false, bool emitErrorLineAsCommentLine=false, char commentCharacter='#');
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordLineFormatter.Options.Options(bool,bool,bool,bool,bool,bool,char).emitSRecordContent'></a>

`emitSRecordContent` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Tells the formatter to emit the SRecord when present.

<a name='Jcd.SRecord.IO.SRecordLineFormatter.Options.Options(bool,bool,bool,bool,bool,bool,char).emitComment'></a>

`emitComment` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Tells the formatter if end of line comments should be emitted.

<a name='Jcd.SRecord.IO.SRecordLineFormatter.Options.Options(bool,bool,bool,bool,bool,bool,char).emitSpaceBeforeEndOfLineComment'></a>

`emitSpaceBeforeEndOfLineComment` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='Jcd.SRecord.IO.SRecordLineFormatter.Options.Options(bool,bool,bool,bool,bool,bool,char).emitOriginalText'></a>

`emitOriginalText` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Tells the formatter to ignore all other directives, and just emit the original line of text.

<a name='Jcd.SRecord.IO.SRecordLineFormatter.Options.Options(bool,bool,bool,bool,bool,bool,char).emitBlankLineAsEmptyString'></a>

`emitBlankLineAsEmptyString` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='Jcd.SRecord.IO.SRecordLineFormatter.Options.Options(bool,bool,bool,bool,bool,bool,char).emitErrorLineAsCommentLine'></a>

`emitErrorLineAsCommentLine` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='Jcd.SRecord.IO.SRecordLineFormatter.Options.Options(bool,bool,bool,bool,bool,bool,char).commentCharacter'></a>

`commentCharacter` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')