#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.Extensions](Jcd.SRecord.Extensions.md 'Jcd.SRecord.Extensions').[HexStringConversions](Jcd.SRecord.Extensions.HexStringConversions.md 'Jcd.SRecord.Extensions.HexStringConversions')

## HexStringConversions.BytesToHexString(this ReadOnlySpan<byte>, bool) Method

Convert a sequence of bytes into a string of hexadecimal values.

```csharp
public static string BytesToHexString(this System.ReadOnlySpan<byte> bytes, bool makeUppercase=true);
```
#### Parameters

<a name='Jcd.SRecord.Extensions.HexStringConversions.BytesToHexString(thisSystem.ReadOnlySpan_byte_,bool).bytes'></a>

`bytes` [System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')

the bytes to convert

<a name='Jcd.SRecord.Extensions.HexStringConversions.BytesToHexString(thisSystem.ReadOnlySpan_byte_,bool).makeUppercase'></a>

`makeUppercase` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

makes the A-F range uppercase when true, lowercase otherwise

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The hexadecimal text representation