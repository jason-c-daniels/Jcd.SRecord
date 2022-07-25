using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Moq;
using Xunit;

namespace Jcd.SRecord.Tests
{
    public class SRecordElementReaderTests
    {
        [Fact]
        public void Constructor_Throws_When_Parser_Is_Null()
        {
            Assert.ThrowsAny<ArgumentException>(() =>
                new SRecordElementReader("#some text\r\n#some more text\r#even more\n# lots more", null));
        }
        
        [Fact]
        public void Constructor_Throws_When_Stream_Is_Null()
        {
            var mockParser = new Mock<ISRecordElementParser>();
            Assert.ThrowsAny<ArgumentException>(() =>
                new SRecordElementReader((Stream) null, mockParser.Object));
            Assert.ThrowsAny<ArgumentException>(() =>
                new SRecordElementReader((Stream) null, Encoding.UTF8, mockParser.Object));
        }
        
        [Fact]
        public void Constructor_Throws_When_StreamReader_Is_Null()
        {
            var mockParser = new Mock<ISRecordElementParser>();
            Assert.ThrowsAny<ArgumentException>(() =>
                new SRecordElementReader((StreamReader) null, mockParser.Object));
        }

        [Fact]
        public void Constructor_Does_Not_Throw_When_Both_Parameters_Are_Not_Null()
        {
            var mockParser = new Mock<ISRecordElementParser>();
            var linesOfText = "Elements of text\r\nYep. Two is multiple. therefore lines.";
            using (new SRecordElementReader(linesOfText, mockParser.Object)){}
            using (new SRecordElementReader(new MemoryStream(Encoding.UTF8.GetBytes(linesOfText)), mockParser.Object)){}
            using (new SRecordElementReader(new MemoryStream(Encoding.UTF32.GetBytes(linesOfText)), Encoding.UTF32, mockParser.Object)){}
            using (new SRecordElementReader(new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(linesOfText))), mockParser.Object)){}
        }
        
        [Fact]
        public void EndOfData_Returns_True_When_At_End_Of_Data()
        {
            var mockParser = new Mock<ISRecordElementParser>();
            mockParser.Setup(m => m.Parse(It.IsAny<int>(), It.IsAny<string>()))
                .Returns<int, string>((lineNumber, lineOfText) =>
                    new SRecordElement(lineNumber, SRecordElementType.Error, originalLine: lineOfText));
            
            var linesOfText = "Elements of text";
            using (var reader = new SRecordElementReader(linesOfText, mockParser.Object))
            {
                Assert.False(reader.EndOfData);
                var _=reader.Read();
                Assert.True(reader.EndOfData);
            }
        }

        [Fact]
        public void ReadLine_Reads_A_Line_And_Increments_The_Line_Count()
        {
            var expectedLine = 0;
            var mockParser = new Mock<ISRecordElementParser>();
            mockParser.Setup(m => m.Parse(It.IsAny<int>(), It.IsAny<string>()))
                .Returns<int, string>((lineNumber, lineOfText) =>
                    new SRecordElement(lineNumber, SRecordElementType.Error, originalLine: lineOfText));
            
            const string linesOfText = "Elements of text\r\nYep. Two is multiple, therefore lines.";
            using var reader = new SRecordElementReader(linesOfText, mockParser.Object);
            Assert.Equal(expectedLine, reader.CurrentLine);
            Assert.NotNull(reader.Read());
            expectedLine++;
            Assert.Equal(expectedLine, reader.CurrentLine);
            Assert.NotNull(reader.Read());
            expectedLine++;
            Assert.Equal(expectedLine, reader.CurrentLine);
        }

        
        [Fact]
        public async void ReadLineAsync_Reads_A_Line_And_Increments_The_Line_Count()
        {
            int expectedLine = 0;
            var mockParser = new Mock<ISRecordElementParser>();
            mockParser.Setup(m => m.Parse(It.IsAny<int>(), It.IsAny<string>()))
                .Returns<int, string>((lineNumber, lineOfText) =>
                    new SRecordElement(lineNumber, SRecordElementType.Error, originalLine: lineOfText));
            
            var linesOfText = "Elements of text\r\nYep. Two is multiple. therefore lines.";
            using var reader = new SRecordElementReader(linesOfText, mockParser.Object);
            Assert.Equal(expectedLine, reader.CurrentLine);
            Assert.NotNull(await reader.ReadAsync());
            expectedLine++;
            Assert.Equal(expectedLine, reader.CurrentLine);
            Assert.NotNull(await reader.ReadAsync());
            expectedLine++;
            Assert.Equal(expectedLine, reader.CurrentLine);
        }
        
        
        [Theory]
        [InlineData("",0)]
        [InlineData(" ",1)]
        [InlineData("# ",1)]
        [InlineData("\r",1)]
        [InlineData("\r\n",1)]
        [InlineData("\r\n \n",2)]
        [InlineData("l1\r\nl2 \nl3",3)]
        public void ReadAllLines_Read_The_Correct_Number_Of_Lines(string linesOfText, int expectedCount)
        {
            var mockParser = new Mock<ISRecordElementParser>();
            mockParser.Setup(m => m.Parse(It.IsAny<int>(), It.IsAny<string>()))
                .Returns<int, string>((lineNumber, lineOfText) =>
                    new SRecordElement(lineNumber, SRecordElementType.Error, originalLine: lineOfText));

            using var reader = new SRecordElementReader(linesOfText, mockParser.Object);
            var lines=reader.ReadToEnd().ToArray();
            Assert.Equal(expectedCount, lines.Length);
            mockParser.Verify(m => m.Parse(It.IsAny<int>(), It.IsAny<string>()), Times.Exactly(expectedCount));
        }
        
        [Theory]
        [InlineData("",0)]
        [InlineData(" ",1)]
        [InlineData("# ",1)]
        [InlineData("\r",1)]
        [InlineData("\r\n",1)]
        [InlineData("\r\n \n",2)]
        [InlineData("l1\r\nl2 \nl3",3)]
        public async void ReadAllLinesAsync_Read_The_Correct_Number_Of_Lines(string linesOfText, int expectedCount)
        {
            var mockParser = new Mock<ISRecordElementParser>();
            mockParser.Setup(m => m.Parse(It.IsAny<int>(), It.IsAny<string>()))
                .Returns<int, string>((lineNumber, lineOfText) =>
                    new SRecordElement(lineNumber, SRecordElementType.Error, originalLine: lineOfText));

            using var reader = new SRecordElementReader(linesOfText, mockParser.Object);
            // read all the lines.
            var lines = new List<SRecordElement>();
            await foreach (var line in reader.ReadToEndAsync())
                lines.Add(line);
            
            Assert.Equal(expectedCount, lines.Count);
            mockParser.Verify(m => m.Parse(It.IsAny<int>(), It.IsAny<string>()), Times.Exactly(expectedCount));
        }
        
    }
}