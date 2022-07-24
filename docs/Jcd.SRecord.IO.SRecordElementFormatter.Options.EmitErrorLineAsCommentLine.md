#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElementFormatter](Jcd.SRecord.IO.SRecordElementFormatter.md 'Jcd.SRecord.IO.SRecordElementFormatter').[Options](Jcd.SRecord.IO.SRecordElementFormatter.Options.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options')

## SRecordElementFormatter.Options.EmitErrorLineAsCommentLine Field

Indicates if the formatter should emit an error line as a commented out line.  
In order for a comment line to be emitted, EmitComment must also be true.  
If false, a blank line or null will be generated for error lines (depending on blank line handling).

```csharp
public readonly bool EmitErrorLineAsCommentLine;
```

#### Field Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')