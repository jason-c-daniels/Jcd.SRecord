using System.IO;
using System.Linq;
using Xunit;

namespace Jcd.SRecord.Tests
{
    public class SRecordDocumentTests
    {
        [Theory]
        [InlineData("#Line 1\r\n" +
                    "# Line 2\r\n" +
                    "S9030000FC\r\n ", 4,1)]
        [InlineData("#Line 1\r\n" +
                    "# Line 2\r\n" +
                    "S9030000FC\r\n", 3,1)]
        [InlineData("#Line 1\r\n" +
                    "# Line 2\r\n" +
                    "S9030000FC", 3, 1)]
        [InlineData("#Line 1\r\n" +
                    "S9030000FC; line 2", 2, 1)]
        [InlineData("#Line 1\r\n" +
                    "S9030000FC; line 2\r\n" +
                    "S9030000FC; line 2", 3, 2)]
        public void CreateFromString_Returns_A_Document_Parsed_From_The_Provided_String(string documentContent, int expectedElementCount, int expectedSRecordCount)
        {
            var document=SRecordDocument.CreateFromString(documentContent);
            Assert.NotNull(document);
            Assert.Equal(expectedElementCount,document.Elements.Count);
            Assert.Equal(expectedSRecordCount,document.SRecords.Count());
        }
        
        
        [Theory]
        [InlineData("#Line 1\r\n" +
                    "# Line 2\r\n" +
                    "S9030000FC\r\n # ", 4)]
        [InlineData("#Line 1\r\n" +
                    "# Line 2\r\n" +
                    "S9030000FC\r\n", 3)]
        [InlineData("#Line 1\r\n" +
                    "# Line 2\r\n" +
                    "S9030000FC", 3)]
        [InlineData("#Line 1\r\n" +
                    "S9030000FC; line 2", 2)]
        public void ToString_Returns_A_String_With_The_Correct_Number_Of_Lines(string documentContent, int expectedLineCount)
        {
            var document=SRecordDocument.CreateFromString(documentContent);
            Assert.NotNull(document);
            using var reader = new StringReader(document.ToString());
            var count = 0;
            while (reader.ReadLine() != null) count++;
            Assert.Equal(expectedLineCount,count); 
        }

        [Theory]
        [InlineData(@"_TestData\FakeFirmware.s37", 6, 6)]
        [InlineData(@"_TestData\FakeFirmware.s19", 7 ,7)]
        [InlineData(@"_TestData\BadFirmware-corrupt-checksum-with-eol-comment.s37", 6, 5)]
        public void CreateFromFile_Reads_The_Expected_Number_Of_Elements(string fileName, int expectedElementCount, int expectedSRecordCount)
        {
            var document = SRecordDocument.CreateFromFile(fileName);
            Assert.Equal(expectedElementCount, document.Elements.Count);
            Assert.Equal(expectedSRecordCount, document.SRecords.Count());
        }
        
        [Theory]
        [InlineData(@"_TestData\FakeFirmware.s37", 6, 6)]
        [InlineData(@"_TestData\FakeFirmware.s19", 7 ,7)]
        [InlineData(@"_TestData\BadFirmware-corrupt-checksum-with-eol-comment.s37", 6, 5)]
        public async void CreateFromFileAsync_Reads_The_Expected_Number_Of_Elements(string fileName, int expectedElementCount, int expectedSRecordCount)
        {
            var document = await SRecordDocument.CreateFromFileAsync(fileName);
            Assert.Equal(expectedElementCount, document.Elements.Count);
            Assert.Equal(expectedSRecordCount, document.SRecords.Count());
        }


        [Theory]
        [InlineData(@"_TestData\FakeFirmware.s37", "s37-good.out", @"_TestData\FakeFirmware.s37")]
        [InlineData(@"_TestData\FakeFirmware.s19", "s19-good.out", @"_TestData\FakeFirmware.s19")]
        [InlineData(@"_TestData\BadFirmware-corrupt-checksum-with-eol-comment.s37", "s37-bad.out", @"_TestData\BadFirmware-corrupt-checksum-with-eol-comment-line-removed.s37")]
        public void WriteFile_Creates_The_Expected_File(string inputFile, string outputFileName, string nameOfFileWithExpectedContent)
        {
            if (File.Exists(outputFileName)) File.Delete(outputFileName);
            var document = SRecordDocument.CreateFromFile(inputFile);
            document.WriteFile(outputFileName);
            Assert.True(File.Exists(outputFileName));
            // now read and compare the file contents as string data.
            // trim trailing CRLF pairs as those don't matter.
            var expectedContent = File.ReadAllText(nameOfFileWithExpectedContent).Trim();
            var actualContent = File.ReadAllText(outputFileName).Trim();
            Assert.Equal(expectedContent,actualContent);
        }
        
        
        [Theory]
        [InlineData(@"_TestData\FakeFirmware.s37", "s37-good-a.out", @"_TestData\FakeFirmware.s37")]
        [InlineData(@"_TestData\FakeFirmware.s19", "s19-good-a.out", @"_TestData\FakeFirmware.s19")]
        [InlineData(@"_TestData\BadFirmware-corrupt-checksum-with-eol-comment.s37", "s37-bad-a.out", @"_TestData\BadFirmware-corrupt-checksum-with-eol-comment-line-removed.s37")]
        public async void WriteFileAsync_Creates_The_Expected_File(string inputFile, string outputFileName, string nameOfFileWithExpectedContent)
        {
            if (File.Exists(outputFileName)) File.Delete(outputFileName);
            var document = await SRecordDocument.CreateFromFileAsync(inputFile);
            await document.WriteFileAsync(outputFileName);
            Assert.True(File.Exists(outputFileName));
            // now read and compare the file contents as string data.
            // trim trailing CRLF pairs as those don't matter.
            var expectedContent = (await File.ReadAllTextAsync(nameOfFileWithExpectedContent)).Trim();
            var actualContent = (await File.ReadAllTextAsync(outputFileName)).Trim();
            Assert.Equal(expectedContent,actualContent);
        }

        
    }
}