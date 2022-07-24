using Jcd.SRecord.IO;
using Xunit;

namespace Jcd.SRecord.Tests.IO
{
    public class SRecordElementFormattingEventArgsTests
    {
        [Theory]
        [InlineData("some arbitrary text")]
        [InlineData("S5030003F9")]
        public void Constructor_Correctly_Populates_Data(string elementText)
        {
            var element = SRecordElementParser.Default.Parse(1, elementText);
            var args = new SRecordElementFormattingEventArgs(element);
            Assert.Same(element, args.Element);
        }
    }
}