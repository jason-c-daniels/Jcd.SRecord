using System;
using System.Collections.Generic;
using Jcd.SRecord.IO;
using Jcd.SRecord.Parsers;
using Xunit;

namespace Jcd.SRecord.Tests.IO
{
    public class SRecordLineTests
    {
        [Theory]
        [MemberData(nameof(ConstructorData))]
        public void Constructor_Correctly_Populates_All_Data(int lineNumber,
                                                             SRecordLineType lineType,
                                                             SRecord sRecord,
                                                             string comment,
                                                             string originalLine,
                                                             string errorMessage,
                                                             Exception exception
        )
        {
            var sut = new SRecordLine(lineNumber, lineType, sRecord, comment, originalLine, errorMessage, exception);
            Assert.Equal(lineNumber, sut.LineNumber);
            Assert.Equal(lineType, sut.LineType);
            Assert.Same(sRecord,sut.SRecord);
            Assert.Equal(comment, sut.Comment);
            Assert.Equal(originalLine, sut.OriginalLine);
            Assert.Equal(errorMessage, sut.ErrorMessage);
            Assert.Same(exception, sut.Exception);
        }

        public static IEnumerable<object[]> ConstructorData
        {
            get
            {
                var srecText = "S123B600BDB653CC0800FD1018FD101AFD101CFD101EBDB665CC0002DD007F00067F001055";
                var originalWithComment = $"{srecText} # a comment";
                var srec = SRecordParser.Flexible.Parse(srecText);
                return new List<object[]>
                {
                    // lineNumber, lineType, sRecord, comment, originalLine, errorMessage, exception
                    new object[] { 1, SRecordLineType.SRecord, srec, null, srecText, null, null },
                    new object[] { 2, SRecordLineType.SRecordWithEndOfLineComment, srec, "a comment", originalWithComment, null, null },
                    new object[] { 3, SRecordLineType.Error, null, "a comment", originalWithComment, "a simple error", null },
                    new object[] { 4, SRecordLineType.Blank, null, null, "", null, null },
                    new object[] { 5, SRecordLineType.Comment, null, "a stand alone comment", null, null, null },
                    new object[] { 6, SRecordLineType.Error, null, "a comment", originalWithComment, "a complext error", new Exception("an error") },
                };
            }
        }
    }
}