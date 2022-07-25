#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordElementWriter](Jcd.SRecord.SRecordElementWriter.md 'Jcd.SRecord.SRecordElementWriter')

## SRecordElementWriter(TextWriter, ISRecordElementFormatter) Constructor

Constructs an instance from a `StreamWriter` and an `ISRecordElementFormatter`

```csharp
public SRecordElementWriter(System.IO.TextWriter streamWriter, Jcd.SRecord.ISRecordElementFormatter elementFormatter);
```
#### Parameters

<a name='Jcd.SRecord.SRecordElementWriter.SRecordElementWriter(System.IO.TextWriter,Jcd.SRecord.ISRecordElementFormatter).streamWriter'></a>

`streamWriter` [System.IO.TextWriter](https://docs.microsoft.com/en-us/dotnet/api/System.IO.TextWriter 'System.IO.TextWriter')

The StreamWriter

<a name='Jcd.SRecord.SRecordElementWriter.SRecordElementWriter(System.IO.TextWriter,Jcd.SRecord.ISRecordElementFormatter).elementFormatter'></a>

`elementFormatter` [ISRecordElementFormatter](Jcd.SRecord.ISRecordElementFormatter.md 'Jcd.SRecord.ISRecordElementFormatter')

The element formatter

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Thrown when either parameter is null.