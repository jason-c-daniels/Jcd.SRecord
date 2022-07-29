using System;
using System.Collections.Generic;
using Xunit;

namespace Jcd.SRecord.Tests
{
    public class SRecordDataStatisticsTests
    {
        [Fact]
        public void Constructor_Correctly_Initializes_Counts()
        {
            var sut = new SRecordDataStatistics();
            Assert.Equal(0,sut.S0Count);
            Assert.Equal(0,sut.S1Count);
            Assert.Equal(0,sut.S2Count);
            Assert.Equal(0,sut.S3Count);
            Assert.Equal(0,sut.S4Count);
            Assert.Equal(0,sut.S5Count);
            Assert.Equal(0,sut.S6Count);
            Assert.Equal(0,sut.S7Count);
            Assert.Equal(0,sut.S8Count);
            Assert.Equal(0,sut.S9Count);
            Assert.Equal(0, sut.HeaderCount);
            Assert.Equal(0, sut.DataRecordCount);
            Assert.Equal(0, sut.CounterRecordCount);
            Assert.Equal(0, sut.StartAddressRecordCount);
            Assert.Equal(0, sut.TotalSRecordDataCount);
            Assert.Equal(-1, sut.MaximumDataLength);
        }
        
        [Fact]
        public void Reset_Correctly_Reinitializes_Counts()
        {
            var sut = new SRecordDataStatistics();
            var type = SRecordDataType.Flexible.S1;
            var smallRecord = CreateSRecordData(type, 32);
            sut.Increment(smallRecord);
            sut.Reset();
            Assert.Equal(0,sut.S0Count);
            Assert.Equal(0,sut.S1Count);
            Assert.Equal(0,sut.S2Count);
            Assert.Equal(0,sut.S3Count);
            Assert.Equal(0,sut.S4Count);
            Assert.Equal(0,sut.S5Count);
            Assert.Equal(0,sut.S6Count);
            Assert.Equal(0,sut.S7Count);
            Assert.Equal(0,sut.S8Count);
            Assert.Equal(0,sut.S9Count);
            Assert.Equal(0, sut.HeaderCount);
            Assert.Equal(0, sut.DataRecordCount);
            Assert.Equal(0, sut.CounterRecordCount);
            Assert.Equal(0, sut.StartAddressRecordCount);
            Assert.Equal(0, sut.TotalSRecordDataCount);
            Assert.Equal(-1, sut.MaximumDataLength);
        }
        
        [Theory]
        [InlineData("S0",0x20)]
        [InlineData("S1",0x40)]
        [InlineData("S2",0x60)]
        [InlineData("S3",0x80)]
        [InlineData("S4",0xA0)]
        [InlineData("S5",0x0)]
        [InlineData("S6",0x0)]
        [InlineData("S7",0x0)]
        [InlineData("S8",0x0)]
        [InlineData("S9",0x0)]
        public void Increment_Correctly_Increments_Counters(string typeKey, int bufferSize)
        {
            var dataRecordTypes = new HashSet<SRecordDataType>(new[] { SRecordDataType.Flexible.S1, SRecordDataType.Flexible.S2, SRecordDataType.Flexible.S3 });
            var startAddressRecordTypes = new HashSet<SRecordDataType>(new[] { SRecordDataType.Flexible.S7, SRecordDataType.Flexible.S8, SRecordDataType.Flexible.S9 });
            var countRecordTypes = new HashSet<SRecordDataType>(new[] { SRecordDataType.Flexible.S5, SRecordDataType.Flexible.S6 });
            var sut = new SRecordDataStatistics();
            var type = SRecordDataType.Flexible.FromKey(typeKey);
            var expectedHeaderCount = type == SRecordDataType.Flexible.S0 ? 1 : 0;
            var expectedDataRecordCount = dataRecordTypes.Contains(type) ? 1 : 0;
            var expectedCountRecordCount = countRecordTypes.Contains(type) ? 1 : 0;
            var expectedStartAddressRecordCount = startAddressRecordTypes.Contains(type) ? 1 : 0;
            
            var record = CreateSRecordData(type, bufferSize);
            sut.Increment(record);
            Assert.Equal(bufferSize,sut.MaximumDataLength);
            if (type == SRecordDataType.Flexible.S0) Assert.Equal(1,sut.S0Count);
            if (type == SRecordDataType.Flexible.S1) Assert.Equal(1,sut.S1Count);
            if (type == SRecordDataType.Flexible.S2) Assert.Equal(1,sut.S2Count);
            if (type == SRecordDataType.Flexible.S3) Assert.Equal(1,sut.S3Count);
            if (type == SRecordDataType.Flexible.S4) Assert.Equal(1,sut.S4Count);
            if (type == SRecordDataType.Flexible.S5) Assert.Equal(1,sut.S5Count);
            if (type == SRecordDataType.Flexible.S6) Assert.Equal(1,sut.S6Count);
            if (type == SRecordDataType.Flexible.S7) Assert.Equal(1,sut.S7Count);
            if (type == SRecordDataType.Flexible.S8) Assert.Equal(1,sut.S8Count);
            if (type == SRecordDataType.Flexible.S9) Assert.Equal(1,sut.S9Count);
            Assert.Equal(expectedHeaderCount, sut.HeaderCount);
            Assert.Equal(expectedDataRecordCount, sut.DataRecordCount);
            Assert.Equal(expectedCountRecordCount, sut.CounterRecordCount);
            Assert.Equal(expectedStartAddressRecordCount, sut.StartAddressRecordCount);
            Assert.Equal(1, sut.TotalSRecordDataCount);
        }
        
