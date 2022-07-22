### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[HexStringConversions](Jcd.SRecord.HexStringConversions.md 'Jcd.SRecord.HexStringConversions')

## HexStringConversions.BytesToHexString(this IEnumerable<byte>, bool) Method

Convert a sequence of bytes into a string of hexadecimal values.

```csharp
public static string BytesToHexString(this System.Collections.Generic.IEnumerable<byte> bytes, bool makeUppercase=true);
```
#### Parameters

<a name='Jcd.SRecord.HexStringConversions.BytesToHexString(thisSystem.Collections.Generic.IEnumerable_byte_,bool).bytes'></a>

`bytes` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

the bytes to convert

<a name='Jcd.SRecord.HexStringConversions.BytesToHexString(thisSystem.Collections.Generic.IEnumerable_byte_,bool).makeUppercase'></a>

`makeUppercase` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

makes the A-F range uppercase when true, lowercase otherwise

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The hexadecimal text representation