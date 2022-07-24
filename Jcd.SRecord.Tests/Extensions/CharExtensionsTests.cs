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
        
    }
}