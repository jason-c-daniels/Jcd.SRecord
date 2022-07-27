#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordData](Jcd.SRecord.SRecordData.md 'Jcd.SRecord.SRecordData')

## SRecordData(SRecordDataType, uint, Nullable<ReadOnlyMemory<byte>>) Constructor

Constructs a mew SRecordData instance.

```csharp
public SRecordData(Jcd.SRecord.SRecordDataType type, uint address, System.Nullable<System.ReadOnlyMemory<byte>> data);
```
#### Parameters

<a name='Jcd.SRecord.SRecordData.SRecordData(Jcd.SRecord.SRecordDataType,uint,System.Nullable_System.ReadOnlyMemory_byte__).type'></a>

`type` [SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')

The type descriptor for the SRecordData

<a name='Jcd.SRecord.SRecordData.SRecordData(Jcd.SRecord.SRecordDataType,uint,System.Nullable_System.ReadOnlyMemory_byte__).address'></a>

`address` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The data for the address field.

<a name='Jcd.SRecord.SRecordData.SRecordData(Jcd.SRecord.SRecordDataType,uint,System.Nullable_System.ReadOnlyMemory_byte__).data'></a>

`data` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.ReadOnlyMemory&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlyMemory-1 'System.ReadOnlyMemory`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlyMemory-1 'System.ReadOnlyMemory`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The data for the data field, if any.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When various constraints are violated such as too big of an  
address for a given record type. See the specification for details.