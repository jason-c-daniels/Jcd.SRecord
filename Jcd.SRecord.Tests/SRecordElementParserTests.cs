using Xunit;

namespace Jcd.SRecord.Tests
{
    public class SRecordElementParserTests
    {
        [Fact]
        public void Default_Instance_Has_Default_Configuration()
        {
            var sut = SRecordElementParser.Default;
            Assert.Same(SRecordDataParser.Default,sut.RecordParser);
            Assert.Equal(SRecordElementParser.DefaultCommentCharacters,sut.CommentCharacters);
            Assert.Equal(SRecordElementParser.DefaultCommentCharacters.Count>0,sut.AllowComments);
        }


        [Theory]
        [InlineData(1,"S123B600BDB653CC0800FD1018FD101AFD101CFD101EBDB665CC0002DD007F00067F001055", true, false, false)]
        [InlineData(2,"S123B600BDB653CC0800FD1018FD101AFD101CFD101EBDB665CC0002DD007F00067F001055# a comment", true, true, false)]
        [InlineData(3,"S123B600BDB653CC0800FD1018FD101AFD101CFD101EBDB665CC0002DD007F00067F001055 ; a comment", true, true, false)]
        [InlineData(4," ; a comment line", false, true, false)]
        [InlineData(5,"# also a comment line", false, true, false)]
        [InlineData(5,"Bad line # with a comment line", false, true, false, true)]
        [InlineData(5,"Bad line without comment line", false, false, false, true)]
        [InlineData(5,"#", false, true, false)]
        [InlineData(5," ; #", false, true, false)]
        [InlineData(6,"", false, false, true)]
        [InlineData(7," ", false, false, true)]
        [InlineData(8,"\t\r\n", false, false, true)]
        public void Default_Parse_Returns_A_Valid_Line_When_SRecord_Data_Comments_Or_Mixed_Line_Is_Passed_In(int lineNumber,string text, bool hasRecord, bool hasComment, bool isBlank, bool hasError=false)
        {
            var sut = SRecordElementParser.Default;
            var line = sut.Parse(lineNumber, text);
            Assert.Equal(hasError,line.ElementType.HasError);
            Assert.Equal(hasComment,line.ElementType.HasComment);
            Assert.Equal(hasComment,line.Comment!=null);
            Assert.Equal(hasRecord,line.ElementType.HasSRecordData);
            Assert.Equal(hasRecord,line.SRecordData!=null);
            Assert.Equal(isBlank,line.ElementType.IsBlank);
            Assert.NotNull(line.OriginalLine);
            Assert.Equal(text,line.OriginalLine);
        }


        [Theory]
        [InlineData(1,"NON-SRECORD-DATA", true)]
        [InlineData(2,"S123B600BDB653CC0800FD1018FD101AFD101CFD101EBDB665CC0002DD007F00067F001051", true)] // corrupt checksum
        [InlineData(3,"S123B600BDB653CC0800FD1018FD101AFD101CFD101EBDB665CC0002DD007F00067F001051 # with comment", true)] // corrupt checksum
        [InlineData(3,"S123B600BDB653CC0800FD1018FD101AFD101CFD101EBDB665CC0002DD007F00067F001055 ! bad comment character", true)]
        public void Default_Parse_Returns_An_Error_Line_When_Given_Invalid_Data( int lineNumber, string text, bool expectException)
        {
            var sut = SRecordElementParser.Default;
            var line = sut.Parse(lineNumber, text);
            Assert.True(line.ElementType.HasError);
            Assert.Equal(expectException, line.Exception != null);
            Assert.Equal(text,line.OriginalLine);
            Assert.NotNull(line.OriginalLine);
        }
    }
}