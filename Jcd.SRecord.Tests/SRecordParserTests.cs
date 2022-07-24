using System;
using System.Collections.Generic;
using System.Linq;
using Jcd.SRecord.Extensions;
using Jcd.SRecord.Parsers;
using Xunit;

namespace Jcd.SRecord.Tests
{
    public class SRecordParserTests
    {
        private static readonly SRecordParser FlexibleParser = SRecordParser.Flexible;
        private static readonly SRecordParser StrictParser = SRecordParser.Strict;

        [Fact]
        public void Constructor_Throws_On_Null_Or_Empty_TypeLookup()
        {
            Assert.ThrowsAny<ArgumentException>(() => new SRecordParser(null));
            var emptyLookup = new Dictionary<string, SRecordType>();
            Assert.ThrowsAny<ArgumentException>(() => new SRecordParser(emptyLookup));
        }

        [Theory]
        [InlineData("S00F000068656C6C6F202020202000003C\r\n","S0", 0x0f, 0x0000, "68656C6C6F20202020200000", 0x3c)]
        [InlineData("S111003848656C6C6F20776F726C642E0A0042", "S1", 0x11, 0x0038, "48656C6C6F20776F726C642E0A00", 0x42)]
        [InlineData("S5030003F9","S5",0x03,0x0003,"",0xF9)]
        [InlineData("S9030000FC","S9",0x03,0x0000,"",0xFC)]
        public void Strict_Parse_Returns_A_Valid_Record_For_Valid_Data(string recordText, string expectedType, byte expectedCount, uint expectedAddress, string expectedBytesInHex, byte expectedChecksum)
        {
            var expectedBytes = string.IsNullOrEmpty(expectedBytesInHex)
                ? Array.Empty<byte>()
                : expectedBytesInHex.HexStringToBytes().ToArray();
            var record = StrictParser.Parse(recordText);
            var actualBytes = record.Data.ToArray();
            Assert.NotNull(record);
            Assert.Equal(expectedType,record.Type.Key);
            Assert.Equal(expectedCount, record.CountOfRemainingBytes);
            Assert.Equal(expectedAddress, record.Address);
            Assert.Equal(expectedChecksum, record.Checksum);
            Assert.Equal(expectedBytes, actualBytes);
        }
        
        [Theory]
        [InlineData("S00F000068656C6C6F202020202000003C\r\n","S0", 0x0f, 0x0000, "68656C6C6F20202020200000", 0x3c)]
        [InlineData("S111003848656C6C6F20776F726C642E0A0042", "S1", 0x11, 0x0038, "48656C6C6F20776F726C642E0A00", 0x42)]
        [InlineData("S5030003F9","S5",0x03,0x0003,"",0xF9)]
        [InlineData("S9030000FC","S9",0x03,0x0000,"",0xFC)]
        public void Strict_TryParse_Returns_A_Valid_Record_For_Valid_Data_And_True(string recordText, string expectedType, byte expectedCount, uint expectedAddress, string expectedBytesInHex, byte expectedChecksum)
        {
            var expectedBytes = string.IsNullOrEmpty(expectedBytesInHex)
                ? Array.Empty<byte>()
                : expectedBytesInHex.HexStringToBytes().ToArray();
            var result=StrictParser.TryParse(recordText, out var record);
            var actualBytes = record.Data.ToArray();
            Assert.True(result);
            Assert.NotNull(record);
            Assert.Equal(expectedType,record.Type.Key);
            Assert.Equal(expectedCount, record.CountOfRemainingBytes);
            Assert.Equal(expectedAddress, record.Address);
            Assert.Equal(expectedChecksum, record.Checksum);
            Assert.Equal(expectedBytes, actualBytes);
        }
        
