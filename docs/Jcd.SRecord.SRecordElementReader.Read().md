#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordElementReader](Jcd.SRecord.SRecordElementReader.md 'Jcd.SRecord.SRecordElementReader')

## SRecordElementReader.Read() Method

Reads an `SRecordElement` from the stream.

```csharp
public Jcd.SRecord.SRecordElement Read();
```

#### Returns
[SRecordElement](Jcd.SRecord.SRecordElement.md 'Jcd.SRecord.SRecordElement')  
The `SRecordElement`, null if end of stream has been reached.

### Remarks
NOTE: This will overflow and depending on if it's used in an unchecked context, may or may not throw an exception if you try to parse more than int.MaxValue lines.