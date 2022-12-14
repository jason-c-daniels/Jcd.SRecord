using Xunit;

namespace Jcd.SRecord.Tests
{
    public class SRecordElementTypeTests
    {
        [Fact]
        public void Equals_Method_Returns_True_When_Values_Are_Equal()
        {
            var v1 = SRecordElementType.SRecordWithEndOfElementComment;
            var v2 = SRecordElementType.SRecordWithEndOfElementComment;
            Assert.True(v1.Equals(v2));
            Assert.True(v2.Equals(v1));
            Assert.True(v1.Equals((object)v2));
            Assert.True(v2.Equals((object)v1));
        }
        
        [Fact]
        public void Equals_Method_Returns_False_When_Values_Are_Not_Equal()
        {
            var v1 = SRecordElementType.SRecordWithEndOfElementComment;
            var v2 = SRecordElementType.SRecord;
            Assert.False(v1.Equals(v2));
            Assert.False(v2.Equals(v1));
            Assert.False(v1.Equals((object)v2));
            Assert.False(v2.Equals((object)v1));
        }
     
        [Fact]
        public void Equals_Operator_Returns_True_When_Values_Are_Equal()
        {
            var v1 = SRecordElementType.SRecordWithEndOfElementComment;
            var v2 = SRecordElementType.SRecordWithEndOfElementComment;
            Assert.True(v1 == v2);
            Assert.True(v2 == v1);
        }
        
        [Fact]
        public void Equals_Operator_Returns_False_When_Values_Are_Not_Equal()
        {
            var v1 = SRecordElementType.SRecordWithEndOfElementComment;
            var v2 = SRecordElementType.SRecord;
            Assert.False(v1 == v2);
            Assert.False(v2 == v1);
        }

        [Fact]
        public void Not_Equals_Operator_Returns_True_When_Values_Are_Not_Equal()
        {
            var v1 = SRecordElementType.SRecordWithEndOfElementComment;
            var v2 = SRecordElementType.SRecord;
            Assert.True(v1 != v2);
            Assert.True(v2 != v1);
        }
        
        [Fact]
        public void Not_Equals_Operator_Returns_False_When_Values_Are_Equal()
        {
            var v1 = SRecordElementType.SRecordWithEndOfElementComment;
            var v2 = SRecordElementType.SRecordWithEndOfElementComment;
            Assert.False(v1 != v2);
            Assert.False(v2 != v1);
        }

        [Fact]
        public void GetHashCode_Returns_A_Unique_Non_Zero_Value_For_Different_Data()
        {
            var v1 = SRecordElementType.SRecordWithEndOfElementComment;
            var v2 = SRecordElementType.SRecord;
            Assert.NotEqual(0,v1.GetHashCode());
            Assert.NotEqual(0,v2.GetHashCode());
            Assert.NotEqual(v1.GetHashCode(),v2.GetHashCode());
        }
        
        [Fact]
        public void GetHashCode_Returns_The_Same_Value_For_The_Same_Data()
        {
            var v1 = SRecordElementType.SRecordWithEndOfElementComment;
            var v2 = SRecordElementType.SRecordWithEndOfElementComment;
            Assert.Equal(v1.GetHashCode(),v2.GetHashCode());
        }
    }
}