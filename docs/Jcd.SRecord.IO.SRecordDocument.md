#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.IO](Jcd.SRecord.IO.md 'Jcd.SRecord.IO')

## SRecordDocument Class

Represents an SRecord document. This is a simple document reader/writer.  
No S37, or other semantics are enforced.

```csharp
public class SRecordDocument
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordDocument

| Constructors | |
| :--- | :--- |
| [SRecordDocument(ISRecordElementParser, ISRecordElementFormatter)](Jcd.SRecord.IO.SRecordDocument.SRecordDocument(Jcd.SRecord.IO.ISRecordElementParser,Jcd.SRecord.IO.ISRecordElementFormatter).md 'Jcd.SRecord.IO.SRecordDocument.SRecordDocument(Jcd.SRecord.IO.ISRecordElementParser, Jcd.SRecord.IO.ISRecordElementFormatter)') | Creates an instance of an `SRecordDocument`. |

| Properties | |
| :--- | :--- |
| [Elements](Jcd.SRecord.IO.SRecordDocument.Elements.md 'Jcd.SRecord.IO.SRecordDocument.Elements') | Gets a mutable collection of `SRecordElement`s contained in this document. |
| [Formatter](Jcd.SRecord.IO.SRecordDocument.Formatter.md 'Jcd.SRecord.IO.SRecordDocument.Formatter') | Gets the instance of the formatter used by this `SRecordDocument`. |
| [Parser](Jcd.SRecord.IO.SRecordDocument.Parser.md 'Jcd.SRecord.IO.SRecordDocument.Parser') | Gets the instance of the parser in use by this `SRecordDocument`. |
| [SRecords](Jcd.SRecord.IO.SRecordDocument.SRecords.md 'Jcd.SRecord.IO.SRecordDocument.SRecords') | Gets an immutable collection of just the SRecord entries contained in the Elements collection. |

| Methods | |
| :--- | :--- |
| [CreateFromFile(string, ISRecordElementParser, ISRecordElementFormatter)](Jcd.SRecord.IO.SRecordDocument.CreateFromFile(string,Jcd.SRecord.IO.ISRecordElementParser,Jcd.SRecord.IO.ISRecordElementFormatter).md 'Jcd.SRecord.IO.SRecordDocument.CreateFromFile(string, Jcd.SRecord.IO.ISRecordElementParser, Jcd.SRecord.IO.ISRecordElementFormatter)') | Creates a `SRecordDocument` using the provided parser and formatter<br/>Then loads data from the specified file path. |
| [CreateFromFileAsync(string, ISRecordElementParser, ISRecordElementFormatter)](Jcd.SRecord.IO.SRecordDocument.CreateFromFileAsync(string,Jcd.SRecord.IO.ISRecordElementParser,Jcd.SRecord.IO.ISRecordElementFormatter).md 'Jcd.SRecord.IO.SRecordDocument.CreateFromFileAsync(string, Jcd.SRecord.IO.ISRecordElementParser, Jcd.SRecord.IO.ISRecordElementFormatter)') | Creates the `SRecordDocument` using the provided parser and formatter<br/>Then asynchronously loads data from the specified file path. |
| [CreateFromString(string, ISRecordElementParser, ISRecordElementFormatter)](Jcd.SRecord.IO.SRecordDocument.CreateFromString(string,Jcd.SRecord.IO.ISRecordElementParser,Jcd.SRecord.IO.ISRecordElementFormatter).md 'Jcd.SRecord.IO.SRecordDocument.CreateFromString(string, Jcd.SRecord.IO.ISRecordElementParser, Jcd.SRecord.IO.ISRecordElementFormatter)') | Creates a `SRecordDocument` using the provided parser and formatter<br/>Then loads data from the string. |
| [LoadFile(string)](Jcd.SRecord.IO.SRecordDocument.LoadFile(string).md 'Jcd.SRecord.IO.SRecordDocument.LoadFile(string)') | Loads data from the specified file path into the current<br/>`SRecordDocument`. This appends to any existing entries. |
| [LoadFileAsync(string)](Jcd.SRecord.IO.SRecordDocument.LoadFileAsync(string).md 'Jcd.SRecord.IO.SRecordDocument.LoadFileAsync(string)') | Asynchronously loads data from the specified file path into the current<br/>`SRecordDocument`. This appends to any existing entries. |
| [LoadString(string)](Jcd.SRecord.IO.SRecordDocument.LoadString(string).md 'Jcd.SRecord.IO.SRecordDocument.LoadString(string)') | Loads data from the provided string into the current  `SRecordDocument`.<br/>This appends to any existing entries. |
| [Read(SRecordElementReader)](Jcd.SRecord.IO.SRecordDocument.Read(Jcd.SRecord.IO.SRecordElementReader).md 'Jcd.SRecord.IO.SRecordDocument.Read(Jcd.SRecord.IO.SRecordElementReader)') | Reads all of the remaining `SRecordElement` entries <br/>from the `SRecordElementReader` |
| [ReadAsync(SRecordElementReader)](Jcd.SRecord.IO.SRecordDocument.ReadAsync(Jcd.SRecord.IO.SRecordElementReader).md 'Jcd.SRecord.IO.SRecordDocument.ReadAsync(Jcd.SRecord.IO.SRecordElementReader)') | Asynchronously reads all of the remaining `SRecordElement` entries <br/>from the `SRecordElementReader` |
| [ToString()](Jcd.SRecord.IO.SRecordDocument.ToString().md 'Jcd.SRecord.IO.SRecordDocument.ToString()') | Returns a string that represents the current object. |
| [Write(SRecordElementWriter)](Jcd.SRecord.IO.SRecordDocument.Write(Jcd.SRecord.IO.SRecordElementWriter).md 'Jcd.SRecord.IO.SRecordDocument.Write(Jcd.SRecord.IO.SRecordElementWriter)') | Writes all of the `SRecordElement`s in this document to the<br/>`SRecordElementWriter` |
| [WriteAsync(SRecordElementWriter)](Jcd.SRecord.IO.SRecordDocument.WriteAsync(Jcd.SRecord.IO.SRecordElementWriter).md 'Jcd.SRecord.IO.SRecordDocument.WriteAsync(Jcd.SRecord.IO.SRecordElementWriter)') | Asynchronously writes all of the `SRecordElement`s in this document to the<br/>`SRecordElementWriter` |
| [WriteFile(string)](Jcd.SRecord.IO.SRecordDocument.WriteFile(string).md 'Jcd.SRecord.IO.SRecordDocument.WriteFile(string)') | Creates or replaces a file at the specified path and writes<br/>all of the formatted `SRecordElement` data into the file. |
| [WriteFileAsync(string)](Jcd.SRecord.IO.SRecordDocument.WriteFileAsync(string).md 'Jcd.SRecord.IO.SRecordDocument.WriteFileAsync(string)') | Asynchronously creates or replaces a file at the specified path and the<br/>writes all of the formatted `SRecordElement` data into the file. |
