using Jcd.SRecord.IO;
using Xunit;

namespace Jcd.SRecord.Tests.IO
{
    public class SRecordDocumentTests
    {
        [Theory]
        [InlineData("#Line 1\r\n" +
                    "# Line 2\r\n" +
                    "S9030000FC\r\n ",4)]
        [InlineData("#Line 1\r\n" +
                    "# Line 2\r\n" +
                    "S9030000FC\r\n",3)]
        [InlineData("#Line 1\r\n" +
                    "# Line 2\r\n" +
                    "S9030000FC", 3)]
        [InlineData("#Line 1\r\n" +
                    "S9030000FC; line 2", 2)]
        public void CreateFromString_Returns_A_Document_Parsed_From_The_Provided_String(string documentContent, int expectedElementCount)
        {
            var document=SRecordDocument.CreateFromString(documentContent);
            Assert.NotNull(document);
            Assert.Equal(expectedElementCount,document.Elements.Count);
        }
    }
}