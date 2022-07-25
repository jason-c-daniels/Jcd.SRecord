using System;
using System.Linq;
using Jcd.SRecord.Extensions;
using Xunit;

namespace Jcd.SRecord.Tests
{
    public class SRecordDataFormatterTests
    {
        [Fact]
        public void SRecordFormatter_Default_Is_SRecordFormatter_Uppercase()
        {
            Assert.Same(SRecordDataFormatter.UppercaseHex, SRecordDataFormatter.Default);
        }
        
        [Theory]
        [InlineData("S0",0x0000,"68656C6C6F20202020200000", "S00F000068656C6C6F202020202000003C",true)]
        [InlineData("S0",0x0000,"68656C6C6F20202020200000", "S00f000068656c6c6f202020202000003c",false)]
        
        public void Format_Generates_The_Correct_Text(string key,uint address, string hexBytes, string expectedText, bool emitBytesInUppercase)
        {
            var bytes = string.IsNullOrEmpty(hexBytes) ? Array.Empty<byte>() : hexBytes.HexStringToBytes().ToArray();
            var sr = new SRecordData(SRecordDataType.Strict.FromKey(key), address, bytes);
            var formatter = emitBytesInUppercase ? SRecordDataFormatter.UppercaseHex : SRecordDataFormatter.LowercaseHex;
            var result = formatter.Format(sr);
            Assert.Equal(expectedText, result);
        }

    }
}