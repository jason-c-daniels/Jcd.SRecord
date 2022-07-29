using System;
using System.Collections.Generic;
using Xunit;

namespace Jcd.SRecord.Tests
{
    public partial class SRecordDataTypeTests
    {
        [Theory]
        [InlineData("S")]
        [InlineData("S  ")]
        [InlineData("S00")]
        [InlineData("")]
        public void Constructor_Throws_Exception_When_Key_Is_Too_Long_Or_Too_Short(string key)
        {
            Assert.Throws<ArgumentException>(()=>new SRecordDataType(key, 2, true));
        }
        
        [Theory]
        [InlineData("X0")]
        [InlineData("A1")]
        [InlineData("B3")]
        public void Constructor_Throws_Exception_When_First_Letter_Of_Key_Is_Not_S(string key)
        {
            Assert.Throws<ArgumentException>(()=>new SRecordDataType(key, 2, true));
        }
        
        [Theory]
        [InlineData("SA")]
        [InlineData("SB")]
        [InlineData("SC")]
        [InlineData("S ")]
        public void Constructor_Throws_Exception_When_Second_Character_Of_Key_Is_Not_ASCII_0_to_9(string key)
        {
            Assert.Throws<ArgumentOutOfRangeException>(()=>new SRecordDataType(key, 2, true));
        }

        [Theory]
        [InlineData("S0",(byte)2,(byte)32,true,true)]
        [InlineData("S1",(byte)3,(byte)33,false,false)]
        public void Constructor_Correctly_Populates_Data_When_All_Is_Provided(
            string key, byte addressLength, byte maxDataLen, bool special, bool isValid)
        {
            var srt = new SRecordDataType(key, addressLength, maxDataLen, special, isValid);
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
            Assert.Throws<ArgumentException>(()=>new SRecordDataType("S0", addressLength, maxDataLen));
        }

        [Theory]
        [InlineData("S1", (byte)2, false, true)]
        [InlineData("S2", (byte)3, false, true)]
        [InlineData("S3", (byte)4, false, true)]
        [InlineData("S4", (byte)4, false, true)]
        public void Constructor_Correctly_Calculates_MaximumDataBytesAllowed_When_Not_Provided(
            string key, byte addressLength, bool special, bool isValid)
        {
            var expectedMaxDataLength = (byte)(SRecordData.MaxValueForCount - SRecordData.CheckSumByteLength - addressLength); 
            var srt = new SRecordDataType(key, addressLength, special, isValid);
            Assert.Equal(expectedMaxDataLength, srt.MaximumDataBytesAllowed);
        }

        [Theory]
        [InlineData(0)]
        public void CreateLookup_Throws_When_Given_Invalid_Request(byte bytes)
        {
            Assert.ThrowsAny<ArgumentException>(()=>SRecordDataType.CreateLookup(bytes));
        }

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
        public void Equals_Returns_True_When_Equivalent(string key)
        {
            var type1 = SRecordDataType.Flexible.FromKey(key);
            var type2 = SRecordDataType.Flexible.FromKey(key);
            Assert.True(type1.Equals(type2));
            Assert.True(type2.Equals(type1));
            Assert.True(type1.Equals((object)type2));
            Assert.True(type2.Equals((object)type1));
        }

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
        public void Equals_Operator_Returns_True_When_Equivalent(string key)
        {
            var type1 = SRecordDataType.Flexible.FromKey(key);
            var type2 = SRecordDataType.Flexible.FromKey(key);
            Assert.True(type1 == type2);
            Assert.True(type2 == type1);
        }

        [Theory]
        [MemberData(nameof(NonEquivalentTypes))]
        public void Equals_Returns_False_When_Not_Equivalent(string key1, string key2)
        {
            var type1 = SRecordDataType.Flexible.FromKey(key1);
            var type2 = SRecordDataType.Flexible.FromKey(key2);
            Assert.False(type1.Equals(type2));
            Assert.False(type2.Equals(type1));
            Assert.False(type1.Equals((object)type2));
            Assert.False(type2.Equals((object)type1));
        }

        [Theory]
        [MemberData(nameof(NonEquivalentTypes))]
        public void Not_Equals_Operator_Returns_True_When_Not_Equivalent(string key1, string key2)
        {
            var type1 = SRecordDataType.Flexible.FromKey(key1);
            var type2 = SRecordDataType.Flexible.FromKey(key2);
            Assert.True(type1 != type2);
            Assert.True(type2 != type1);
        }
        
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
        public void Not_Equals_Operator_Returns_False_When_Equivalent(string key)
        {
            var type1 = SRecordDataType.Flexible.FromKey(key);
            var type2 = SRecordDataType.Flexible.FromKey(key);
            Assert.False(type1 != type2);
            Assert.False(type2 != type1);
        }
        
        public static IEnumerable<object[]> NonEquivalentTypes => MakeNonEquivalentTypes();

        private static IEnumerable<object[]> MakeNonEquivalentTypes()
        {
            var keys = new[] { "S0", "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9" };
            foreach (var key1 in keys)
            {
                foreach (var key2 in keys)
                {
                    if (key1==key2) continue;
                    yield return new object[] { key1, key2 };
                }
            }
        }
    }
}
