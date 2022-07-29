#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## SRecordDataStatistics Class

Represents summary information about the contents of  
an any collection of SRecordData.

```csharp
public class SRecordDataStatistics
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordDataStatistics

| Properties | |
| :--- | :--- |
| [CounterRecordCount](Jcd.SRecord.SRecordDataStatistics.CounterRecordCount.md 'Jcd.SRecord.SRecordDataStatistics.CounterRecordCount') | The count of all S5 and S6 records. (Ideally 0 or 1!) |
| [DataLengthCounts](Jcd.SRecord.SRecordDataStatistics.DataLengthCounts.md 'Jcd.SRecord.SRecordDataStatistics.DataLengthCounts') | A cache of the number of times a data bearing record |
| [DataRecordCount](Jcd.SRecord.SRecordDataStatistics.DataRecordCount.md 'Jcd.SRecord.SRecordDataStatistics.DataRecordCount') | The count of all S1, S2, and S3 records. |
| [HeaderCount](Jcd.SRecord.SRecordDataStatistics.HeaderCount.md 'Jcd.SRecord.SRecordDataStatistics.HeaderCount') | The same as S0Count, a convenience getter. |
| [MaximumDataLength](Jcd.SRecord.SRecordDataStatistics.MaximumDataLength.md 'Jcd.SRecord.SRecordDataStatistics.MaximumDataLength') | The maximum value of any SRecordData.Data.Length entry<br/>-1 means there are no entries. |
| [S0Count](Jcd.SRecord.SRecordDataStatistics.S0Count.md 'Jcd.SRecord.SRecordDataStatistics.S0Count') | The count of all S0 records. |
| [S1Count](Jcd.SRecord.SRecordDataStatistics.S1Count.md 'Jcd.SRecord.SRecordDataStatistics.S1Count') | The count of all S1 records. |
| [S2Count](Jcd.SRecord.SRecordDataStatistics.S2Count.md 'Jcd.SRecord.SRecordDataStatistics.S2Count') | The count of all S2 records. |
| [S3Count](Jcd.SRecord.SRecordDataStatistics.S3Count.md 'Jcd.SRecord.SRecordDataStatistics.S3Count') | The count of all S3 records. |
| [S4Count](Jcd.SRecord.SRecordDataStatistics.S4Count.md 'Jcd.SRecord.SRecordDataStatistics.S4Count') | The count of all S4 records. |
| [S5Count](Jcd.SRecord.SRecordDataStatistics.S5Count.md 'Jcd.SRecord.SRecordDataStatistics.S5Count') | The count of all S5 records. |
| [S6Count](Jcd.SRecord.SRecordDataStatistics.S6Count.md 'Jcd.SRecord.SRecordDataStatistics.S6Count') | The count of all S6 records. |
| [S7Count](Jcd.SRecord.SRecordDataStatistics.S7Count.md 'Jcd.SRecord.SRecordDataStatistics.S7Count') | The count of all S7 records. |
| [S8Count](Jcd.SRecord.SRecordDataStatistics.S8Count.md 'Jcd.SRecord.SRecordDataStatistics.S8Count') | The count of all S0 records. |
| [S9Count](Jcd.SRecord.SRecordDataStatistics.S9Count.md 'Jcd.SRecord.SRecordDataStatistics.S9Count') | The count of all S0 records. |
| [StartAddressRecordCount](Jcd.SRecord.SRecordDataStatistics.StartAddressRecordCount.md 'Jcd.SRecord.SRecordDataStatistics.StartAddressRecordCount') | The count of all S7, S8 and S9 records. (Ideally only 1!) |
| [TotalSRecordDataCount](Jcd.SRecord.SRecordDataStatistics.TotalSRecordDataCount.md 'Jcd.SRecord.SRecordDataStatistics.TotalSRecordDataCount') | A count of all the SRecord entries these statistics account for. |

| Methods | |
| :--- | :--- |
| [Decrement(SRecordData)](Jcd.SRecord.SRecordDataStatistics.Decrement(Jcd.SRecord.SRecordData).md 'Jcd.SRecord.SRecordDataStatistics.Decrement(Jcd.SRecord.SRecordData)') | Decrements the statistics based on the passed in record. |
| [Increment(SRecordData)](Jcd.SRecord.SRecordDataStatistics.Increment(Jcd.SRecord.SRecordData).md 'Jcd.SRecord.SRecordDataStatistics.Increment(Jcd.SRecord.SRecordData)') | Increments the statistics based on the passed in record. |
| [Reset()](Jcd.SRecord.SRecordDataStatistics.Reset().md 'Jcd.SRecord.SRecordDataStatistics.Reset()') | Resets all properties to 0; |
