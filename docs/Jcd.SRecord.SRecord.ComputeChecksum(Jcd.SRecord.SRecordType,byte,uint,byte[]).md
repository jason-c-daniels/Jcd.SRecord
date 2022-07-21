### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecord](Jcd.SRecord.SRecord.md 'Jcd.SRecord.SRecord')

## SRecord.ComputeChecksum(SRecordType, byte, uint, byte[]) Method

Computes the checksum for the record.

```csharp
public static byte ComputeChecksum(Jcd.SRecord.SRecordType type, byte count, uint address, byte[] data=null);
```
#### Parameters

<a name='Jcd.SRecord.SRecord.ComputeChecksum(Jcd.SRecord.SRecordType,byte,uint,byte[]).type'></a>

`type` [SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')

The type descriptor for the record.

<a name='Jcd.SRecord.SRecord.ComputeChecksum(Jcd.SRecord.SRecordType,byte,uint,byte[]).count'></a>

`count` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The count of bytes following

<a name='Jcd.SRecord.SRecord.ComputeChecksum(Jcd.SRecord.SRecordType,byte,uint,byte[]).address'></a>

`address` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The data for the address field.

<a name='Jcd.SRecord.SRecord.ComputeChecksum(Jcd.SRecord.SRecordType,byte,uint,byte[]).data'></a>

`data` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The data for the data field, if any.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The checksum