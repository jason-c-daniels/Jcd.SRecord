#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[ISRecordElementFormatter](Jcd.SRecord.ISRecordElementFormatter.md 'Jcd.SRecord.ISRecordElementFormatter')

## ISRecordElementFormatter.Format(SRecordElement) Method

Formats an `SRecordElement` as a element of text.

```csharp
string Format(Jcd.SRecord.SRecordElement element);
```
#### Parameters

<a name='Jcd.SRecord.ISRecordElementFormatter.Format(Jcd.SRecord.SRecordElement).element'></a>

`element` [SRecordElement](Jcd.SRecord.SRecordElement.md 'Jcd.SRecord.SRecordElement')

the element to format.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
- Null indicates no element was generated.  
- String.Empty indicates that a blank element was generated.

### Remarks
NOTES:  
            1. `SRecordElementWriter` will discard null results and not emit them to the file/stream.  
            2. Depending on options settings, instances may write blank lines.