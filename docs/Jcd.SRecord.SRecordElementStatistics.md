#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## SRecordElementStatistics Class

Represents a set of statistics about a set of `SRecordElement` instances.

```csharp
public class SRecordElementStatistics
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordElementStatistics

| Properties | |
| :--- | :--- |
| [BlankElementCount](Jcd.SRecord.SRecordElementStatistics.BlankElementCount.md 'Jcd.SRecord.SRecordElementStatistics.BlankElementCount') | The number of elements which were not in error but did not<br/>parse comments or SRecordData |
| [ElementsWithCommentsCount](Jcd.SRecord.SRecordElementStatistics.ElementsWithCommentsCount.md 'Jcd.SRecord.SRecordElementStatistics.ElementsWithCommentsCount') | The total number of elements with comments. |
| [ElementWithSRecordDataCount](Jcd.SRecord.SRecordElementStatistics.ElementWithSRecordDataCount.md 'Jcd.SRecord.SRecordElementStatistics.ElementWithSRecordDataCount') | The total number of elements that contained SRecordData |
| [ErrorElementCount](Jcd.SRecord.SRecordElementStatistics.ErrorElementCount.md 'Jcd.SRecord.SRecordElementStatistics.ErrorElementCount') | The number of elements that were flagged as having an error. |
| [SRecordDataWithCommentCount](Jcd.SRecord.SRecordElementStatistics.SRecordDataWithCommentCount.md 'Jcd.SRecord.SRecordElementStatistics.SRecordDataWithCommentCount') | The number of elements with both SRecordData and comments. |
| [StandAloneCommentCount](Jcd.SRecord.SRecordElementStatistics.StandAloneCommentCount.md 'Jcd.SRecord.SRecordElementStatistics.StandAloneCommentCount') | The number of elements that just had comment data. |
| [TotalElementsCount](Jcd.SRecord.SRecordElementStatistics.TotalElementsCount.md 'Jcd.SRecord.SRecordElementStatistics.TotalElementsCount') | The total number of elements evaluated. |

| Methods | |
| :--- | :--- |
| [Decrement(SRecordElement)](Jcd.SRecord.SRecordElementStatistics.Decrement(Jcd.SRecord.SRecordElement).md 'Jcd.SRecord.SRecordElementStatistics.Decrement(Jcd.SRecord.SRecordElement)') | Decrements the this instance's statistics based on the<br/>passed in element. |
| [Increment(SRecordElement)](Jcd.SRecord.SRecordElementStatistics.Increment(Jcd.SRecord.SRecordElement).md 'Jcd.SRecord.SRecordElementStatistics.Increment(Jcd.SRecord.SRecordElement)') | Increments the this instance's statistics based on the<br/>passed in element. |
| [Reset()](Jcd.SRecord.SRecordElementStatistics.Reset().md 'Jcd.SRecord.SRecordElementStatistics.Reset()') | Sets all datapoints to 0 |
