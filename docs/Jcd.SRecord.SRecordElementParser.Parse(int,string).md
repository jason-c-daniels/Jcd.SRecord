#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordElementParser](Jcd.SRecord.SRecordElementParser.md 'Jcd.SRecord.SRecordElementParser')

## SRecordElementParser.Parse(int, string) Method

Parses a line of text into an SRecordElement.

```csharp
public Jcd.SRecord.SRecordElement Parse(int lineNumber, string lineOfText);
```
#### Parameters

<a name='Jcd.SRecord.SRecordElementParser.Parse(int,string).lineNumber'></a>

`lineNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The line number.

<a name='Jcd.SRecord.SRecordElementParser.Parse(int,string).lineOfText'></a>

`lineOfText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The raw text.

Implements [Parse(int, string)](Jcd.SRecord.ISRecordElementParser.Parse(int,string).md 'Jcd.SRecord.ISRecordElementParser.Parse(int, string)')

#### Returns
[SRecordElement](Jcd.SRecord.SRecordElement.md 'Jcd.SRecord.SRecordElement')  
an SRecordElement describing the parsing results.