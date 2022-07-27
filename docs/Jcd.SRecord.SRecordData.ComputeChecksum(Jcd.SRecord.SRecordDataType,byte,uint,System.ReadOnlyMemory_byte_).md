#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordData](Jcd.SRecord.SRecordData.md 'Jcd.SRecord.SRecordData')

## SRecordData.ComputeChecksum(SRecordDataType, byte, uint, ReadOnlyMemory<byte>) Method

Computes the checksum for the record.

```csharp
private static byte ComputeChecksum(Jcd.SRecord.SRecordDataType type, byte count, uint address, System.ReadOnlyMemory<byte> data);
```
#### Parameters

<a name='Jcd.SRecord.SRecordData.ComputeChecksum(Jcd.SRecord.SRecordDataType,byte,uint,System.ReadOnlyMemory_byte_).type'></a>

`type` [SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')

The type descriptor for the record.

<a name='Jcd.SRecord.SRecordData.ComputeChecksum(Jcd.SRecord.SRecordDataType,byte,uint,System.ReadOnlyMemory_byte_).count'></a>

`count` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The count of bytes following

<a name='Jcd.SRecord.SRecordData.ComputeChecksum(Jcd.SRecord.SRecordDataType,byte,uint,System.ReadOnlyMemory_byte_).address'></a>

`address` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The data for the address field.

<a name='Jcd.SRecord.SRecordData.ComputeChecksum(Jcd.SRecord.SRecordDataType,byte,uint,System.ReadOnlyMemory_byte_).data'></a>

`data` [System.ReadOnlyMemory&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlyMemory-1 'System.ReadOnlyMemory`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlyMemory-1 'System.ReadOnlyMemory`1')

The data for the data field, if any.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The checksum