using System;
using Jcd.SRecord.Extensions;
using Xunit;

namespace Jcd.SRecord.Tests.Extensions
{
    public class CharExtensionsTests
    {
        [Theory]
        [InlineData('0')]
        [InlineData('1')]
        [InlineData('2')]
        [InlineData('3')]
        [InlineData('4')]
        [InlineData('5')]
        [InlineData('6')]
        [InlineData('7')]
        [InlineData('8')]
        [InlineData('9')]
        [InlineData('a')]
        [InlineData('b')]
        [InlineData('c')]
        [InlineData('d')]
        [InlineData('e')]
        [InlineData('f')]
        [InlineData('A')]
        [InlineData('B')]
        [InlineData('C')]
        [InlineData('D')]
        [InlineData('E')]
        [InlineData('F')]

        public void IsHexDigit_Returns_True_For_Any_Hexadecimal_Digit(char c)
        {
            Assert.True(c.IsHexDigit());
        }
        
        [Theory]
        [InlineData('G')]
        [InlineData('h')]
        [InlineData('I')]
        [InlineData('j')]
        [InlineData('K')]
        [InlineData('L')]
        [InlineData('m')]
        [InlineData('n')]
        [InlineData('\u8080')]

        public void IsHexDigit_Returns_False_For_Any_Nonhexadecimal_Digit(char c)
        {
            Assert.False(c.IsHexDigit());
        }

        [Theory]
        [ClassData(typeof(UnicodeNonCommentCharacters))]
        public void ThrowArgumentExceptionIfNotValidForSRecordComment_Throws_When_Given_An_Invalid_Character(char c)
        {
            Assert.ThrowsAny<ArgumentException>(()=>c.ThrowArgumentExceptionIfNotValidForSRecordComment());
        }
        
        [Theory]
        [ClassData(typeof(UnicodeCommentCharacters))]
        public void ThrowArgumentExceptionIfNotValidForSRecordComment_Does_Not_Throw_When_Given_A_Valid_Character(char c)
        {
            c.ThrowArgumentExceptionIfNotValidForSRecordComment();
        }

        [Theory]
        [InlineData('0', 0)]
        [InlineData('1', 1)]
        [InlineData('2', 2)]
        [InlineData('3', 3)]
        [InlineData('4', 4)]
        [InlineData('5', 5)]
        [InlineData('6', 6)]
        [InlineData('7', 7)]
        [InlineData('8', 8)]
        [InlineData('9', 9)]
        [InlineData('A', 10)]
        [InlineData('B', 11)]
        [InlineData('C', 12)]
        [InlineData('D', 13)]
        [InlineData('E', 14)]
        [InlineData('F', 15)]
        [InlineData('a', 10)]
        [InlineData('b', 11)]
        [InlineData('c', 12)]
        [InlineData('d', 13)]
        [InlineData('e', 14)]
        [InlineData('f', 15)]
        public void GetHexValue_Calculates_Expected_Number(char c, byte e)
        {
            Assert.Equal(e,c.GetHexValue());
        }
    }
}