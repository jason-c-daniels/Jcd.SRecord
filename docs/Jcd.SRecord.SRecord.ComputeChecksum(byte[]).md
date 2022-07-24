#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecord](Jcd.SRecord.SRecord.md 'Jcd.SRecord.SRecord')

## SRecord.ComputeChecksum(byte[]) Method

Computes the checksum for the concatenated bytes contained in the address  
and data fields.

```csharp
public static byte ComputeChecksum(byte[] countAddressAndDataBytes);
```
#### Parameters

<a name='Jcd.SRecord.SRecord.ComputeChecksum(byte[]).countAddressAndDataBytes'></a>

`countAddressAndDataBytes` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The concatenated list of bytes from the address and data.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The checksum