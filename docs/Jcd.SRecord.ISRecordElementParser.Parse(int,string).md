#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[ISRecordElementParser](Jcd.SRecord.ISRecordElementParser.md 'Jcd.SRecord.ISRecordElementParser')

## ISRecordElementParser.Parse(int, string) Method

Parses a line of text into an SRecordElement.

```csharp
Jcd.SRecord.SRecordElement Parse(int lineNumber, string lineOfText);
```
#### Parameters

<a name='Jcd.SRecord.ISRecordElementParser.Parse(int,string).lineNumber'></a>

`lineNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The line number.

<a name='Jcd.SRecord.ISRecordElementParser.Parse(int,string).lineOfText'></a>

`lineOfText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The raw text.

#### Returns
[SRecordElement](Jcd.SRecord.SRecordElement.md 'Jcd.SRecord.SRecordElement')  
an SRecordElement describing the parsing results.