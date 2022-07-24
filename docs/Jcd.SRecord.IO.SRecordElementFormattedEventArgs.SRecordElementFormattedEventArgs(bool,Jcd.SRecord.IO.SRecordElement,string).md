#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElementFormattedEventArgs](Jcd.SRecord.IO.SRecordElementFormattedEventArgs.md 'Jcd.SRecord.IO.SRecordElementFormattedEventArgs')

## SRecordElementFormattedEventArgs(bool, SRecordElement, string) Constructor

Constructs an instance of `SRecordElementFormattedEventArgs`

```csharp
public SRecordElementFormattedEventArgs(bool succeeded, Jcd.SRecord.IO.SRecordElement element, string formattedText=null);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordElementFormattedEventArgs.SRecordElementFormattedEventArgs(bool,Jcd.SRecord.IO.SRecordElement,string).succeeded'></a>

`succeeded` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

A flag indicating if the formatting attempt was successful.

<a name='Jcd.SRecord.IO.SRecordElementFormattedEventArgs.SRecordElementFormattedEventArgs(bool,Jcd.SRecord.IO.SRecordElement,string).element'></a>

`element` [SRecordElement](Jcd.SRecord.IO.SRecordElement.md 'Jcd.SRecord.IO.SRecordElement')

The element that was formatted.

<a name='Jcd.SRecord.IO.SRecordElementFormattedEventArgs.SRecordElementFormattedEventArgs(bool,Jcd.SRecord.IO.SRecordElement,string).formattedText'></a>

`formattedText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The text resulting from formatting.