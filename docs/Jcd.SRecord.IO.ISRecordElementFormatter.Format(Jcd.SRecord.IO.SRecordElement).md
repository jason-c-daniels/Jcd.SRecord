#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[ISRecordElementFormatter](Jcd.SRecord.IO.ISRecordElementFormatter.md 'Jcd.SRecord.IO.ISRecordElementFormatter')

## ISRecordElementFormatter.Format(SRecordElement) Method

Formats an `SRecordElement` as a element of text.

```csharp
string Format(Jcd.SRecord.IO.SRecordElement element);
```
#### Parameters

<a name='Jcd.SRecord.IO.ISRecordElementFormatter.Format(Jcd.SRecord.IO.SRecordElement).element'></a>

`element` [SRecordElement](Jcd.SRecord.IO.SRecordElement.md 'Jcd.SRecord.IO.SRecordElement')

the element to format.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Null indicates no element was generated. String.Empty indicates  
that a blank element was generated. `SRecordElementWriter`  
will discard null results. Depending on options settings, it may write  
blank lines.