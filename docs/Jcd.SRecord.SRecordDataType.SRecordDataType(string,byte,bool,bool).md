#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')

## SRecordDataType(string, byte, bool, bool) Constructor

Constructs an SRecordDataType, which identifies how to properly process and/or parse an SRecordData of the specified type, provided the key, address length.

```csharp
public SRecordDataType(string key, byte addressLengthInBytes, bool requiresSpecialHandling=false, bool isValid=true);
```
#### Parameters

<a name='Jcd.SRecord.SRecordDataType.SRecordDataType(string,byte,bool,bool).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The two character SRecordData identifier. (S0..S9)

<a name='Jcd.SRecord.SRecordDataType.SRecordDataType(string,byte,bool,bool).addressLengthInBytes'></a>

`addressLengthInBytes` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The byte length of the address

<a name='Jcd.SRecord.SRecordDataType.SRecordDataType(string,byte,bool,bool).requiresSpecialHandling'></a>

`requiresSpecialHandling` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Indicates if the type requires special handling. (S4 does)

<a name='Jcd.SRecord.SRecordDataType.SRecordDataType(string,byte,bool,bool).isValid'></a>

`isValid` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Indicates if parsing recognized the key.

### Remarks
- This constructor is only intended to be used by people who will use it correctly.  
- Typically you'll want to use Strict.FromKey or Flexible.FromKey instead.  
- The maximum data length is computed from the following formula:  
-- MaximumDataBytesAllowed = SRecordData.MaxValueForCount - SRecordData.CheckSumByteLength - addressLengthInBytes;