using System;
using Jcd.Validations;
using Xunit;

namespace Jcd.SRecord.Tests
{
    public class SRecordTypeTests
    {
        [Theory]
        [InlineData("S")]
        [InlineData("S  ")]
        [InlineData("S00")]
        [InlineData("")]
        public void Constructor_Throws_Exception_When_Key_Is_Too_Long_Or_Too_Short(string key)
        {
            Assert.Throws<ArgumentException>(()=>new SRecordType(key, 2, true));
        }
        
        [Theory]
        [InlineData("X0")]
        [InlineData("A1")]
        [InlineData("B3")]
        public void Constructor_Throws_Exception_When_First_Letter_Of_Key_Is_Not_S(string key)
        {
            Assert.Throws<ArgumentException>(()=>new SRecordType(key, 2, true));
        }
        
        [Theory]
        [InlineData("SA")]
        [InlineData("SB")]
        [InlineData("SC")]
        [InlineData("S ")]
        public void Constructor_Throws_Exception_When_Second_Character_Of_Key_Is_Not_ASCII_0_to_9(string key)
        {
            Assert.Throws<ArgumentOutOfRangeException>(()=>new SRecordType(key, 2, true));
        }

        [Theory]
        [InlineData("S0",(byte)2,(byte)32,true,true)]
        [InlineData("S1",(byte)3,(byte)33,false,false)]
        public void Constructor_Correctly_Populates_Data_When_All_Is_Provided(
            string key, byte addressLength, byte maxDataLen, bool special, bool isValid)
        {
            var srt = new SRecordType(key, addressLength, maxDataLen, special, isValid);
            Assert.Equal(key,srt.Key);
            Assert.Equal(addressLength, srt.AddressLengthInBytes);
            Assert.Equal(maxDataLen, srt.MaximumDataBytesAllowed);
            Assert.Equal(special, srt.RequiresSpecialHandling);
            Assert.Equal(isValid, srt.IsValid);
        }

        [Theory]
        [InlineData(2,255)]
        [InlineData(2,254)]
        [InlineData(2,253)]
        [InlineData(3,252)]
        [InlineData(4,251)]
        public void Constructor_Throws_When_Sum_Of_Checksum_Length_Address_Length_And_MaximumDataLength_Exceeds_255(byte addressLength, byte maxDataLen)
        {
            Assert.Throws<ArgumentException>(()=>new SRecordType("S0", addressLength, maxDataLen));
        }

        [Theory]
        [InlineData("S1", (byte)2, false, true)]
        [InlineData("S2", (byte)3, false, true)]
        [InlineData("S3", (byte)4, false, true)]
        [InlineData("S4", (byte)4, false, true)]
        public void Constructor_Correctly_Calculates_MaximumDataBytesAllowed_When_Not_Provided(
            string key, byte addressLength, bool special, bool isValid)
        {
            var expectedMaxDataLength = (byte)(SRecord.MaxValueForCount - SRecord.CheckSumByteLength - addressLength); 
            var srt = new SRecordType(key, addressLength, special, isValid);
            Assert.Equal(expectedMaxDataLength, srt.MaximumDataBytesAllowed);
        }

        [Theory]
        [InlineData(0)]
        public void CreateLookup_Throws_When_Given_Invalid_Request(byte bytes)
        {
            Assert.ThrowsAny<ArgumentException>(()=>SRecordType.CreateLookup(bytes));
        }
    }
}
