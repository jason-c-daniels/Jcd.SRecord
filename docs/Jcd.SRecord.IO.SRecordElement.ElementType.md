#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElement](Jcd.SRecord.IO.SRecordElement.md 'Jcd.SRecord.IO.SRecordElement')

## SRecordElement.ElementType Property

True if the line recognized as an SRecord and/or comment. False otherwise.  
When false, OriginalLine should be populated with the extracted line of text, without end of line character(s).  
Also, ErrorMessage should be populated with the error encountered while trying to parse the line.

```csharp
public Jcd.SRecord.IO.SRecordElementType ElementType { get; }
```

#### Property Value
[SRecordElementType](Jcd.SRecord.IO.SRecordElementType.md 'Jcd.SRecord.IO.SRecordElementType')