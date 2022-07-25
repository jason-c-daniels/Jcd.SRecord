using System;
using System.Collections.Generic;
using System.Linq;
using Jcd.SRecord.Extensions;
using Xunit;

namespace Jcd.SRecord.Tests.Extensions
{
    public class HexStringConversionsTests
    {
        public static IEnumerable<object[]> DataSet =>
            new List<object[]>
            {
                new object[]{"0123456789",new byte[]{0x01, 0x23, 0x45, 0x67, 0x89},true},
                new object[]{"ABCDEF",new byte[]{0xAB, 0xCD, 0xEF},true},
                new object[]{"abcdef",new byte[]{0xAB, 0xCD, 0xEF},false},
                new object[]{"1F001C4BFFFFE5398000007D83637880010014382100107C0803A64E800020", new byte[]{0x1F, 0x00, 0x1C, 0x4B, 0xFF, 0xFF, 0xE5, 0x39, 0x80, 0x00, 0x00, 0x7D, 0x83, 0x63, 0x78, 0x80, 0x01, 0x00, 0x14, 0x38, 0x21, 0x00, 0x10, 0x7C, 0x08, 0x03, 0xA6, 0x4E, 0x80, 0x00, 0x20}, true},
                new object[]{"", new byte[]{}, false},
                new object[]{null, null, false},
            };

        [Theory]
        [MemberData(nameof(DataSet))]
        public void HexStringToBytes_Converts_To_Correct_Byte_Array(string hexString, byte[] bytes, bool _)
        {
            var actualBytes=hexString.HexStringToBytes()?.ToArray();
            Assert.Equal(bytes,actualBytes);
        }

        [Theory]
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

        [Theory]
        [InlineData("1F001C4BFFFFE5398000007D83637880010014382100107C0803A64E800020")]
        [InlineData("1F00007C0802A6900100049421FFF07C6C1B787C8C23783C6000003863000026")]
        public void HexStringToBytes_BytesToHexString_Round_Trip_Works(string hexString)
        {
            var bytes = hexString.HexStringToBytes();
            var newString = bytes.BytesToHexString();
            Assert.Equal(hexString,newString );
        }

        [Theory]
        [InlineData('0','b',0x0B)]
        [InlineData('B','b',0xBB)]
        [InlineData('F','1',0xF1)]
        [InlineData('E','0',0xE0)]
        public void MakeByte_Calculates_The_Expected_Value(char c0, char c1, byte e)
        {
            Assert.Equal(e, HexStringConversions.MakeByte(c0, c1));
        }
    }
}