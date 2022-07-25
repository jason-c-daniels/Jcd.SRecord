#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordElementFormatter](Jcd.SRecord.SRecordElementFormatter.md 'Jcd.SRecord.SRecordElementFormatter')

## SRecordElementFormatter.Format(SRecordElement) Method

Formats an `SRecordElement` as a element of text.

```csharp
public string Format(Jcd.SRecord.SRecordElement element);
```
#### Parameters

<a name='Jcd.SRecord.SRecordElementFormatter.Format(Jcd.SRecord.SRecordElement).element'></a>

`element` [SRecordElement](Jcd.SRecord.SRecordElement.md 'Jcd.SRecord.SRecordElement')

the element to format.

Implements [Format(SRecordElement)](Jcd.SRecord.ISRecordElementFormatter.Format(Jcd.SRecord.SRecordElement).md 'Jcd.SRecord.ISRecordElementFormatter.Format(Jcd.SRecord.SRecordElement)')

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Null indicates no element was generated. String.Empty indicates  
that a blank element was generated. `SRecordElementWriter`  
will discard null results. Depending on options settings, it may write  
blank lines.