#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordElementParser](Jcd.SRecord.SRecordElementParser.md 'Jcd.SRecord.SRecordElementParser')

## SRecordElementParser(ISRecordDataParser, IEnumerable<char>) Constructor

Constructs an `SRecordElementParser` from an `ISRecordDataParser` and an optional set of comment characters.

```csharp
public SRecordElementParser(Jcd.SRecord.ISRecordDataParser sRecordParser=null, System.Collections.Generic.IEnumerable<char> commentCharacters=null);
```
#### Parameters

<a name='Jcd.SRecord.SRecordElementParser.SRecordElementParser(Jcd.SRecord.ISRecordDataParser,System.Collections.Generic.IEnumerable_char_).sRecordParser'></a>

`sRecordParser` [ISRecordDataParser](Jcd.SRecord.ISRecordDataParser.md 'Jcd.SRecord.ISRecordDataParser')

The ISRecordDataParser instance to use.

<a name='Jcd.SRecord.SRecordElementParser.SRecordElementParser(Jcd.SRecord.ISRecordDataParser,System.Collections.Generic.IEnumerable_char_).commentCharacters'></a>

`commentCharacters` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The comment characters to accept when parsing.