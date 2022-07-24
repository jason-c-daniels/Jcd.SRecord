using System;
using System.IO;
using System.Text;
using Jcd.SRecord.IO;
using Jcd.SRecord.Parsers;
using Moq;
using Xunit;

namespace Jcd.SRecord.Tests.IO
{
    public class SRecordLineWriterTests
    {
        [Fact]
        public void Constructor_Throws_When_Parser_Is_Null()
        {
            Assert.ThrowsAny<ArgumentException>(() => 
                new SRecordLineWriter(new MemoryStream(), null));
        }
        
        [Fact]
        public void Constructor_Throws_When_Stream_Is_Null()
        {
            var mockFormatter = new Mock<ISRecordLineFormatter>();
            Assert.ThrowsAny<ArgumentException>(() =>
                new SRecordLineWriter((Stream) null, mockFormatter.Object));
            Assert.ThrowsAny<ArgumentException>(() =>
                new SRecordLineWriter(null, Encoding.UTF8, mockFormatter.Object));
        }
        
        [Fact]
        public void Constructor_Throws_When_StreamWriter_Is_Null()
        {
            var mockFormatter = new Mock<ISRecordLineFormatter>();
            Assert.ThrowsAny<ArgumentException>(() =>
                new SRecordLineWriter((StreamWriter) null, mockFormatter.Object));
        }

        [Fact]
        public void Constructor_Does_Not_Throw_When_Both_Parameters_Are_Not_Null()
        {
            var mockFormatter = new Mock<ISRecordLineFormatter>();
            using (new SRecordLineWriter(new MemoryStream(), mockFormatter.Object)){}
            using (new SRecordLineWriter(new MemoryStream(), Encoding.UTF8, mockFormatter.Object)){}
            using (new SRecordLineWriter(new StreamWriter(new MemoryStream()), mockFormatter.Object)){}
        }
        
        [Fact]
        public void WriteLine_Writes_A_Line()
        {
            var expectedText = "the original line\r\n";
            
            var mockFormatter = new Mock<ISRecordLineFormatter>();
            mockFormatter.Setup(m => m.Format(It.IsAny<SRecordLine>()))
                .Returns<SRecordLine>((line) => $"{line.OriginalLine}");
            var stream=new MemoryStream();
            using var writer = new SRecordLineWriter(stream, mockFormatter.Object);
            var line = new SRecordLine(1, SRecordLineType.SRecordWithEndOfLineComment, null, null, expectedText.TrimEnd());
            writer.WriteLine(line);
            var bytes = stream.ToArray();
            var text = Encoding.UTF8.GetString(bytes);
            Assert.Equal(expectedText,text.TrimStart());
        }

        [Fact]
        public async void WriteLineAsync_Writes_A_Line()
        {
            var expectedText = "the original line\r\n";
            
            var mockFormatter = new Mock<ISRecordLineFormatter>();
            mockFormatter.Setup(m => m.Format(It.IsAny<SRecordLine>()))
                .Returns<SRecordLine>((line) => $"{line.OriginalLine}");
            var stream=new MemoryStream();
            using var writer = new SRecordLineWriter(stream, mockFormatter.Object);
            var line = new SRecordLine(1, SRecordLineType.SRecordWithEndOfLineComment, null, null, expectedText.TrimEnd());
            await writer.WriteLineAsync(line);
            var bytes = stream.ToArray();
            var text = Encoding.UTF8.GetString(bytes).TrimStart();
            Assert.Equal(expectedText,text);
        }
        
        [Fact]
        public void WriteLines_Writes_The_Expected_Lines()
        {
            var line1Text = "the original line";
            var line2Text = "the original line 2";
            var expectedText = "the original line\r\nthe original line 2\r\n";
            
            var mockFormatter = new Mock<ISRecordLineFormatter>();
            mockFormatter.Setup(m => m.Format(It.IsAny<SRecordLine>()))
                .Returns<SRecordLine>((line) => $"{line.OriginalLine}");
            var stream=new MemoryStream();
            using var writer = new SRecordLineWriter(stream, mockFormatter.Object);
            var line1 = new SRecordLine(1, SRecordLineType.SRecordWithEndOfLineComment, null, null, line1Text);
            var line2 = new SRecordLine(1, SRecordLineType.SRecordWithEndOfLineComment, null, null, line2Text);
            writer.WriteLines(new[]{line1,line2});
            var bytes = stream.ToArray();
            var text = Encoding.UTF8.GetString(bytes);
            Assert.Equal(expectedText,text.TrimStart());
        }

        [Fact]
        public async void WriteLinesAsync_Writes_The_Expected_Lines()
        {
            var line1Text = "the original line";
            var line2Text = "the original line 2";
            var expectedText = "the original line\r\nthe original line 2\r\n";
            
            var mockFormatter = new Mock<ISRecordLineFormatter>();
            mockFormatter.Setup(m => m.Format(It.IsAny<SRecordLine>()))
                .Returns<SRecordLine>((line) => $"{line.OriginalLine}");
            var stream=new MemoryStream();
            using var writer = new SRecordLineWriter(stream, mockFormatter.Object);
            var line1 = new SRecordLine(1, SRecordLineType.SRecordWithEndOfLineComment, null, null, line1Text);
            var line2 = new SRecordLine(1, SRecordLineType.SRecordWithEndOfLineComment, null, null, line2Text);
            await writer.WriteLinesAsync(new[]{line1,line2});
            var bytes = stream.ToArray();
            var text = Encoding.UTF8.GetString(bytes);
            Assert.Equal(expectedText,text.TrimStart());
        }
    }
}