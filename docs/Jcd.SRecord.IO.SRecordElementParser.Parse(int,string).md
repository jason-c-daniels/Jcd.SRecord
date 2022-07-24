#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElementParser](Jcd.SRecord.IO.SRecordElementParser.md 'Jcd.SRecord.IO.SRecordElementParser')

## SRecordElementParser.Parse(int, string) Method

Parses a line of text into an SRecordElement.

```csharp
public Jcd.SRecord.IO.SRecordElement Parse(int lineNumber, string lineOfText);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordElementParser.Parse(int,string).lineNumber'></a>

`lineNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The line number.

<a name='Jcd.SRecord.IO.SRecordElementParser.Parse(int,string).lineOfText'></a>

`lineOfText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The raw text.

Implements [Parse(int, string)](Jcd.SRecord.IO.ISRecordElementParser.Parse(int,string).md 'Jcd.SRecord.IO.ISRecordElementParser.Parse(int, string)')

#### Returns
[SRecordElement](Jcd.SRecord.IO.SRecordElement.md 'Jcd.SRecord.IO.SRecordElement')  
an SRecordElement describing the parsing results.