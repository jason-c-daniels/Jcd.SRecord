#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElementWriter](Jcd.SRecord.IO.SRecordElementWriter.md 'Jcd.SRecord.IO.SRecordElementWriter')

## SRecordElementWriter(TextWriter, ISRecordElementFormatter) Constructor

Constructs an instance from a `StreamWriter` and an `ISRecordElementFormatter`

```csharp
public SRecordElementWriter(System.IO.TextWriter streamWriter, Jcd.SRecord.IO.ISRecordElementFormatter elementFormatter);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordElementWriter.SRecordElementWriter(System.IO.TextWriter,Jcd.SRecord.IO.ISRecordElementFormatter).streamWriter'></a>

`streamWriter` [System.IO.TextWriter](https://docs.microsoft.com/en-us/dotnet/api/System.IO.TextWriter 'System.IO.TextWriter')

The StreamWriter

<a name='Jcd.SRecord.IO.SRecordElementWriter.SRecordElementWriter(System.IO.TextWriter,Jcd.SRecord.IO.ISRecordElementFormatter).elementFormatter'></a>

`elementFormatter` [ISRecordElementFormatter](Jcd.SRecord.IO.ISRecordElementFormatter.md 'Jcd.SRecord.IO.ISRecordElementFormatter')

The element formatter

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Thrown when either parameter is null.