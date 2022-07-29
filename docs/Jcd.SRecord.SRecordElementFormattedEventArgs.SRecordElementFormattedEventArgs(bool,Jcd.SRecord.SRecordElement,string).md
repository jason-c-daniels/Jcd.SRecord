#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordElementFormattedEventArgs](Jcd.SRecord.SRecordElementFormattedEventArgs.md 'Jcd.SRecord.SRecordElementFormattedEventArgs')

## SRecordElementFormattedEventArgs(bool, SRecordElement, string) Constructor

Constructs an instance of `SRecordElementFormattedEventArgs`

```csharp
public SRecordElementFormattedEventArgs(bool succeeded, Jcd.SRecord.SRecordElement element, string formattedText=null);
```
#### Parameters

<a name='Jcd.SRecord.SRecordElementFormattedEventArgs.SRecordElementFormattedEventArgs(bool,Jcd.SRecord.SRecordElement,string).succeeded'></a>

`succeeded` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

A flag indicating if the formatting attempt was successful.

<a name='Jcd.SRecord.SRecordElementFormattedEventArgs.SRecordElementFormattedEventArgs(bool,Jcd.SRecord.SRecordElement,string).element'></a>

`element` [SRecordElement](Jcd.SRecord.SRecordElement.md 'Jcd.SRecord.SRecordElement')

The element that was formatted.

<a name='Jcd.SRecord.SRecordElementFormattedEventArgs.SRecordElementFormattedEventArgs(bool,Jcd.SRecord.SRecordElement,string).formattedText'></a>

`formattedText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The text resulting from formatting.