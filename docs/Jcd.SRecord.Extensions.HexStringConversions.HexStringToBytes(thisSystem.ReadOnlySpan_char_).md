#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.Extensions](Jcd.SRecord.Extensions.md 'Jcd.SRecord.Extensions').[HexStringConversions](Jcd.SRecord.Extensions.HexStringConversions.md 'Jcd.SRecord.Extensions.HexStringConversions')

## HexStringConversions.HexStringToBytes(this ReadOnlySpan<char>) Method

Converts a sequence of hexadecimal characters into the equivalent bytes.

```csharp
public static byte[] HexStringToBytes(this System.ReadOnlySpan<char> hexString);
```
#### Parameters

<a name='Jcd.SRecord.Extensions.HexStringConversions.HexStringToBytes(thisSystem.ReadOnlySpan_char_).hexString'></a>

`hexString` [System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')

the text to convert.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The sequence of bytes represented by the hex string.