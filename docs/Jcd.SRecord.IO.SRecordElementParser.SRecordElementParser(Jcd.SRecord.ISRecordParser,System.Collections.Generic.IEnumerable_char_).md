#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElementParser](Jcd.SRecord.IO.SRecordElementParser.md 'Jcd.SRecord.IO.SRecordElementParser')

## SRecordElementParser(ISRecordParser, IEnumerable<char>) Constructor

Constructs an `SRecordElementParser` from an `ISRecordParser`  
and an optional set of comment characters.

```csharp
public SRecordElementParser(Jcd.SRecord.ISRecordParser sRecordParser=null, System.Collections.Generic.IEnumerable<char> commentCharacters=null);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordElementParser.SRecordElementParser(Jcd.SRecord.ISRecordParser,System.Collections.Generic.IEnumerable_char_).sRecordParser'></a>

`sRecordParser` [ISRecordParser](Jcd.SRecord.ISRecordParser.md 'Jcd.SRecord.ISRecordParser')

The ISRecordParser instance to use.

<a name='Jcd.SRecord.IO.SRecordElementParser.SRecordElementParser(Jcd.SRecord.ISRecordParser,System.Collections.Generic.IEnumerable_char_).commentCharacters'></a>

`commentCharacters` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The comment characters to accept when parsing.