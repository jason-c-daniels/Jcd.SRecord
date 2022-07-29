#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.Extensions](Jcd.SRecord.Extensions.md 'Jcd.SRecord.Extensions').[HexStringConversions](Jcd.SRecord.Extensions.HexStringConversions.md 'Jcd.SRecord.Extensions.HexStringConversions')

## HexStringConversions.HexStringToBytes(this string) Method

Converts a sequence of hexadecimal characters into the equivalent bytes.

```csharp
public static byte[] HexStringToBytes(this string hexString);
```
#### Parameters

<a name='Jcd.SRecord.Extensions.HexStringConversions.HexStringToBytes(thisstring).hexString'></a>

`hexString` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the text to convert.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The sequence of bytes represented by the hex string.