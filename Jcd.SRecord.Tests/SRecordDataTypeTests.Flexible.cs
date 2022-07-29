using System;
using Xunit;
using Sut=Jcd.SRecord.SRecordDataType.Flexible;

namespace Jcd.SRecord.Tests
{
    // ReSharper disable once InconsistentNaming
    public  partial class SRecordDataTypeTests
    {
        [Fact]
        public void Flexible_Instance_TypeLookup_Values_Contains_All_S0_To_S9_Entries()
        {
            var values = Sut.TypeLookup.Values;
            Assert.Contains(Sut.S0, values);
            Assert.Contains(Sut.S1, values);
            Assert.Contains(Sut.S2, values);
            Assert.Contains(Sut.S3, values);
            Assert.Contains(Sut.S4, values);
            Assert.Contains(Sut.S5, values);
            Assert.Contains(Sut.S6, values);
            Assert.Contains(Sut.S7, values);
            Assert.Contains(Sut.S8, values);
            Assert.Contains(Sut.S9, values);
        }

        [Fact]
        public void Flexible_Instance_S0_S1_S2_And_S3_Have_More_Than_32_Bytes_Of_Data()
        {
            Assert.InRange( Sut.S0.MaximumDataBytesAllowed, 33,255);
            Assert.InRange( Sut.S1.MaximumDataBytesAllowed, 33,255);
            Assert.InRange( Sut.S2.MaximumDataBytesAllowed, 33,255);
            Assert.InRange( Sut.S3.MaximumDataBytesAllowed, 33,255);
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
        public void Flexible_Instance_FromKey_Returns_Expected_Matching_Result(string key)
        {
            var result = Sut.FromKey(key);
            Assert.Equal(key,result.Key);
            Assert.True(result.IsValid);
        }
        
        [Theory]
        [InlineData("SX")]
        [InlineData("Z9")]
        public void Flexible_Instance_FromKey_Throws_When_Given_A_Bad_Key(string key)
        {
            Assert.ThrowsAny<Exception>(() => { var _ = Sut.FromKey(key);});
        }        
    }
}