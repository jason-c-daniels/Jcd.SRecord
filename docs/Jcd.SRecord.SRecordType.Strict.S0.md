### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType').[Strict](Jcd.SRecord.SRecordType.Strict.md 'Jcd.SRecord.SRecordType.Strict')

## SRecordType.Strict.S0 Field

The identifier for S0 records. Address is 2 bytes, should always be 0. Maximum data bytes allowed 32 bytes.

```csharp
public static readonly SRecordType S0;
```

#### Field Value
[SRecordType](Jcd.SRecord.SRecordType.md 'Jcd.SRecord.SRecordType')

### Remarks
This record contains vendor specific ASCII text comment represented as a series of hex digit pairs.  
There is a spec, seldom conformed to, outlined in the [Ubuntu manpage](https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html 'https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html').