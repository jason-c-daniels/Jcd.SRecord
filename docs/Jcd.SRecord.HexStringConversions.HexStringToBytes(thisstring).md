### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[HexStringConversions](Jcd.SRecord.HexStringConversions.md 'Jcd.SRecord.HexStringConversions')

## HexStringConversions.HexStringToBytes(this string) Method

Converts a sequence of hexadecimal characters into the equivalent bytes.

```csharp
public static System.Collections.Generic.IEnumerable<byte> HexStringToBytes(this string hexString);
```
#### Parameters

<a name='Jcd.SRecord.HexStringConversions.HexStringToBytes(thisstring).hexString'></a>

`hexString` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the text to convert.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The sequence of bytes represented by the hex string.