        [Theory]
        [InlineData("S00F000068656C6C6F202020202000003C\r\n","S0", 0x0f, 0x0000, "68656C6C6F20202020200000", 0x3c)]
        [InlineData("S111003848656C6C6F20776F726C642E0A0042", "S1", 0x11, 0x0038, "48656C6C6F20776F726C642E0A00", 0x42)]
        [InlineData("S5030003F9","S5",0x03,0x0003,"",0xF9)]
        [InlineData("S9030000FC","S9",0x03,0x0000,"",0xFC)]
        public void Flexible_Parse_Returns_A_Valid_Record_For_Valid_Data(string recordText, string expectedType, byte expectedCount, uint expectedAddress, string expectedBytesInHex, byte expectedChecksum)
        {
            var expectedBytes = string.IsNullOrEmpty(expectedBytesInHex)
                ? Array.Empty<byte>()
                : expectedBytesInHex.HexStringToBytes().ToArray();
            var record = FlexibleParser.Parse(recordText);
            var actualBytes = record.Data.ToArray();
            Assert.NotNull(record);
            Assert.Equal(expectedType,record.Type.Key);
            Assert.Equal(expectedCount, record.CountOfRemainingBytes);
            Assert.Equal(expectedAddress, record.Address);
            Assert.Equal(expectedChecksum, record.Checksum);
            Assert.Equal(expectedBytes, actualBytes);
        }
        
        [Theory]
        [InlineData("S00F000068656C6C6F202020202000003C\r\n","S0", 0x0f, 0x0000, "68656C6C6F20202020200000", 0x3c)]
        [InlineData("S111003848656C6C6F20776F726C642E0A0042", "S1", 0x11, 0x0038, "48656C6C6F20776F726C642E0A00", 0x42)]
        [InlineData("S5030003F9","S5",0x03,0x0003,"",0xF9)]
        [InlineData("S9030000FC","S9",0x03,0x0000,"",0xFC)]
        public void Flexible_TryParse_Returns_A_Valid_Record_For_Valid_Data_And_True(string recordText, string expectedType, byte expectedCount, uint expectedAddress, string expectedBytesInHex, byte expectedChecksum)
        {
            var expectedBytes = string.IsNullOrEmpty(expectedBytesInHex)
                ? Array.Empty<byte>()
                : expectedBytesInHex.HexStringToBytes().ToArray();
            var result=FlexibleParser.TryParse(recordText, out var record);
            var actualBytes = record.Data.ToArray();
            Assert.True(result);
            Assert.NotNull(record);
            Assert.Equal(expectedType,record.Type.Key);
            Assert.Equal(expectedCount, record.CountOfRemainingBytes);
            Assert.Equal(expectedAddress, record.Address);
            Assert.Equal(expectedChecksum, record.Checksum);
            Assert.Equal(expectedBytes, actualBytes);
        }
        
        [Theory]
        [InlineData("X00F000068656C6C6F202020202000003C")]
        [InlineData("SA0F000068656C6C6F202020202000003C")]
        [InlineData("0A0F000068656C6C6F202020202000003C")]
        public void Parse_Throws_When_Given_Incorrect_Type(string badText)
        {
            Assert.ThrowsAny<Exception>(() => StrictParser.Parse(badText));
        }
        
        [Theory]
        [InlineData("X00F000068656C6C6F202020202000003C")]
        [InlineData("SA0F000068656C6C6F202020202000003C")]
        [InlineData("0A0F000068656C6C6F202020202000003C")]
        public void TryParse_Returns_False_And_Null_Record_When_Given_Bad_Type(string badText)
        {
             var result=StrictParser.TryParse(badText,out var record);
             Assert.False(result);
             Assert.Null(record);
        }
        
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Parse_Throws_When_Given_Null_Empty_Or_Whitespace(string badText)
        {
            Assert.ThrowsAny<Exception>(() => StrictParser.Parse(badText));
        }
        
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void TryParse_Returns_False_And_Null_Record_When_Given_Null_Empty_Or_Whitespace(string badText)
        {
            var result=StrictParser.TryParse(badText,out var record);
            Assert.False(result);
            Assert.Null(record);
        }

        [Theory]
        [InlineData("S10")]
        [InlineData("S111003848656C6C6F20776F726C642E0A00420")]
        [InlineData("S11103848656C6C6F20776F726C642E0A0042")]
        public void Parse_Throws_When_Given_Odd_Number_Of_Characters(string badText)
        {
            Assert.ThrowsAny<Exception>(() => StrictParser.Parse(badText));
        }
        
