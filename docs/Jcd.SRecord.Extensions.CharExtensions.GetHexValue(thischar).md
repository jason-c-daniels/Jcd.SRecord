#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.Extensions](Jcd.SRecord.Extensions.md 'Jcd.SRecord.Extensions').[CharExtensions](Jcd.SRecord.Extensions.CharExtensions.md 'Jcd.SRecord.Extensions.CharExtensions')

## CharExtensions.GetHexValue(this char) Method

Gets the value from a hexadecimal digit.

```csharp
public static byte GetHexValue(this char digit);
```
#### Parameters

<a name='Jcd.SRecord.Extensions.CharExtensions.GetHexValue(thischar).digit'></a>

`digit` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The digit to evaluate.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The numeric value.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Thrown if the character isn't actually a hexadecimal digit.