#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElementFormatter](Jcd.SRecord.IO.SRecordElementFormatter.md 'Jcd.SRecord.IO.SRecordElementFormatter')

## SRecordElementFormatter(Nullable<Options>, ISRecordFormatter) Constructor

Constructs an instance of `SRecordElementFormatter` with the specified  
options and `ISRecordFormatter`.

```csharp
public SRecordElementFormatter(System.Nullable<Jcd.SRecord.IO.SRecordElementFormatter.Options> options=null, Jcd.SRecord.ISRecordFormatter recordFormatter=null);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordElementFormatter.SRecordElementFormatter(System.Nullable_Jcd.SRecord.IO.SRecordElementFormatter.Options_,Jcd.SRecord.ISRecordFormatter).options'></a>

`options` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[Options](Jcd.SRecord.IO.SRecordElementFormatter.Options.md 'Jcd.SRecord.IO.SRecordElementFormatter.Options')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The options to use, if null, `Options.DefaultOptions` is used.

<a name='Jcd.SRecord.IO.SRecordElementFormatter.SRecordElementFormatter(System.Nullable_Jcd.SRecord.IO.SRecordElementFormatter.Options_,Jcd.SRecord.ISRecordFormatter).recordFormatter'></a>

`recordFormatter` [ISRecordFormatter](Jcd.SRecord.ISRecordFormatter.md 'Jcd.SRecord.ISRecordFormatter')

The ISRecordFormatter to use. If null, `SRecordFormatter.UppercaseHex` is used.