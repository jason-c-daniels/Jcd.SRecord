using Jcd.SRecord.IO;
using Xunit;

namespace Jcd.SRecord.Tests.IO
{
    public class SRecordElementParsedEventArgsTests
    {
        [Theory]
        [InlineData("bad line of text")]
        [InlineData("S11F001C4BFFFFE5398000007D83637880010014382100107C0803A64E800020E9")]
        public void Constructor_Correctly_Populates_All_Data(string lineOfText)
        {
            var element=SRecordElementParser.Default.Parse(1, lineOfText);
            var args = new SRecordElementParsedEventArgs(element);
            Assert.Same(element,args.Element);
        }
    }
}