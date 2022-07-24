#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordLineFormatter](Jcd.SRecord.IO.SRecordLineFormatter.md 'Jcd.SRecord.IO.SRecordLineFormatter').[Options](Jcd.SRecord.IO.SRecordLineFormatter.Options.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options')

## SRecordLineFormatter.Options.CommentOutErrorLines Field

A convenience instance that is configured to emit `SRecord` line and comment data.  
As well `SRecordLine`s flagged as having an error will be emitted as commented out  
lines. (SRecordLine.OriginalLine is used, otherwise preserving the whole line.)

```csharp
public static readonly Options CommentOutErrorLines;
```

#### Field Value
[Options](Jcd.SRecord.IO.SRecordLineFormatter.Options.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options')