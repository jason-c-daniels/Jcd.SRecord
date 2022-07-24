#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO')

## SRecordElementType Struct

Defines a set of flags that describe the results of parsing a line  
of text from an `SRecordDocument`

```csharp
public struct SRecordElementType :
System.IEquatable<Jcd.SRecord.IO.SRecordElementType>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[SRecordElementType](Jcd.SRecord.IO.SRecordElementType.md 'Jcd.SRecord.IO.SRecordElementType')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Fields | |
| :--- | :--- |
| [Blank](Jcd.SRecord.IO.SRecordElementType.Blank.md 'Jcd.SRecord.IO.SRecordElementType.Blank') | A blank line (Empty or all whitespace.) |
| [Comment](Jcd.SRecord.IO.SRecordElementType.Comment.md 'Jcd.SRecord.IO.SRecordElementType.Comment') | A single line comment. |
| [Error](Jcd.SRecord.IO.SRecordElementType.Error.md 'Jcd.SRecord.IO.SRecordElementType.Error') | Indicates if some error was detected while parsing the line. |
| [HasComment](Jcd.SRecord.IO.SRecordElementType.HasComment.md 'Jcd.SRecord.IO.SRecordElementType.HasComment') | Indicates that the parsed data contains a comment. (This may be an empty string) |
| [HasError](Jcd.SRecord.IO.SRecordElementType.HasError.md 'Jcd.SRecord.IO.SRecordElementType.HasError') | Indicates that an error occurred during parsing. |
| [HasSRecord](Jcd.SRecord.IO.SRecordElementType.HasSRecord.md 'Jcd.SRecord.IO.SRecordElementType.HasSRecord') | Indicates that the parsed data contains `SRecord` data. |
| [IsBlank](Jcd.SRecord.IO.SRecordElementType.IsBlank.md 'Jcd.SRecord.IO.SRecordElementType.IsBlank') | Indicates that the parsed line was blank. |
| [SRecord](Jcd.SRecord.IO.SRecordElementType.SRecord.md 'Jcd.SRecord.IO.SRecordElementType.SRecord') | An SRecord without a comment. |
| [SRecordWithEndOfElementComment](Jcd.SRecord.IO.SRecordElementType.SRecordWithEndOfElementComment.md 'Jcd.SRecord.IO.SRecordElementType.SRecordWithEndOfElementComment') | An SRecord with end of line comment. |

| Methods | |
| :--- | :--- |
| [Equals(SRecordElementType)](Jcd.SRecord.IO.SRecordElementType.Equals(Jcd.SRecord.IO.SRecordElementType).md 'Jcd.SRecord.IO.SRecordElementType.Equals(Jcd.SRecord.IO.SRecordElementType)') | Compares this instance to another. |
| [Equals(object)](Jcd.SRecord.IO.SRecordElementType.Equals(object).md 'Jcd.SRecord.IO.SRecordElementType.Equals(object)') | Compares this instance to another object. |
| [GetHashCode()](Jcd.SRecord.IO.SRecordElementType.GetHashCode().md 'Jcd.SRecord.IO.SRecordElementType.GetHashCode()') | Generates a hashcode for the instance. |

| Operators | |
| :--- | :--- |
| [operator ==(SRecordElementType, SRecordElementType)](Jcd.SRecord.IO.SRecordElementType.op_Equality(Jcd.SRecord.IO.SRecordElementType,Jcd.SRecord.IO.SRecordElementType).md 'Jcd.SRecord.IO.SRecordElementType.op_Equality(Jcd.SRecord.IO.SRecordElementType, Jcd.SRecord.IO.SRecordElementType)') | Compares two instances of `SRecordElementType` for equality. |
| [operator !=(SRecordElementType, SRecordElementType)](Jcd.SRecord.IO.SRecordElementType.op_Inequality(Jcd.SRecord.IO.SRecordElementType,Jcd.SRecord.IO.SRecordElementType).md 'Jcd.SRecord.IO.SRecordElementType.op_Inequality(Jcd.SRecord.IO.SRecordElementType, Jcd.SRecord.IO.SRecordElementType)') | Compares two instances of `SRecordElementType` for inequality. |
