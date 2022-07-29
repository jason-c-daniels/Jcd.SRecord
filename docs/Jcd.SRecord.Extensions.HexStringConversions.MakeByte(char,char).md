#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.Extensions](Jcd.SRecord.Extensions.md 'Jcd.SRecord.Extensions').[HexStringConversions](Jcd.SRecord.Extensions.HexStringConversions.md 'Jcd.SRecord.Extensions.HexStringConversions')

## HexStringConversions.MakeByte(char, char) Method

Given a pair of hexadecimal values encoded as chars, convert them into the single byte equivalent.

```csharp
public static byte MakeByte(char highNybble, char lowNybble);
```
#### Parameters

<a name='Jcd.SRecord.Extensions.HexStringConversions.MakeByte(char,char).highNybble'></a>

`highNybble` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

the high nybble (leftmost digit)

<a name='Jcd.SRecord.Extensions.HexStringConversions.MakeByte(char,char).lowNybble'></a>

`lowNybble` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

the low nybble (rightmost digit)

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The converted value.