#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO').[SRecordElement](Jcd.SRecord.IO.SRecordElement.md 'Jcd.SRecord.IO.SRecordElement')

## SRecordElement(int, SRecordElementType, SRecord, string, string, string, Exception) Constructor

Constructs an instance of an `SRecordElement`

```csharp
public SRecordElement(int lineNumber, Jcd.SRecord.IO.SRecordElementType elementType, Jcd.SRecord.SRecord sRecord=null, string comment=null, string originalLine=null, string errorMessage=null, System.Exception exception=null);
```
#### Parameters

<a name='Jcd.SRecord.IO.SRecordElement.SRecordElement(int,Jcd.SRecord.IO.SRecordElementType,Jcd.SRecord.SRecord,string,string,string,System.Exception).lineNumber'></a>

`lineNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The line number in the file.

<a name='Jcd.SRecord.IO.SRecordElement.SRecordElement(int,Jcd.SRecord.IO.SRecordElementType,Jcd.SRecord.SRecord,string,string,string,System.Exception).elementType'></a>

`elementType` [SRecordElementType](Jcd.SRecord.IO.SRecordElementType.md 'Jcd.SRecord.IO.SRecordElementType')

The elementType of line.

<a name='Jcd.SRecord.IO.SRecordElement.SRecordElement(int,Jcd.SRecord.IO.SRecordElementType,Jcd.SRecord.SRecord,string,string,string,System.Exception).sRecord'></a>

`sRecord` [SRecord](Jcd.SRecord.SRecord.md 'Jcd.SRecord.SRecord')

the parsed and validated `SRecord` instance.

<a name='Jcd.SRecord.IO.SRecordElement.SRecordElement(int,Jcd.SRecord.IO.SRecordElementType,Jcd.SRecord.SRecord,string,string,string,System.Exception).comment'></a>

`comment` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comment text, without the comment character.

<a name='Jcd.SRecord.IO.SRecordElement.SRecordElement(int,Jcd.SRecord.IO.SRecordElementType,Jcd.SRecord.SRecord,string,string,string,System.Exception).originalLine'></a>

`originalLine` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The original full text of the line.

<a name='Jcd.SRecord.IO.SRecordElement.SRecordElement(int,Jcd.SRecord.IO.SRecordElementType,Jcd.SRecord.SRecord,string,string,string,System.Exception).errorMessage'></a>

`errorMessage` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

An error message, populated when elementType is false.

<a name='Jcd.SRecord.IO.SRecordElement.SRecordElement(int,Jcd.SRecord.IO.SRecordElementType,Jcd.SRecord.SRecord,string,string,string,System.Exception).exception'></a>

`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

An exception that occurred during parsing of the SRecord entry.