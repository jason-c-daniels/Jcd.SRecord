### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')

## SRecordType.IsValid Field

Indicates if the type is valid and recognized.

```csharp
public readonly bool IsValid;
```

#### Field Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

### Remarks
This is set by whatever is constructing the type. Usually this will be set  
at compile time. See, `Strict` and `Flexible` for examples.