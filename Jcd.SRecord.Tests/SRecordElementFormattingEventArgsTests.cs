using Xunit;

namespace Jcd.SRecord.Tests
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
            Assert.Equal(element, args.Element);
        }
    }
}