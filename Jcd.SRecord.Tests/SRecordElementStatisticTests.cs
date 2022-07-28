using Xunit;

namespace Jcd.SRecord.Tests
{
    public class SRecordElementStatisticTests
    {
        [Theory]
        [InlineData(1,"S123B600BDB653CC0800FD1018FD101AFD101CFD101EBDB665CC0002DD007F00067F001055", true, false, false)]
        [InlineData(2,"S123B600BDB653CC0800FD1018FD101AFD101CFD101EBDB665CC0002DD007F00067F001055# a comment", true, true, false)]
        [InlineData(3,"S123B600BDB653CC0800FD1018FD101AFD101CFD101EBDB665CC0002DD007F00067F001055 ; a comment", true, true, false)]
        [InlineData(3,"Bad Data ; with a comment", false, true, false, true)]
        [InlineData(3,"Bad Data no comment", false, false, false, true)]
        [InlineData(4," ; a comment line", false, true, false)]
        [InlineData(5,"# also a comment line", false, true, false)]
        [InlineData(5,"#", false, true, false)]
        [InlineData(5," ; #", false, true, false)]
        [InlineData(6,"", false, false, true)]
        [InlineData(7," ", false, false, true)]
        [InlineData(8,"\t\r\n", false, false, true)]
        public void Increment_Correctly_Increments(int lineNumber,string text, bool hasRecord, bool hasComment, bool isBlank, bool hasError=false)
        {
            var expectedRecordCount = hasRecord ? 1 : 0;
            var expectedErrorCount = hasError ? 1 : 0;
            var expectedCommentCount = hasComment ? 1 : 0;
            var expectedBlankCount = isBlank ? 1 : 0;
            var expectedSRecordDataWithCommentCount = hasComment && hasRecord ? 1 : 0;
            var expectedStandAloneCommentCount = hasComment && !hasRecord && !hasError? 1 : 0;
            var sut = new SRecordElementStatistics();
            var parser = SRecordElementParser.Default;
            var line = parser.Parse(lineNumber, text);
            sut.Increment(line);
            Assert.Equal(expectedErrorCount, sut.ErrorElementCount);
            Assert.Equal(expectedRecordCount, sut.ElementsWithSRecordDataCount);
            Assert.Equal(expectedBlankCount, sut.BlankElementCount);
            Assert.Equal(expectedCommentCount, sut.ElementsWithCommentsCount);
            Assert.Equal(expectedStandAloneCommentCount, sut.StandAloneCommentCount);
            Assert.Equal(expectedSRecordDataWithCommentCount, sut.SRecordDataWithCommentCount);
            Assert.Equal(1, sut.TotalElementsCount);
        }

        [Theory]
        [InlineData(1,"S123B600BDB653CC0800FD1018FD101AFD101CFD101EBDB665CC0002DD007F00067F001055", true, false, false)]
        [InlineData(2,"S123B600BDB653CC0800FD1018FD101AFD101CFD101EBDB665CC0002DD007F00067F001055# a comment", true, true, false)]
        [InlineData(3,"S123B600BDB653CC0800FD1018FD101AFD101CFD101EBDB665CC0002DD007F00067F001055 ; a comment", true, true, false)]
        [InlineData(3,"Bad Data ; with a comment", false, true, false, true)]
        [InlineData(3,"Bad Data no comment", false, false, false, true)]
        [InlineData(4," ; a comment line", false, true, false)]
        [InlineData(5,"# also a comment line", false, true, false)]
        [InlineData(5,"#", false, true, false)]
        [InlineData(5," ; #", false, true, false)]
        [InlineData(6,"", false, false, true)]
        [InlineData(7," ", false, false, true)]
        [InlineData(8,"\t\r\n", false, false, true)]
        public void Increment_Twice_Then_Decrement_Once_Correctly_Calculates(int lineNumber,string text, bool hasRecord, bool hasComment, bool isBlank, bool hasError=false)
        {
            var expectedRecordCount = hasRecord ? 1 : 0;
            var expectedErrorCount = hasError ? 1 : 0;
            var expectedCommentCount = hasComment ? 1 : 0;
            var expectedBlankCount = isBlank ? 1 : 0;
            var expectedSRecordDataWithCommentCount = hasComment && hasRecord ? 1 : 0;
            var expectedStandAloneCommentCount = hasComment && !hasRecord && !hasError? 1 : 0;
            var sut = new SRecordElementStatistics();
            var parser = SRecordElementParser.Default;
            var line = parser.Parse(lineNumber, text);
            sut.Increment(line);
            sut.Increment(line);
            sut.Decrement(line);
            Assert.Equal(expectedErrorCount, sut.ErrorElementCount);
            Assert.Equal(expectedRecordCount, sut.ElementsWithSRecordDataCount);
            Assert.Equal(expectedBlankCount, sut.BlankElementCount);
            Assert.Equal(expectedCommentCount, sut.ElementsWithCommentsCount);
            Assert.Equal(expectedStandAloneCommentCount, sut.StandAloneCommentCount);
            Assert.Equal(expectedSRecordDataWithCommentCount, sut.SRecordDataWithCommentCount);
            Assert.Equal(1, sut.TotalElementsCount);
        }
        
        [Theory]
        [InlineData(1,"S123B600BDB653CC0800FD1018FD101AFD101CFD101EBDB665CC0002DD007F00067F001055")]
        [InlineData(2,"S123B600BDB653CC0800FD1018FD101AFD101CFD101EBDB665CC0002DD007F00067F001055# a comment")]
        [InlineData(3,"S123B600BDB653CC0800FD1018FD101AFD101CFD101EBDB665CC0002DD007F00067F001055 ; a comment")]
        [InlineData(3,"Bad Data ; with a comment")]
        [InlineData(3,"Bad Data no comment")]
        [InlineData(4," ; a comment line")]
        [InlineData(5,"# also a comment line")]
        [InlineData(5,"#")]
        [InlineData(5," ; #")]
        [InlineData(6,"")]
        [InlineData(7," ")]
        [InlineData(8,"\t\r\n")]
        public void Resert_After_Increment_Twice_Then_Decrement_Once_Sets_All_Stats_To_Zero(int lineNumber,string text)
        {
            var expectedRecordCount = 0;
            var expectedErrorCount = 0;
            var expectedCommentCount = 0;
            var expectedBlankCount = 0;
            var expectedSRecordDataWithCommentCount = 0;
            var expectedStandAloneCommentCount = 0;
            var sut = new SRecordElementStatistics();
            var parser = SRecordElementParser.Default;
            var line = parser.Parse(lineNumber, text);
            sut.Increment(line);
            sut.Increment(line);
            sut.Decrement(line);
            sut.Reset();
            Assert.Equal(expectedErrorCount, sut.ErrorElementCount);
            Assert.Equal(expectedRecordCount, sut.ElementsWithSRecordDataCount);
            Assert.Equal(expectedBlankCount, sut.BlankElementCount);
            Assert.Equal(expectedCommentCount, sut.ElementsWithCommentsCount);
            Assert.Equal(expectedStandAloneCommentCount, sut.StandAloneCommentCount);
            Assert.Equal(expectedSRecordDataWithCommentCount, sut.SRecordDataWithCommentCount);
            Assert.Equal(0, sut.TotalElementsCount);
        }        
    }
}