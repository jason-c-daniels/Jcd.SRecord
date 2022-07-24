#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElementFormatter](Jcd.SRecord.IO.SRecordElementFormatter.md 'Jcd.SRecord.IO.SRecordElementFormatter')

## SRecordElementFormatter.Format(SRecordElement) Method

Formats an `SRecordElement` as a element of text.

```csharp
public string Format(Jcd.SRecord.IO.SRecordElement element);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordElementFormatter.Format(Jcd.SRecord.IO.SRecordElement).element'></a>

`element` [SRecordElement](Jcd.SRecord.IO.SRecordElement.md 'Jcd.SRecord.IO.SRecordElement')

the element to format.

Implements [Format(SRecordElement)](Jcd.SRecord.IO.ISRecordElementFormatter.Format(Jcd.SRecord.IO.SRecordElement).md 'Jcd.SRecord.IO.ISRecordElementFormatter.Format(Jcd.SRecord.IO.SRecordElement)')

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Null indicates no element was generated. String.Empty indicates  
that a blank element was generated. `SRecordElementWriter`  
will discard null results. Depending on options settings, it may write  
blank lines.