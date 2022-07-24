#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.Extensions](Jcd.SRecord.Extensions.md 'Jcd.SRecord.Extensions').[CharExtensions](Jcd.SRecord.Extensions.CharExtensions.md 'Jcd.SRecord.Extensions.CharExtensions')

## CharExtensions.ThrowArgumentExceptionIfNotValidForSRecordComment(this char) Method

Throws an ArgumentException if the character can't be used for an SRecord comment.

```csharp
public static void ThrowArgumentExceptionIfNotValidForSRecordComment(this char character);
```
#### Parameters

<a name='Jcd.SRecord.Extensions.CharExtensions.ThrowArgumentExceptionIfNotValidForSRecordComment(thischar).character'></a>

`character` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

the character to check.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Thrown if the character is invalid.