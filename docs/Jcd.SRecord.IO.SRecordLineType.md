#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO')

## SRecordLineType Struct

```csharp
public struct SRecordLineType :
System.IEquatable<Jcd.SRecord.IO.SRecordLineType>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[SRecordLineType](Jcd.SRecord.IO.SRecordLineType.md 'Jcd.SRecord.IO.SRecordLineType')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Fields | |
| :--- | :--- |
| [Blank](Jcd.SRecord.IO.SRecordLineType.Blank.md 'Jcd.SRecord.IO.SRecordLineType.Blank') | A blank line (Empty or all whitespace.) |
| [Comment](Jcd.SRecord.IO.SRecordLineType.Comment.md 'Jcd.SRecord.IO.SRecordLineType.Comment') | A single line comment. |
| [Error](Jcd.SRecord.IO.SRecordLineType.Error.md 'Jcd.SRecord.IO.SRecordLineType.Error') | Indicates if some error was detected while parsing the line. |
| [SRecord](Jcd.SRecord.IO.SRecordLineType.SRecord.md 'Jcd.SRecord.IO.SRecordLineType.SRecord') | An SRecord without a comment. |
| [SRecordWithEndOfLineComment](Jcd.SRecord.IO.SRecordLineType.SRecordWithEndOfLineComment.md 'Jcd.SRecord.IO.SRecordLineType.SRecordWithEndOfLineComment') | An SRecord with end of line comment. |

| Methods | |
| :--- | :--- |
| [Equals(SRecordLineType)](Jcd.SRecord.IO.SRecordLineType.Equals(Jcd.SRecord.IO.SRecordLineType).md 'Jcd.SRecord.IO.SRecordLineType.Equals(Jcd.SRecord.IO.SRecordLineType)') | Compares this instance to another. |
| [Equals(object)](Jcd.SRecord.IO.SRecordLineType.Equals(object).md 'Jcd.SRecord.IO.SRecordLineType.Equals(object)') | Compares this instance to another object. |
| [GetHashCode()](Jcd.SRecord.IO.SRecordLineType.GetHashCode().md 'Jcd.SRecord.IO.SRecordLineType.GetHashCode()') | Generates a hashcode for the instance. |

| Operators | |
| :--- | :--- |
| [operator ==(SRecordLineType, SRecordLineType)](Jcd.SRecord.IO.SRecordLineType.op_Equality(Jcd.SRecord.IO.SRecordLineType,Jcd.SRecord.IO.SRecordLineType).md 'Jcd.SRecord.IO.SRecordLineType.op_Equality(Jcd.SRecord.IO.SRecordLineType, Jcd.SRecord.IO.SRecordLineType)') | Compares two instances of `SRecordLineType` for equality. |
| [operator !=(SRecordLineType, SRecordLineType)](Jcd.SRecord.IO.SRecordLineType.op_Inequality(Jcd.SRecord.IO.SRecordLineType,Jcd.SRecord.IO.SRecordLineType).md 'Jcd.SRecord.IO.SRecordLineType.op_Inequality(Jcd.SRecord.IO.SRecordLineType, Jcd.SRecord.IO.SRecordLineType)') | Compares two instances of `SRecordLineType` for inequality. |
