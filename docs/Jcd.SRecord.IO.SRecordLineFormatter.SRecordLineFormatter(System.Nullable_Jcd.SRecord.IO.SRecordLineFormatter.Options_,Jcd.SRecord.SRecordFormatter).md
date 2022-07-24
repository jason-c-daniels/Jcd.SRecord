#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordLineFormatter](Jcd.SRecord.IO.SRecordLineFormatter.md 'Jcd.SRecord.IO.SRecordLineFormatter')

## SRecordLineFormatter(Nullable<Options>, SRecordFormatter) Constructor

Constructs an instance of `SRecordLineFormatter` with the specified  
options and SRecordFormatter.

```csharp
public SRecordLineFormatter(System.Nullable<Jcd.SRecord.IO.SRecordLineFormatter.Options> options=null, Jcd.SRecord.SRecordFormatter sRecordFormatter=null);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordLineFormatter.SRecordLineFormatter(System.Nullable_Jcd.SRecord.IO.SRecordLineFormatter.Options_,Jcd.SRecord.SRecordFormatter).options'></a>

`options` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[Options](Jcd.SRecord.IO.SRecordLineFormatter.Options.md 'Jcd.SRecord.IO.SRecordLineFormatter.Options')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The options to use, if null, `Options.DefaultOptions` is used.

<a name='Jcd.SRecord.IO.SRecordLineFormatter.SRecordLineFormatter(System.Nullable_Jcd.SRecord.IO.SRecordLineFormatter.Options_,Jcd.SRecord.SRecordFormatter).sRecordFormatter'></a>

`sRecordFormatter` [SRecordFormatter](Jcd.SRecord.SRecordFormatter.md 'Jcd.SRecord.SRecordFormatter')

The SRecordFormatter to use. If null, `SRecordFormatter.UppercaseHex` is used.