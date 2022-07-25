#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord')

## SRecordDocument Class

Represents an SRecordData document. This is a simple document reader/writer.  
No S37, or other semantics are enforced.

```csharp
public class SRecordDocument
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SRecordDocument

| Constructors | |
| :--- | :--- |
| [SRecordDocument(ISRecordElementParser, ISRecordElementFormatter)](Jcd.SRecord.SRecordDocument.SRecordDocument(Jcd.SRecord.ISRecordElementParser,Jcd.SRecord.ISRecordElementFormatter).md 'Jcd.SRecord.SRecordDocument.SRecordDocument(Jcd.SRecord.ISRecordElementParser, Jcd.SRecord.ISRecordElementFormatter)') | Creates an instance of an `SRecordDocument`. |

| Properties | |
| :--- | :--- |
| [Elements](Jcd.SRecord.SRecordDocument.Elements.md 'Jcd.SRecord.SRecordDocument.Elements') | Gets a mutable collection of `SRecordElement`s contained in this document. |
| [Formatter](Jcd.SRecord.SRecordDocument.Formatter.md 'Jcd.SRecord.SRecordDocument.Formatter') | Gets the instance of the formatter used by this `SRecordDocument`. |
| [Parser](Jcd.SRecord.SRecordDocument.Parser.md 'Jcd.SRecord.SRecordDocument.Parser') | Gets the instance of the parser in use by this `SRecordDocument`. |
| [SRecords](Jcd.SRecord.SRecordDocument.SRecords.md 'Jcd.SRecord.SRecordDocument.SRecords') | Gets an immutable collection of just the SRecordData entries contained in the Elements collection. |

| Methods | |
| :--- | :--- |
| [CreateFromFile(string, ISRecordElementParser, ISRecordElementFormatter)](Jcd.SRecord.SRecordDocument.CreateFromFile(string,Jcd.SRecord.ISRecordElementParser,Jcd.SRecord.ISRecordElementFormatter).md 'Jcd.SRecord.SRecordDocument.CreateFromFile(string, Jcd.SRecord.ISRecordElementParser, Jcd.SRecord.ISRecordElementFormatter)') | Creates a `SRecordDocument` using the provided parser and formatter<br/>Then loads data from the specified file path. |
| [CreateFromFileAsync(string, ISRecordElementParser, ISRecordElementFormatter)](Jcd.SRecord.SRecordDocument.CreateFromFileAsync(string,Jcd.SRecord.ISRecordElementParser,Jcd.SRecord.ISRecordElementFormatter).md 'Jcd.SRecord.SRecordDocument.CreateFromFileAsync(string, Jcd.SRecord.ISRecordElementParser, Jcd.SRecord.ISRecordElementFormatter)') | Creates the `SRecordDocument` using the provided parser and formatter<br/>Then asynchronously loads data from the specified file path. |
| [CreateFromString(string, ISRecordElementParser, ISRecordElementFormatter)](Jcd.SRecord.SRecordDocument.CreateFromString(string,Jcd.SRecord.ISRecordElementParser,Jcd.SRecord.ISRecordElementFormatter).md 'Jcd.SRecord.SRecordDocument.CreateFromString(string, Jcd.SRecord.ISRecordElementParser, Jcd.SRecord.ISRecordElementFormatter)') | Creates a `SRecordDocument` using the provided parser and formatter<br/>Then loads data from the string. |
| [LoadFile(string)](Jcd.SRecord.SRecordDocument.LoadFile(string).md 'Jcd.SRecord.SRecordDocument.LoadFile(string)') | Loads data from the specified file path into the current<br/>`SRecordDocument`. This appends to any existing entries. |
| [LoadFileAsync(string)](Jcd.SRecord.SRecordDocument.LoadFileAsync(string).md 'Jcd.SRecord.SRecordDocument.LoadFileAsync(string)') | Asynchronously loads data from the specified file path into the current<br/>`SRecordDocument`. This appends to any existing entries. |
| [LoadString(string)](Jcd.SRecord.SRecordDocument.LoadString(string).md 'Jcd.SRecord.SRecordDocument.LoadString(string)') | Loads data from the provided string into the current  `SRecordDocument`.<br/>This appends to any existing entries. |
| [Read(SRecordElementReader)](Jcd.SRecord.SRecordDocument.Read(Jcd.SRecord.SRecordElementReader).md 'Jcd.SRecord.SRecordDocument.Read(Jcd.SRecord.SRecordElementReader)') | Reads all of the remaining `SRecordElement` entries <br/>from the `SRecordElementReader` |
| [ReadAsync(SRecordElementReader)](Jcd.SRecord.SRecordDocument.ReadAsync(Jcd.SRecord.SRecordElementReader).md 'Jcd.SRecord.SRecordDocument.ReadAsync(Jcd.SRecord.SRecordElementReader)') | Asynchronously reads all of the remaining `SRecordElement` entries <br/>from the `SRecordElementReader` |
| [ToString()](Jcd.SRecord.SRecordDocument.ToString().md 'Jcd.SRecord.SRecordDocument.ToString()') | Returns a string that represents the current object. |
| [Write(SRecordElementWriter)](Jcd.SRecord.SRecordDocument.Write(Jcd.SRecord.SRecordElementWriter).md 'Jcd.SRecord.SRecordDocument.Write(Jcd.SRecord.SRecordElementWriter)') | Writes all of the `SRecordElement`s in this document to the<br/>`SRecordElementWriter` |
| [WriteAsync(SRecordElementWriter)](Jcd.SRecord.SRecordDocument.WriteAsync(Jcd.SRecord.SRecordElementWriter).md 'Jcd.SRecord.SRecordDocument.WriteAsync(Jcd.SRecord.SRecordElementWriter)') | Asynchronously writes all of the `SRecordElement`s in this document to the<br/>`SRecordElementWriter` |
| [WriteFile(string)](Jcd.SRecord.SRecordDocument.WriteFile(string).md 'Jcd.SRecord.SRecordDocument.WriteFile(string)') | Creates or replaces a file at the specified path and writes<br/>all of the formatted `SRecordElement` data into the file. |
| [WriteFileAsync(string)](Jcd.SRecord.SRecordDocument.WriteFileAsync(string).md 'Jcd.SRecord.SRecordDocument.WriteFileAsync(string)') | Asynchronously creates or replaces a file at the specified path and the<br/>writes all of the formatted `SRecordElement` data into the file. |
