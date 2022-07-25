#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordData](Jcd.SRecord.SRecordData.md 'Jcd.SRecord.SRecordData')

## SRecordData.EndAddress Property

The computed address of the last byte of data contained in this record.  
For records with 0 data length, this will contain the same value as Address.

```csharp
public long EndAddress { get; }
```

#### Property Value
[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')