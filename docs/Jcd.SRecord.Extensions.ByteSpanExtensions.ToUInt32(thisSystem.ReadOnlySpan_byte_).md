#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord.Extensions](Jcd.SRecord.Extensions.md 'Jcd.SRecord.Extensions').[ByteSpanExtensions](Jcd.SRecord.Extensions.ByteSpanExtensions.md 'Jcd.SRecord.Extensions.ByteSpanExtensions')

## ByteSpanExtensions.ToUInt32(this ReadOnlySpan<byte>) Method

Converts a ReadOnlySpan of bytes into a UInt32, regardless of the source number of bytes.  
This is endian independent.

```csharp
public static uint ToUInt32(this System.ReadOnlySpan<byte> bytes);
```
#### Parameters

<a name='Jcd.SRecord.Extensions.ByteSpanExtensions.ToUInt32(thisSystem.ReadOnlySpan_byte_).bytes'></a>

`bytes` [System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')

The source of the bytes.

#### Returns
[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The converted value.