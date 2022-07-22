using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Jcd.SRecord.Tests
{
    public class HexStringConversionsTests
    {
        public static IEnumerable<object[]> DataSet =>
            new List<object[]>
            {
                new object[]{"0123456789",new byte[]{0x01, 0x23, 0x45, 0x67, 0x89},true},
                new object[]{"ABCDEF",new byte[]{0xAB, 0xCD, 0xEF},true},
                new object[]{"abcdef",new byte[]{0xAB, 0xCD, 0xEF},false},
            };

        [Theory]
        [MemberData(nameof(DataSet))]
        public void HexStringToBytes_Converts_To_Correct_Byte_Array(string hexString, byte[] bytes, bool _)
        {
            var actualBytes=hexString.HexStringToBytes().ToArray();
            Assert.Equal(bytes,actualBytes);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" \t\r\n")]
        public void HexStringToBytes_Throws_Exception_When_Null_Empty_Or_Whitespace(string text)
        {
            Assert.ThrowsAny<Exception>(text.HexStringToBytes);
        }

        [Theory]
        [InlineData("0")]
        [InlineData("001")]
        [InlineData("0ACDE")]
        public void HexStringToBytes_Throws_Exception_When_Odd_Number_Of_Characters_Are_Provided(string text)
        {
            Assert.ThrowsAny<Exception>(text.HexStringToBytes);
        }

        [Theory]
        [InlineData("00X1")]
        [InlineData("00$1")]
        [InlineData("0A#B")]
        public void HexStringToBytes_Throws_Exception_When_Nonhexadecimal_Character_Encountered(string text)
        {
            Assert.ThrowsAny<Exception>(text.HexStringToBytes);
        }
        
        [Theory]
        [MemberData(nameof(DataSet))]
        public void BytesToHexString_Converts_To_Correct_String(string expectedString, byte[] bytes, bool toUppercase)
        {
            var actualString = bytes.BytesToHexString(toUppercase); 
            Assert.Equal(expectedString, actualString);
        }
    }
}