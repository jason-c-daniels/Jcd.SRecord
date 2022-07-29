using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace Jcd.SRecord.Tests
{
    public class SRecordElementWriterTests
    {
        [Fact]
        public void Constructor_Throws_When_Parser_Is_Null()
        {
            Assert.ThrowsAny<ArgumentException>(() => 
                new SRecordElementWriter(new MemoryStream(), null));
        }
        
        [Fact]
        public void Constructor_Throws_When_Stream_Is_Null()
        {
            var mockFormatter = new Mock<ISRecordElementFormatter>();
            Assert.ThrowsAny<ArgumentException>(() =>
                new SRecordElementWriter((Stream) null, mockFormatter.Object));
            Assert.ThrowsAny<ArgumentException>(() =>
                new SRecordElementWriter(null, Encoding.UTF8, mockFormatter.Object));
        }
        
        [Fact]
        public void Constructor_Throws_When_StreamWriter_Is_Null()
        {
            var mockFormatter = new Mock<ISRecordElementFormatter>();
            Assert.ThrowsAny<ArgumentException>(() =>
                new SRecordElementWriter((StreamWriter) null, mockFormatter.Object));
        }

        [Fact]
        public void Constructor_Does_Not_Throw_When_Both_Parameters_Are_Not_Null()
        {
            var mockFormatter = new Mock<ISRecordElementFormatter>();
            using (new SRecordElementWriter(new MemoryStream(), mockFormatter.Object)){}
            using (new SRecordElementWriter(new MemoryStream(), Encoding.UTF8, mockFormatter.Object)){}
            using (new SRecordElementWriter(new StreamWriter(new MemoryStream()), mockFormatter.Object)){}
        }
        
        [Fact]
        public void Write_Writes_A_Line()
        {
            var expectedText = "the original line\r\n";
            
            var mockFormatter = new Mock<ISRecordElementFormatter>();
            mockFormatter.Setup(m => m.Format(It.IsAny<SRecordElement>()))
                .Returns<SRecordElement>((line) => $"{line.OriginalLine}");
            var stream=new MemoryStream();
            using var writer = new SRecordElementWriter(stream, mockFormatter.Object);
            var line = new SRecordElement(1, SRecordElementType.SRecordWithEndOfElementComment, null, null, expectedText.TrimEnd());
            writer.Write(line);
            var bytes = stream.ToArray();
            var text = Encoding.UTF8.GetString(bytes);
            Assert.Equal(expectedText.Replace("\r\n","\n"),text.TrimStart().Replace("\r\n","\n"));
        }

        [Fact]
        public async void WriteAsync_Writes_A_Line()
        {
            var expectedText = "the original line\r\n";
            
            var mockFormatter = new Mock<ISRecordElementFormatter>();
            mockFormatter.Setup(m => m.Format(It.IsAny<SRecordElement>()))
                .Returns<SRecordElement>((line) => $"{line.OriginalLine}");
            var stream=new MemoryStream();
            using var writer = new SRecordElementWriter(stream, mockFormatter.Object);
            var line = new SRecordElement(1, SRecordElementType.SRecordWithEndOfElementComment, null, null, expectedText.TrimEnd());
            await writer.WriteAsync(line);
            var bytes = stream.ToArray();
            var text = Encoding.UTF8.GetString(bytes).TrimStart();
            Assert.Equal(expectedText.Replace("\r\n","\n"),text.TrimStart().Replace("\r\n","\n"));
        }
        
        [Fact]
        public void Write_With_Enumerable_Writes_The_Expected_Lines()
        {
            var line1Text = "the original line";
            var line2Text = "the original line 2";
            var expectedText = "the original line\r\nthe original line 2\r\n";
            
            var mockFormatter = new Mock<ISRecordElementFormatter>();
            mockFormatter.Setup(m => m.Format(It.IsAny<SRecordElement>()))
                .Returns<SRecordElement>((line) => $"{line.OriginalLine}");
            var stream=new MemoryStream();
            using var writer = new SRecordElementWriter(stream, mockFormatter.Object);
            var line1 = new SRecordElement(1, SRecordElementType.SRecordWithEndOfElementComment, null, null, line1Text);
            var line2 = new SRecordElement(1, SRecordElementType.SRecordWithEndOfElementComment, null, null, line2Text);
            writer.Write(new[]{line1,line2});
            var bytes = stream.ToArray();
            var text = Encoding.UTF8.GetString(bytes);
            Assert.Equal(expectedText.Replace("\r\n","\n"),text.TrimStart().Replace("\r\n","\n"));
        }

        [Fact]
        public async void WriteAsync_With_Enumerable_Writes_The_Expected_Lines()
        {
            var line1Text = "the original line";
            var line2Text = "the original line 2";
            var expectedText = "the original line\nthe original line 2\n";
            
            var mockFormatter = new Mock<ISRecordElementFormatter>();
            mockFormatter.Setup(m => m.Format(It.IsAny<SRecordElement>()))
                .Returns<SRecordElement>((line) => $"{line.OriginalLine}");
            var stream=new MemoryStream();
            using var writer = new SRecordElementWriter(stream, mockFormatter.Object);
            var line1 = new SRecordElement(1, SRecordElementType.SRecordWithEndOfElementComment, null, null, line1Text);
            var line2 = new SRecordElement(1, SRecordElementType.SRecordWithEndOfElementComment, null, null, line2Text);
            await writer.WriteAsync(new[]{line1,line2});
            var bytes = stream.ToArray();
            var text = Encoding.UTF8.GetString(bytes);
            Assert.Equal(expectedText.Replace("\r\n","\n"),text.TrimStart().Replace("\r\n","\n"));
        }
        
        [Fact]
        public async void WriteAsync_With_IAsyncEnumerable_Writes_The_Expected_Lines()
        {
            var line1Text = "the original line";
            var line2Text = "the original line 2";
            var expectedText = "the original line\r\nthe original line 2\r\n";
            
            var mockFormatter = new Mock<ISRecordElementFormatter>();
            mockFormatter.Setup(m => m.Format(It.IsAny<SRecordElement>()))
                .Returns<SRecordElement>((line) => $"{line.OriginalLine}");
            var stream=new MemoryStream();
            using var writer = new SRecordElementWriter(stream, mockFormatter.Object);
            var line1 = new SRecordElement(1, SRecordElementType.SRecordWithEndOfElementComment, null, null, line1Text);
            var line2 = new SRecordElement(1, SRecordElementType.SRecordWithEndOfElementComment, null, null, line2Text);
            await writer.WriteAsync(AsyncEnumerableData(new[]{line1,line2}));
            var bytes = stream.ToArray();
            var text = Encoding.UTF8.GetString(bytes);
            Assert.Equal(expectedText.Replace("\r\n","\n"),text.TrimStart().Replace("\r\n","\n"));
        }
        
        async IAsyncEnumerable<T> AsyncEnumerableData<T>(IEnumerable<T> data)
        {
            foreach (var item in data)
                yield return await Task.FromResult(item);
        }
    }
}