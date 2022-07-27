using System;
using Jcd.SRecord.Extensions;
using Xunit;

namespace Jcd.SRecord.Tests.Extensions
{
    public class BigEndianConversionsTests
    {
        [Fact]
        public void ToUInt32_Correctly_Converts_The_Value()
        {
            var arr1 = new ReadOnlySpan<byte>(new byte[] { 0x0b });
            uint expected = 0x0b;
            Assert.Equal(expected,arr1.ToUInt32());
            var arr2 = new ReadOnlySpan<byte>(new byte[] { 0x0b, 0x0e });
            expected = 0x0b0e;
            Assert.Equal(expected,arr2.ToUInt32());
            var arr3 = new ReadOnlySpan<byte>(new byte[] { 0x0b, 0x0e, 0xEf });
            expected = 0x0b0eef;
            Assert.Equal(expected,arr3.ToUInt32());
            var arr4 = new ReadOnlySpan<byte>(new byte[] { 0xde,0xad, 0xBe, 0xEf });
            expected = 0xdeadbeef;
            Assert.Equal(expected,arr4.ToUInt32());
        }
    }
}