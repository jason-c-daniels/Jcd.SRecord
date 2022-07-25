#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType').[Flexible](Jcd.SRecord.SRecordDataType.Flexible.md 'Jcd.SRecord.SRecordDataType.Flexible')

## SRecordDataType.Flexible.S0 Field

The identifier for S0 records. Address is 2 bytes, should always be 0. Maximum data bytes allowed 252 bytes.

```csharp
public static readonly SRecordDataType S0;
```

#### Field Value
[SRecordDataType](Jcd.SRecord.SRecordDataType.md 'Jcd.SRecord.SRecordDataType')

### Remarks
This record contains vendor specific ASCII text comment represented as a series of hex digit pairs.  
There is a spec, seldom conformed to, outlined in the [Ubuntu manpage](https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html 'https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html').