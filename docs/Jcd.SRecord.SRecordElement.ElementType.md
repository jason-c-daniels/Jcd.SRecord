#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordElement](Jcd.SRecord.SRecordElement.md 'Jcd.SRecord.SRecordElement')

## SRecordElement.ElementType Property

True if the line recognized as an SRecordData and/or comment. False otherwise.  
When false, OriginalLine should be populated with the extracted line of text, without end of line character(s).  
Also, ErrorMessage should be populated with the error encountered while trying to parse the line.

```csharp
public Jcd.SRecord.SRecordElementType ElementType { get; }
```

#### Property Value
[SRecordElementType](Jcd.SRecord.SRecordElementType.md 'Jcd.SRecord.SRecordElementType')