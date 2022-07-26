#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordData](Jcd.SRecord.SRecordData.md 'Jcd.SRecord.SRecordData')

## SRecordData(SRecordDataType, uint, byte[]) Constructor

Constructs a mew SRecordData instance.

```csharp
public SRecordData(Jcd.SRecord.SRecordDataType type, uint address, byte[] data=null);
```
#### Parameters

<a name='Jcd.SRecord.SRecordData.SRecordData(Jcd.SRecord.SRecordDataType,uint,byte[]).type'></a>

`type` [SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')

The type descriptor for the SRecordData

<a name='Jcd.SRecord.SRecordData.SRecordData(Jcd.SRecord.SRecordDataType,uint,byte[]).address'></a>

`address` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The data for the address field.

<a name='Jcd.SRecord.SRecordData.SRecordData(Jcd.SRecord.SRecordDataType,uint,byte[]).data'></a>

`data` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The data for the data field, if any.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When various constraints are violated such as too big of an  
address for a given record type. See the specification for details.