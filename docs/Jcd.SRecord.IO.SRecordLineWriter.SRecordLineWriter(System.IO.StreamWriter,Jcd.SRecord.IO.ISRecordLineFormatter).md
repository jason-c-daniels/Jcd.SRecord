#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordLineWriter](Jcd.SRecord.IO.SRecordLineWriter.md 'Jcd.SRecord.IO.SRecordLineWriter')

## SRecordLineWriter(StreamWriter, ISRecordLineFormatter) Constructor

Constructs an instance from a `StreamWriter` and an `ISRecordLineFormatter`

```csharp
public SRecordLineWriter(System.IO.StreamWriter streamWriter, Jcd.SRecord.IO.ISRecordLineFormatter lineFormatter);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordLineWriter.SRecordLineWriter(System.IO.StreamWriter,Jcd.SRecord.IO.ISRecordLineFormatter).streamWriter'></a>

`streamWriter` [System.IO.StreamWriter](https://docs.microsoft.com/en-us/dotnet/api/System.IO.StreamWriter 'System.IO.StreamWriter')

The StreamWriter

<a name='Jcd.SRecord.IO.SRecordLineWriter.SRecordLineWriter(System.IO.StreamWriter,Jcd.SRecord.IO.ISRecordLineFormatter).lineFormatter'></a>

`lineFormatter` [ISRecordLineFormatter](Jcd.SRecord.IO.ISRecordLineFormatter.md 'Jcd.SRecord.IO.ISRecordLineFormatter')

The line formatter

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Thrown when either parameter is null.