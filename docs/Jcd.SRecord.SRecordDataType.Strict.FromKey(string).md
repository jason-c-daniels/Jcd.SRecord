#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType').[Strict](Jcd.SRecord.SRecordDataType.Strict.md 'Jcd.SRecord.SRecordDataType.Strict')

## SRecordDataType.Strict.FromKey(string) Method

Given a key, return an SRecordDataType instance describing it.  
Invalid keys will return

```csharp
public static Jcd.SRecord.SRecordDataType FromKey(string key);
```
#### Parameters

<a name='Jcd.SRecord.SRecordDataType.Strict.FromKey(string).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Returns
[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')  
A matching `SRecordDataType` or a new instance with IsValid set to false.