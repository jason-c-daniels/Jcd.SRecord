using Jcd.SRecord.IO;
using Xunit;

namespace Jcd.SRecord.Tests.IO
{
    public class SRecordElementFormattedEventArgsTests
    {
        [Theory]
        [InlineData(false,"Some arbitrary text",null)]
        [InlineData(true,"S9030000FC # valid srec with comment.","S9030000FC")]
        public void Constructor_Populates_Data_Correctly(bool succeeded, string elementText, string formattedText)
        {
            var element = SRecordElementParser.Default.Parse(1, elementText);
            var args = new SRecordElementFormattedEventArgs(succeeded, element, formattedText);
            Assert.Equal(succeeded,args.Succeeded);
            Assert.Same(element,args.Element);
            Assert.Equal(formattedText,args.FormattedText);
            
        }
    }
}