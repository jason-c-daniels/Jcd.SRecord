using Jcd.SRecord.IO;
using Xunit;

namespace Jcd.SRecord.Tests.IO
{
    public class SRecordElementParsingEventArgsTests
    {
        [Theory]
        [InlineData(1,"line of text")]
        [InlineData(2,"another line of text")]
        public void Constructor_Correctly_Populates_All_Data(int lineNumber,string originalLineOfText)
        {
            var args = new SRecordElementParsingEventArgs(lineNumber, originalLineOfText);
            Assert.Equal(lineNumber,args.LineNumber);
            Assert.Equal(originalLineOfText, args.OriginalLineOfText);
        }
    }
}