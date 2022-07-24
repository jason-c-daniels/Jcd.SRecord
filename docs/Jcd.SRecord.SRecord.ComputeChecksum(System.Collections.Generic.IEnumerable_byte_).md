#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecord](Jcd.SRecord.SRecord.md 'Jcd.SRecord.SRecord')

## SRecord.ComputeChecksum(IEnumerable<byte>) Method

Computes the checksum for the concatenated bytes contained in the address  
and data fields.

```csharp
private static byte ComputeChecksum(System.Collections.Generic.IEnumerable<byte> countAddressAndDataBytes);
```
#### Parameters

<a name='Jcd.SRecord.SRecord.ComputeChecksum(System.Collections.Generic.IEnumerable_byte_).countAddressAndDataBytes'></a>

`countAddressAndDataBytes` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The concatenated list of bytes from the address and data.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The checksum