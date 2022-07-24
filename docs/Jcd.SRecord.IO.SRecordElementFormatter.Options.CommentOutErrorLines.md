#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElementFormatter](Jcd.SRecord.IO.SRecordElementFormatter.md 'Jcd.SRecord.IO.SRecordElementFormatter').[Options](Jcd.SRecord.IO.SRecordElementFormatter.Options.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options')

## SRecordElementFormatter.Options.CommentOutErrorLines Field

A convenience instance that is configured to emit `SRecord` line and comment data.  
As well `SRecordElement`s flagged as having an error will be emitted as commented out  
lines. (SRecordElement.OriginalLine is used, otherwise preserving the whole line.)

```csharp
public static readonly Options CommentOutErrorLines;
```

#### Field Value
[Options](Jcd.SRecord.IO.SRecordElementFormatter.Options.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options')