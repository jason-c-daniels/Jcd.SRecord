### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[FlexibleSRecord](Jcd.SRecord.FlexibleSRecord.md 'Jcd.SRecord.FlexibleSRecord')

## FlexibleSRecord.FromKey(string) Method

Given a key, return an SRecordType instance describing it.  
Invalid keys will return

```csharp
public static Jcd.SRecord.SRecordType FromKey(string key);
```
#### Parameters

<a name='Jcd.SRecord.FlexibleSRecord.FromKey(string).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Returns
[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')  
A matching `SRecordType` or a new instance with IsValid set to false.