using Xunit;
using Sut=Jcd.SRecord.SRecordType.Strict;

namespace Jcd.SRecord.Tests
{
    // ReSharper disable once InconsistentNaming
    public class SRecordType_Strict_Tests
    {
        [Fact]
        public void TypeLookup_Values_Contains_All_S0_To_S9_Entries()
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
        public void S0_S1_S2_And_S3_Have_32_Bytes_Of_Data()
        {
            Assert.Equal(Sut.MaxDataLength, Sut.S0.MaximumDataBytesAllowed);
            Assert.Equal(Sut.MaxDataLength, Sut.S1.MaximumDataBytesAllowed);
            Assert.Equal(Sut.MaxDataLength, Sut.S2.MaximumDataBytesAllowed);
            Assert.Equal(Sut.MaxDataLength, Sut.S3.MaximumDataBytesAllowed);
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
        public void FromKey_Returns_Expected_Matching_Result(string key)
        {
            var result = Sut.FromKey(key);
            Assert.Equal(key,result.Key);
            Assert.True(result.IsValid);
        }
    }
}