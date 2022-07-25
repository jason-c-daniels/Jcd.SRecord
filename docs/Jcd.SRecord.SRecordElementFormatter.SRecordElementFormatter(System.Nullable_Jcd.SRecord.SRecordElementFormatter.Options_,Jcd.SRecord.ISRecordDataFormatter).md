#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordElementFormatter](Jcd.SRecord.SRecordElementFormatter.md 'Jcd.SRecord.SRecordElementFormatter')

## SRecordElementFormatter(Nullable<Options>, ISRecordDataFormatter) Constructor

Constructs an instance of `SRecordElementFormatter` with the specified  
options and `ISRecordDataFormatter`.

```csharp
public SRecordElementFormatter(System.Nullable<Jcd.SRecord.SRecordElementFormatter.Options> options=null, Jcd.SRecord.ISRecordDataFormatter recordFormatter=null);
```
#### Parameters

<a name='Jcd.SRecord.SRecordElementFormatter.SRecordElementFormatter(System.Nullable_Jcd.SRecord.SRecordElementFormatter.Options_,Jcd.SRecord.ISRecordDataFormatter).options'></a>

`options` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[Options](Jcd.SRecord.SRecordElementFormatter.Options.md 'Jcd.SRecord.SRecordElementFormatter.Options')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The options to use, if null, `Options.DefaultOptions` is used.

<a name='Jcd.SRecord.SRecordElementFormatter.SRecordElementFormatter(System.Nullable_Jcd.SRecord.SRecordElementFormatter.Options_,Jcd.SRecord.ISRecordDataFormatter).recordFormatter'></a>

`recordFormatter` [ISRecordDataFormatter](Jcd.SRecord.ISRecordDataFormatter.md 'Jcd.SRecord.ISRecordDataFormatter')

The ISRecordDataFormatter to use. If null, `SRecordDataFormatter.UppercaseHex` is used.