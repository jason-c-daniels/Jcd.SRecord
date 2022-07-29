#### [Jcd.SRecord](index.md 'index')
### [Jcd.SRecord](Jcd.SRecord.md 'Jcd.SRecord').[SRecordElementReader](Jcd.SRecord.SRecordElementReader.md 'Jcd.SRecord.SRecordElementReader')

## SRecordElementReader.ReadToEndAsync() Method

Get an enumerable of `SRecordElement`s from the input stream, asynchronously

```csharp
public System.Collections.Generic.IAsyncEnumerable<Jcd.SRecord.SRecordElement> ReadToEndAsync();
```

#### Returns
[System.Collections.Generic.IAsyncEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IAsyncEnumerable-1 'System.Collections.Generic.IAsyncEnumerable`1')[SRecordElement](Jcd.SRecord.SRecordElement.md 'Jcd.SRecord.SRecordElement')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IAsyncEnumerable-1 'System.Collections.Generic.IAsyncEnumerable`1')  
an enumerable of `SRecordElement`s from the input stream

### Remarks
NOTE: This will overflow and depending on if it's used in an unchecked context, may or may not throw an exception if you try to parse more than int.MaxValue lines.