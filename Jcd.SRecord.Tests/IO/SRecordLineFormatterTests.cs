using Jcd.SRecord.IO;
using Xunit;

namespace Jcd.SRecord.Tests.IO
{
    public class SRecordLineFormatterTests
    {
        [Fact]
        public void DefaultFormatter_Uses_Default_Options_And_Formatter()
        {
            var sut = SRecordLineFormatter.DefaultFormatter;
            Assert.Equal(SRecordLineFormatter.Options.DefaultOptions, sut.CurrentOptions);
            Assert.Same(SRecordFormatter.Default, sut.SRecordFormatter);
        }

        [Fact]
        public void Constructor_Uses_Default_Options_And_Formatter()
        {
            var sut = new SRecordLineFormatter();
            Assert.Equal(SRecordLineFormatter.Options.DefaultOptions, sut.CurrentOptions);
            Assert.Same(SRecordFormatter.Default, sut.SRecordFormatter);
        }

        [Fact]
        public void Constructor_Uses_The_Passed_In_Values()
        {
            var sut = new SRecordLineFormatter(SRecordLineFormatter.Options.OnlyEmitSRecordData, SRecordFormatter.LowercaseHex);
            Assert.Equal(SRecordLineFormatter.Options.OnlyEmitSRecordData, sut.CurrentOptions);
            Assert.Same(SRecordFormatter.LowercaseHex, sut.SRecordFormatter);
        }

        [Theory]
        [InlineData("# a comment line","")]
        [InlineData(" ", "")]
        [InlineData("S107B6A07C00013BEA; a comment","S107B6A07C00013BEA")]
        [InlineData("S107B6A07C00013BEA # a comment","S107B6A07C00013BEA")]
        [InlineData("S107B6A07C00013BEA","S107B6A07C00013BEA")]
        public void Format_Parse_Valid_Line_With_Comments_Then_Reformat_Without_Comments_And_EmitsBlankLinesAsEmpty_True(string inputLine, string expectedLine)
        {
            var parser = SRecordLineParser.Default;
            var line = parser.Parse(1,inputLine);
            var options = new SRecordLineFormatter.Options(true, emitBlankLineAsEmptyString: true);
            var sut = new SRecordLineFormatter(options);
            var result = sut.Format(line);
            Assert.Equal(expectedLine, result);
        }
        
        [Theory]
        [InlineData("# a comment line", null)]
        [InlineData(" ", null)]
        [InlineData("S107B6A07C00013BEA; a comment","S107B6A07C00013BEA")]
        [InlineData("S107B6A07C00013BEA # a comment","S107B6A07C00013BEA")]
        [InlineData("S107B6A07C00013BEA","S107B6A07C00013BEA")]
        public void Format_Parse_Valid_Line_With_Comments_Then_Reformat_Without_Comments_And_EmitsBlankLinesAsEmpty_False(string inputLine, string expectedLine)
        {
            var parser = SRecordLineParser.Default;
            var line = parser.Parse(1,inputLine);
            var options = new SRecordLineFormatter.Options(true, emitBlankLineAsEmptyString: false);
            var sut = new SRecordLineFormatter(options);
            var result = sut.Format(line);
            Assert.Equal(expectedLine, result);
        }
        
        [Theory]
        [InlineData("# a comment line", "! a comment line")]
        [InlineData(" # a comment line", "! a comment line")]
        [InlineData("S107B6A07C00013BEA; a comment","S107B6A07C00013BEA ! a comment")]
        [InlineData("S107B6A07C00013BEA # a comment","S107B6A07C00013BEA ! a comment")]
        [InlineData("S107B6A07C00013BEA","S107B6A07C00013BEA")]
        public void Format_Parse_Valid_Line_With_Comments_Then_Reformat_With_New_Comment_Character(string inputLine, string expectedLine)
        {
            var parser = SRecordLineParser.Default;
            var line = parser.Parse(1,inputLine);
            var options = new SRecordLineFormatter.Options(true, emitComment:true, emitSpaceBeforeEndOfLineComment:true, commentCharacter:'!');
            var sut = new SRecordLineFormatter(options);
            var result = sut.Format(line);
            Assert.Equal(expectedLine, result);
        }
        
        [Theory]
        [InlineData("# a comment line")]
        [InlineData(" # a comment line")]
        [InlineData("S107B6A07C00013BEA; a comment")]
        [InlineData("S107B6A07C00013BEA # a comment")]
        [InlineData("S107B6A07C00013BEA")]
        [InlineData("Bad Data")]
        [InlineData("   ")]
        [InlineData("")]
        [InlineData(null)]
        public void Format_Parse_Only_Emit_Original_Line(string inputLine)
        {
            var parser = SRecordLineParser.Default;
            var line = parser.Parse(1,inputLine);
            var options = new SRecordLineFormatter.Options(emitOriginalText:true, commentCharacter:'!');
            var sut = new SRecordLineFormatter(options);
            var result = sut.Format(line);
            Assert.Equal(inputLine, result);
        }
        
        [Theory]
        [InlineData("S107B6A07C00013B1A; a comment", true, '!',"!S107B6A07C00013B1A; a comment")]
        [InlineData("Bad Data", true, '@',"@Bad Data")]
        [InlineData("S107B6A07C00013B1A; a comment", false, '!',null)]
        [InlineData("Bad Data", false, '@', null)]
        public void Format_Parse_And_Maybe_Reemit_Error_Line_As_Commented_Out(string inputLine, bool emitErrorLineAsCommentLine, char commentChar, string expectedLine)
        {
            var parser = SRecordLineParser.Default;
            var line = parser.Parse(1,inputLine);
            var options = new SRecordLineFormatter.Options(emitComment:true,emitErrorLineAsCommentLine:emitErrorLineAsCommentLine, commentCharacter:commentChar);
            var sut = new SRecordLineFormatter(options);
            var result = sut.Format(line);
            Assert.Equal( expectedLine,result);
        }        
    }
}