        [Theory]
        [InlineData("S10")]
        [InlineData("S111003848656C6C6F20776F726C642E0A00420")]
        [InlineData("S11103848656C6C6F20776F726C642E0A0042")]
        public void TryParse_Returns_False_And_Null_Record_When_Given_Odd_Number_Of_Characters(string badText)
        {
            var result=StrictParser.TryParse(badText,out var record);
            Assert.False(result);
            Assert.Null(record);
        }
        
        [Theory]
        [InlineData("S111003848656C6X6F20776F726C642E0A0042")]
        public void Parse_Throws_When_Given_NonHex_Data_In_Body(string badText)
        {
            Assert.ThrowsAny<Exception>(() => StrictParser.Parse(badText));
        }
        
        [Theory]
        [InlineData("S111003848656C6C6F2077$F726C642E0A0042")]
        public void TryParse_Returns_False_And_Null_Record_When_Given_NonHex_Data_In_Body(string badText)
        {
            var result=StrictParser.TryParse(badText,out var record);
            Assert.False(result);
            Assert.Null(record);
        }
        
        [Theory]
        [InlineData("S100")]
        [InlineData("S10000")]
        [InlineData("S1000000")]
        public void Parse_Throws_When_Given_Too_Few_Characters(string badText)
        {
            Assert.ThrowsAny<Exception>(() => StrictParser.Parse(badText));
        }
        
        [Theory]
        [InlineData("S100")]
        [InlineData("S10000")]
        [InlineData("S1000000")]
        public void TryParse_Returns_False_And_Null_Record_When_Given_Too_Few_Characters(string badText)
        {
            var result=StrictParser.TryParse(badText,out var record);
            Assert.False(result);
            Assert.Null(record);
        }

        [Theory]
        [InlineData("S112003848656C6C6F20776F726C642E0A0042")]
        [InlineData("S110003848656C6C6F20776F726C642E0A0042")]
        public void Parse_Throws_When_Parsed_Byte_Count_Doesnt_Match_Actual_Byte_Count(string badText)
        {
            Assert.ThrowsAny<Exception>(() => StrictParser.Parse(badText));
        }
        
        [Theory]
        [InlineData("S112003848656C6C6F20776F726C642E0A0042")]
        [InlineData("S110003848656C6C6F20776F726C642E0A0042")]
        public void TryParse_Returns_Parsed_Byte_Count_Doesnt_Match_Actual_Byte_Count(string badText)
        {
            var result=StrictParser.TryParse(badText,out var record);
            Assert.False(result);
            Assert.Null(record);
        }
        
        [Theory]
        [InlineData("S5030003F8")]
        [InlineData("S111003848656C6C6F20776F726C642E0A0043")]
        public void Parse_Throws_When_Parsed_Checksum_Doesnt_Match_Actual_Checksum(string badText)
        {
            Assert.ThrowsAny<Exception>(() => StrictParser.Parse(badText));
        }
        
        [Theory]
        [InlineData("S5030003e9")]
        [InlineData("S111003848656C6C6F20776F726C642E0A0043")]
        public void TryParse_Returns_Parsed_Checksum_Doesnt_Match_Actual_Checksum(string badText)
        {
            var result=StrictParser.TryParse(badText,out var record);
            Assert.False(result);
            Assert.Null(record);
        }

        [Theory]
        [InlineData(251)]
        [InlineData(252)]
        [InlineData(253)]
        [InlineData(254)]
        [InlineData(255)]
        public void Create_Returns_Existing_Instance_Of_Flexible_When_Given_A_Max_Byte_Count_Greater_Than_250(byte max)
        {
            var instance = SRecordParser.Create(max);
            Assert.Same(SRecordParser.Flexible,instance);            
        }
        
        [Fact]
        public void Create_Returns_Existing_Instance_Of_Strict_When_Given_A_Max_Byte_Count_Is_32()
        {
            var instance = SRecordParser.Create(32);
            Assert.Same(SRecordParser.Strict,instance);            
        }
        
        [Theory]
        [InlineData(25)]
        [InlineData(64)]
        [InlineData(128)]
        public void Create_Returns_New_Instance_When_Called_Twice_In_A_Row_With_Same_Max_Bytes(byte max)
        {
            var instance1 = SRecordParser.Create(max);
            var instance2 = SRecordParser.Create(max);
            Assert.NotSame(instance1,instance2);            
        }
        
        
    }
}