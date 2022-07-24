#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElementReader](Jcd.SRecord.IO.SRecordElementReader.md 'Jcd.SRecord.IO.SRecordElementReader')

## SRecordElementReader.CurrentLine Property

The line number of the most recently read line.  
This is 0 if nothing has been read and number of the last line in the file,  
if all lines have been read.

```csharp
public int CurrentLine { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')