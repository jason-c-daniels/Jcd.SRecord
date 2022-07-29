#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordElementFormatter](Jcd.SRecord.SRecordElementFormatter.md 'Jcd.SRecord.SRecordElementFormatter').[Options](Jcd.SRecord.SRecordElementFormatter.Options.md 'Jcd.SRecord.SRecordElementFormatter.Options')

## SRecordElementFormatter.Options.CommentOutErrorLines Field

A convenience instance that is configured to emit `SRecordData` line and comment data.  
As well `SRecordElement`s flagged as having an error will be emitted as commented out  
lines. (SRecordElement.OriginalLine is used, otherwise preserving the whole line.)

```csharp
public static readonly Options CommentOutErrorLines;
```

#### Field Value
[Options](Jcd.SRecord.SRecordElementFormatter.Options.md 'Jcd.SRecord.SRecordElementFormatter.Options')