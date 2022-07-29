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
        [InlineData(@"_TestData","FakeFirmware.s37", 6, 6)]
        [InlineData(@"_TestData","FakeFirmware.s19", 7 ,7)]
        [InlineData(@"_TestData","BadFirmware-corrupt-checksum-with-eol-comment.s37", 6, 5)]
        public void CreateFromFile_Reads_The_Expected_Number_Of_Elements(string folder, string fileName, int expectedElementCount, int expectedSRecordCount)
        {
            var filePath = Path.Combine(folder, fileName);
            var document = SRecordDocument.CreateFromFile(filePath);
            Assert.Equal(expectedElementCount, document.Elements.Count);
            Assert.Equal(expectedSRecordCount, document.SRecords.Count());
        }
        
        [Theory]
        [InlineData(@"_TestData","FakeFirmware.s37", 6, 6)]
        [InlineData(@"_TestData","FakeFirmware.s19", 7 ,7)]
        [InlineData(@"_TestData","BadFirmware-corrupt-checksum-with-eol-comment.s37", 6, 5)]
        public async void CreateFromFileAsync_Reads_The_Expected_Number_Of_Elements(string folder, string fileName, int expectedElementCount, int expectedSRecordCount)
        {
            var filePath = Path.Combine(folder, fileName);
            var document = await SRecordDocument.CreateFromFileAsync(filePath);
            Assert.Equal(expectedElementCount, document.Elements.Count);
            Assert.Equal(expectedSRecordCount, document.SRecords.Count());
        }

        [Theory]
        [InlineData(@"_TestData","FakeFirmware.s37", "s37-good.out", @"FakeFirmware.s37")]
        [InlineData(@"_TestData","FakeFirmware.s19", "s19-good.out", @"FakeFirmware.s19")]
        [InlineData(@"_TestData","BadFirmware-corrupt-checksum-with-eol-comment.s37", "s37-bad.out", @"BadFirmware-corrupt-checksum-with-eol-comment-line-removed.s37")]
        public void WriteFile_Creates_The_Expected_File(string folder,string inputFile, string outputFileName, string nameOfFileWithExpectedContent)
        {
            var inputFilePath = Path.Combine(folder, inputFile);
            var outputFilePath = Path.Combine(folder, outputFileName);
            var expectedContentPath = Path.Combine(folder, nameOfFileWithExpectedContent);
            if (File.Exists(outputFilePath)) File.Delete(outputFilePath);
            var document = SRecordDocument.CreateFromFile(inputFilePath);
            document.WriteFile(outputFilePath);
            Assert.True(File.Exists(outputFilePath));
            // now read and compare the file contents as string data.
            // convert \r\n to \n to make this UT run correctly on any platform.
            // trim trailing CRLF pairs as those don't matter.
            var expectedContent = File.ReadAllText(expectedContentPath).Trim().Replace("\r\n","\n");
            var actualContent = File.ReadAllText(outputFilePath).Trim().Replace("\r\n","\n");
            Assert.Equal(expectedContent,actualContent);
        }
        
        
        [Theory]
        [InlineData(@"_TestData","FakeFirmware.s37", "s37-good-a.out", @"FakeFirmware.s37")]
        [InlineData(@"_TestData","FakeFirmware.s19", "s19-good-a.out", @"FakeFirmware.s19")]
        [InlineData(@"_TestData","BadFirmware-corrupt-checksum-with-eol-comment.s37", "s37-bad-a.out", @"BadFirmware-corrupt-checksum-with-eol-comment-line-removed.s37")]
        public async void WriteFileAsync_Creates_The_Expected_File(string folder, string inputFile, string outputFileName, string nameOfFileWithExpectedContent)
        {
            var inputFilePath = Path.Combine(folder, inputFile);
            var outputFilePath = Path.Combine(folder, outputFileName);
            var expectedContentPath = Path.Combine(folder, nameOfFileWithExpectedContent);
            if (File.Exists(outputFilePath)) File.Delete(outputFilePath);
            var document = await SRecordDocument.CreateFromFileAsync(inputFilePath);
            await document.WriteFileAsync(outputFilePath);
            Assert.True(File.Exists(outputFilePath));
            // now read and compare the file contents as string data.
            // convert \r\n to \n to make this UT run correctly on any platform.
            // trim trailing CRLF pairs as those don't matter.
            var expectedContent = (await File.ReadAllTextAsync(expectedContentPath)).Trim().Replace("\r\n","\n");
            var actualContent = (await File.ReadAllTextAsync(outputFilePath)).Trim().Replace("\r\n","\n");
            Assert.Equal(expectedContent,actualContent);
        }
    }
}