        [Theory]
        [InlineData("S0",0x20)]
        [InlineData("S1",0x40)]
        [InlineData("S2",0x60)]
        [InlineData("S3",0x80)]
        [InlineData("S4",0xA0)]
        [InlineData("S5",0x0)]
        [InlineData("S6",0x0)]
        [InlineData("S7",0x0)]
        [InlineData("S8",0x0)]
        [InlineData("S9",0x0)]
        public void Increment_Twice_Then_Decrement_Once_Correctly_Computes_Counters(string typeKey, int bufferSize)
        {
            var dataRecordTypes = new HashSet<SRecordDataType>(new[] { SRecordDataType.Flexible.S1, SRecordDataType.Flexible.S2, SRecordDataType.Flexible.S3 });
            var startAddressRecordTypes = new HashSet<SRecordDataType>(new[] { SRecordDataType.Flexible.S7, SRecordDataType.Flexible.S8, SRecordDataType.Flexible.S9 });
            var countRecordTypes = new HashSet<SRecordDataType>(new[] { SRecordDataType.Flexible.S5, SRecordDataType.Flexible.S6 });
            var sut = new SRecordDataStatistics();
            var type = SRecordDataType.Flexible.FromKey(typeKey);
            var expectedHeaderCount = type == SRecordDataType.Flexible.S0 ? 1 : 0;
            var expectedDataRecordCount = dataRecordTypes.Contains(type) ? 1 : 0;
            var expectedCountRecordCount = countRecordTypes.Contains(type) ? 1 : 0;
            var expectedStartAddressRecordCount = startAddressRecordTypes.Contains(type) ? 1 : 0;
            
            var record = CreateSRecordData(type, bufferSize);
            sut.Increment(record);
            sut.Increment(record);
            sut.Decrement(record);
            Assert.Equal(bufferSize,sut.MaximumDataLength);
            if (type == SRecordDataType.Flexible.S0) Assert.Equal(1,sut.S0Count);
            if (type == SRecordDataType.Flexible.S1) Assert.Equal(1,sut.S1Count);
            if (type == SRecordDataType.Flexible.S2) Assert.Equal(1,sut.S2Count);
            if (type == SRecordDataType.Flexible.S3) Assert.Equal(1,sut.S3Count);
            if (type == SRecordDataType.Flexible.S4) Assert.Equal(1,sut.S4Count);
            if (type == SRecordDataType.Flexible.S5) Assert.Equal(1,sut.S5Count);
            if (type == SRecordDataType.Flexible.S6) Assert.Equal(1,sut.S6Count);
            if (type == SRecordDataType.Flexible.S7) Assert.Equal(1,sut.S7Count);
            if (type == SRecordDataType.Flexible.S8) Assert.Equal(1,sut.S8Count);
            if (type == SRecordDataType.Flexible.S9) Assert.Equal(1,sut.S9Count);
            Assert.Equal(expectedHeaderCount, sut.HeaderCount);
            Assert.Equal(expectedDataRecordCount, sut.DataRecordCount);
            Assert.Equal(expectedCountRecordCount, sut.CounterRecordCount);
            Assert.Equal(expectedStartAddressRecordCount, sut.StartAddressRecordCount);
            Assert.Equal(1, sut.TotalSRecordDataCount);
        }

        [Fact]
        public void Decrement_Correctly_Tracks_Current_MaximumDataLength()
        {
            var type = SRecordDataType.Flexible.S1;
            var smallRecord = CreateSRecordData(type, 32);
            var mediumRecord = CreateSRecordData(type, 64);
            var longRecord = CreateSRecordData(type, 128);
            var sut = new SRecordDataStatistics();
            sut.Increment(smallRecord);
            Assert.Equal(smallRecord.Data.Length,sut.MaximumDataLength);
            sut.Increment(mediumRecord);
            Assert.Equal(mediumRecord.Data.Length,sut.MaximumDataLength);
            sut.Increment(longRecord);
            Assert.Equal(longRecord.Data.Length,sut.MaximumDataLength);
            sut.Decrement(longRecord);
            Assert.Equal(mediumRecord.Data.Length,sut.MaximumDataLength);
            sut.Decrement(mediumRecord);
            Assert.Equal(smallRecord.Data.Length,sut.MaximumDataLength);
            sut.Decrement(smallRecord);
        }

        [Fact]
        public void Decrement_Throws_An_Exception_When_Called_Too_Many_Times()
        {
            var type = SRecordDataType.Flexible.S1;
            var smallRecord = CreateSRecordData(type, 32);
            var sut = new SRecordDataStatistics();
            Assert.ThrowsAny<Exception>(()=>sut.Decrement(smallRecord));
            sut.Increment(smallRecord);
            sut.Reset();
            Assert.ThrowsAny<Exception>(()=>sut.Decrement(smallRecord));
            sut.Reset();
            sut.Increment(smallRecord);
            sut.Decrement(smallRecord);
            Assert.ThrowsAny<Exception>(()=>sut.Decrement(smallRecord));
        }
        
        private static SRecordData CreateSRecordData(SRecordDataType type, int bufferSize)
        {
            var buffer = new byte[bufferSize];
            var record = new SRecordData(type, 0x01, new ReadOnlyMemory<byte>(buffer));
            return record;
        }
        
    }
}