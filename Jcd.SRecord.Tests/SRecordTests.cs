using System;
using System.Linq;
using Xunit;

namespace Jcd.SRecord.Tests
{
    public class SRecordTests
    {
        [Theory]
        [InlineData("S0")]
        [InlineData("S1")]
        [InlineData("S2")]
        [InlineData("S3")]
        [InlineData("S4")]
        [InlineData("S5")]
        [InlineData("S6")]
        [InlineData("S7")]
        [InlineData("S8")]
        [InlineData("S9")]
        public void Constructor_Throws_When_Given_Too_Much_Data(string key)
        {
            var type = SRecordType.Strict.FromKey(key);
            Assert.Throws<ArgumentException>(()=> new SRecord(type, 0x0001, new byte[type.MaximumDataBytesAllowed + 1]));
        }

        [Theory]
        [InlineData("S0",0x0F,0x0000,"68656C6C6F20202020200000",0x3C)]
        [InlineData("S1",0x1F,0x0000,"7C0802A6900100049421FFF07C6C1B787C8C23783C60000038630000",0x26)]
        [InlineData("S1",0x1F,0x001C,"4BFFFFE5398000007D83637880010014382100107C0803A64E800020",0xE9)]
        [InlineData("S1",0x11,0x0038,"48656C6C6F20776F726C642E0A00",0x42)]
        [InlineData("S5",0x03,0x0003,null,0xF9)]
        [InlineData("S9",0x03,0x0000,null,0xFC)]
        [InlineData("S5",0x03,0x0003,"",0xF9)]
        [InlineData("S9",0x03,0x0000,"",0xFC)]
        
        public void Constructor_Correctly_Populates_All_Fields(string key, byte count, uint address, string hexBytes, byte checksum)
        {
            var bytes = string.IsNullOrEmpty(hexBytes) ? Array.Empty<byte>() : hexBytes.HexStringToBytes().ToArray();
            var sr = new SRecord(SRecordType.Strict.FromKey(key), address, bytes);
            Assert.Equal(key,sr.Type.Key);
            Assert.Equal(count,sr.CountOfRemainingBytes);
            Assert.Equal(address,sr.Address);
            Assert.Equal(bytes,sr.Data.ToArray());
            Assert.Equal(checksum,sr.Checksum);            
        }
    }
}