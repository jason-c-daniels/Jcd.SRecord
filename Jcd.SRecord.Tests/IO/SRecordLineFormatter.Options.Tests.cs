using Jcd.SRecord.IO;
using Xunit;

namespace Jcd.SRecord.Tests.IO
{
    public class SRecordLineFormatterOptionsTests
    {
        [Theory]
        [InlineData(false,false,false,false,false,false,'!')]
        [InlineData(true,true,true,true,true,true,'*')]
        public void Constructor_Sets_All_Fields_Correctly(
                    bool emitSRecordContent,
                    bool emitComment,
                    bool emitSpaceBeforeEndOfLineComment,
                    bool emitOriginalText,
                    bool emitBlankLineAsEmptyString,
                    bool emitErrorLineAsCommentLine,
                    char commentCharacter            
            )
        {
            var sut = new SRecordLineFormatter.Options(
                emitSRecordContent,
                emitComment,
                emitSpaceBeforeEndOfLineComment,
                emitOriginalText,
                emitBlankLineAsEmptyString,
                emitErrorLineAsCommentLine,
                commentCharacter            
            );
            Assert.Equal(emitSRecordContent,sut.EmitSRecordContent);
            Assert.Equal(emitComment,sut.EmitComment);
            Assert.Equal(emitSpaceBeforeEndOfLineComment,sut.EmitSpaceBeforeEndOfLineComment);
            Assert.Equal(emitOriginalText,sut.EmitOriginalText);
            Assert.Equal(emitBlankLineAsEmptyString,sut.EmitBlankLineAsEmptyString);
            Assert.Equal(emitErrorLineAsCommentLine,sut.EmitErrorLineAsCommentLine);
            Assert.Equal(commentCharacter,sut.CommentCharacter);            
        }

        [Fact]
        public void DefaultOptions_Instance_Is_EmitSRecordAndCommentDataWithSpace()
        {
            Assert.Equal(SRecordLineFormatter.Options.DefaultOptions,SRecordLineFormatter.Options.EmitSRecordAndCommentDataWithSpace);
        }
    }
}