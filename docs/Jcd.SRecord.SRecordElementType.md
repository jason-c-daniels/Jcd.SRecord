#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## SRecordElementType Struct

Defines a set of flags that describe the results of parsing a line  
of text from an `SRecordDocument`

```csharp
public readonly struct SRecordElementType :
System.IEquatable<Jcd.SRecord.SRecordElementType>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[SRecordElementType](Jcd.SRecord.SRecordElementType.md 'Jcd.SRecord.SRecordElementType')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Fields | |
| :--- | :--- |
| [Blank](Jcd.SRecord.SRecordElementType.Blank.md 'Jcd.SRecord.SRecordElementType.Blank') | A blank line (Empty or all whitespace.) |
| [Comment](Jcd.SRecord.SRecordElementType.Comment.md 'Jcd.SRecord.SRecordElementType.Comment') | A single line comment. |
| [Error](Jcd.SRecord.SRecordElementType.Error.md 'Jcd.SRecord.SRecordElementType.Error') | Indicates if some error was detected while parsing the line. |
| [HasComment](Jcd.SRecord.SRecordElementType.HasComment.md 'Jcd.SRecord.SRecordElementType.HasComment') | Indicates that the parsed data contains a comment. (This may be an empty string) |
| [HasError](Jcd.SRecord.SRecordElementType.HasError.md 'Jcd.SRecord.SRecordElementType.HasError') | Indicates that an error occurred during parsing. |
| [HasSRecord](Jcd.SRecord.SRecordElementType.HasSRecord.md 'Jcd.SRecord.SRecordElementType.HasSRecord') | Indicates that the parsed data contains `SRecordData` data. |
| [IsBlank](Jcd.SRecord.SRecordElementType.IsBlank.md 'Jcd.SRecord.SRecordElementType.IsBlank') | Indicates that the parsed line was blank. |
| [SRecord](Jcd.SRecord.SRecordElementType.SRecord.md 'Jcd.SRecord.SRecordElementType.SRecord') | An SRecordData without a comment. |
| [SRecordWithEndOfElementComment](Jcd.SRecord.SRecordElementType.SRecordWithEndOfElementComment.md 'Jcd.SRecord.SRecordElementType.SRecordWithEndOfElementComment') | An SRecordData with end of line comment. |

| Methods | |
| :--- | :--- |
| [Equals(SRecordElementType)](Jcd.SRecord.SRecordElementType.Equals(Jcd.SRecord.SRecordElementType).md 'Jcd.SRecord.SRecordElementType.Equals(Jcd.SRecord.SRecordElementType)') | Compares this instance to another. |
| [Equals(object)](Jcd.SRecord.SRecordElementType.Equals(object).md 'Jcd.SRecord.SRecordElementType.Equals(object)') | Compares this instance to another object. |
| [GetHashCode()](Jcd.SRecord.SRecordElementType.GetHashCode().md 'Jcd.SRecord.SRecordElementType.GetHashCode()') | Generates a hashcode for the instance. |

| Operators | |
| :--- | :--- |
| [operator ==(SRecordElementType, SRecordElementType)](Jcd.SRecord.SRecordElementType.op_Equality(Jcd.SRecord.SRecordElementType,Jcd.SRecord.SRecordElementType).md 'Jcd.SRecord.SRecordElementType.op_Equality(Jcd.SRecord.SRecordElementType, Jcd.SRecord.SRecordElementType)') | Compares two instances of `SRecordElementType` for equality. |
| [operator !=(SRecordElementType, SRecordElementType)](Jcd.SRecord.SRecordElementType.op_Inequality(Jcd.SRecord.SRecordElementType,Jcd.SRecord.SRecordElementType).md 'Jcd.SRecord.SRecordElementType.op_Inequality(Jcd.SRecord.SRecordElementType, Jcd.SRecord.SRecordElementType)') | Compares two instances of `SRecordElementType` for inequality. |
