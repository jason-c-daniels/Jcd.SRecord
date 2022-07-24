#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.Parsers](Jcd.SRecord.Parsers.md 'Jcd.SRecord.Parsers').[SRecordLine](Jcd.SRecord.Parsers.SRecordLine.md 'Jcd.SRecord.Parsers.SRecordLine')

## SRecordLine(int, SRecordLineType, SRecord, string, string, string, Exception) Constructor

Constructs an instance of an `SRecordLine`

```csharp
public SRecordLine(int lineNumber, Jcd.SRecord.IO.SRecordLineType lineType, Jcd.SRecord.SRecord sRecord=null, string comment=null, string originalLine=null, string errorMessage=null, System.Exception exception=null);
```
#### Parameters

<a name='Jcd.SRecord.Parsers.SRecordLine.SRecordLine(int,Jcd.SRecord.IO.SRecordLineType,Jcd.SRecord.SRecord,string,string,string,System.Exception).lineNumber'></a>

`lineNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The line number in the file.

<a name='Jcd.SRecord.Parsers.SRecordLine.SRecordLine(int,Jcd.SRecord.IO.SRecordLineType,Jcd.SRecord.SRecord,string,string,string,System.Exception).lineType'></a>

`lineType` [SRecordLineType](Jcd.SRecord.IO.SRecordLineType.md 'Jcd.SRecord.IO.SRecordLineType')

The lineType of line.

<a name='Jcd.SRecord.Parsers.SRecordLine.SRecordLine(int,Jcd.SRecord.IO.SRecordLineType,Jcd.SRecord.SRecord,string,string,string,System.Exception).sRecord'></a>

`sRecord` [SRecord](Jcd.SRecord.SRecord.md 'Jcd.SRecord.SRecord')

the parsed and validated `SRecord` instance.

<a name='Jcd.SRecord.Parsers.SRecordLine.SRecordLine(int,Jcd.SRecord.IO.SRecordLineType,Jcd.SRecord.SRecord,string,string,string,System.Exception).comment'></a>

`comment` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comment text, without the comment character.

<a name='Jcd.SRecord.Parsers.SRecordLine.SRecordLine(int,Jcd.SRecord.IO.SRecordLineType,Jcd.SRecord.SRecord,string,string,string,System.Exception).originalLine'></a>

`originalLine` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The original full text of the line.

<a name='Jcd.SRecord.Parsers.SRecordLine.SRecordLine(int,Jcd.SRecord.IO.SRecordLineType,Jcd.SRecord.SRecord,string,string,string,System.Exception).errorMessage'></a>

`errorMessage` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

An error message, populated when lineType is false.

<a name='Jcd.SRecord.Parsers.SRecordLine.SRecordLine(int,Jcd.SRecord.IO.SRecordLineType,Jcd.SRecord.SRecord,string,string,string,System.Exception).exception'></a>

`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

An exception that occurred during parsing of the SRecord entry.