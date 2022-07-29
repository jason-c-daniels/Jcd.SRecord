using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Jcd.SRecord.Examples
{
    internal static class Program
    {
        private const int RecordsToGenerate = 0xFFFF+1;
        private static void Main()
        {
            // read all of the data, tracking the parse result for each line.
            var document = SRecordDocument.CreateFromFile("FakeFirmware.s37");
            
            // compute some statistics.
            var parsingStats = document.CalculateParseStatistics();
            var dataStats = document.CalculateDataStatistics();
            
            // Report on what's in the file. 
            Console.WriteLine($"Record type counts:");
            Console.WriteLine($"S0 {dataStats.S0Count}; S1 {dataStats.S1Count}; S2 {dataStats.S2Count}; S3 {dataStats.S3Count}; S4 {dataStats.S4Count}; S5 {dataStats.S5Count}; S6 {dataStats.S6Count}; S7 {dataStats.S7Count}; S8 {dataStats.S8Count}; S9: {dataStats.S9Count}");
            Console.WriteLine();
            Console.WriteLine($"Parsing stats:");
            Console.WriteLine($"Total number of blank lines: {parsingStats.BlankElementCount}");
            Console.WriteLine($"Total number of lines with parsing errors: {parsingStats.ErrorElementCount}");
            Console.WriteLine($"Total number of stand alone comment lines: {parsingStats.StandAloneCommentCount}");
            Console.WriteLine($"Total number of lines with comments: {parsingStats.ElementsWithCommentsCount}");
            Console.WriteLine($"Total number of lines with s-record entries: {parsingStats.ElementsWithSRecordDataCount}");
            Console.WriteLine($"Total number of lines with comments and s-record entries: {parsingStats.SRecordDataWithCommentCount}");
            Console.WriteLine($"Total line count: {parsingStats.TotalElementsCount}");

            // now access the data and upload the firmware to a device.
            foreach (var record in document.SRecords)
            {
                // get a byte array if it's S1, S2, S3 and send firmware to the device.
                if (record.Type.Key == "S1" || record.Type.Key == "S2" || record.Type.Key == "S3")
                    UploadToFirmware(record.Address, record.Type.AddressLengthInBytes, record.Data.ToArray());
                // set the execution address if S7, S8, or S9
                else if (record.Type.Key == "S7" || record.Type.Key == "S8" || record.Type.Key == "S9")
                    SetExecutionAddress(record.Address,record.Type.AddressLengthInBytes);
            }
            
            Console.WriteLine("Type,Payload Bytes,Record Count,Scenario Name,Duration(ms),Records/ms");
            var elapsed=CaptureActionTiming(() =>
            {
                DoPerfTestForAllRecordTypes(SRecordDataType.Flexible.TypeLookup);
                DoPerfTestForAllRecordTypes(SRecordDataType.Strict.TypeLookup);
            });
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Total execution time, {elapsed.TotalMilliseconds:n2}");
        }

        private static void SetExecutionAddress(uint recordAddress, byte addressLengthInBytes)
        {
            // implementation defined.
        }
        private static void UploadToFirmware(uint recordAddress, byte addressLengthInBytes, byte[] dataBytes)
        {
            // implementation defined.
        }

        private static void DoPerfTestForAllRecordTypes(IDictionary<string, SRecordDataType> lookup)
        {
            var dict = new SortedDictionary<string, SRecordDataType>(lookup); 
            foreach (var entry in dict)
            {
                DoPerfTests(entry.Value);
            }
        }

        private static void DoPerfTests(SRecordDataType type)
        {
            var linesWithComments = new List<string>();
            var linesWithoutComments = new List<string>();
            var linesOfTextWithComments=GenerateLines(linesWithComments,RecordsToGenerate, type,null,"{0} # some relatively brief comment.");
            var linesOfTextWithoutComments=GenerateLines(linesWithoutComments,RecordsToGenerate, type);
            var readerNoComments = new SRecordElementReader(linesOfTextWithoutComments, SRecordElementParser.Default);
            var readerWithComments = new SRecordElementReader(linesOfTextWithComments, SRecordElementParser.Default);
            var readerNoCommentsForDocument = new SRecordElementReader(linesOfTextWithoutComments, SRecordElementParser.Default);
            var readerWithCommentsForDocument = new SRecordElementReader(linesOfTextWithComments, SRecordElementParser.Default);
            var document1 = new SRecordDocument();
            var document2 = new SRecordDocument();
            
            TestSRecordDataParser(type, linesWithoutComments);
            TestSRecordElementParser("SRecordElementParser no comments", type, linesWithoutComments);
            TestSRecordElementParser("SRecordElementParser with comments", type, linesWithComments);
            TestSRecordElementReader("SRecordElementReader no comments", type, RecordsToGenerate, readerNoComments);
            TestSRecordElementReader("SRecordElementReader with comments", type, RecordsToGenerate, readerWithComments);
            TestSRecordDocument("SRecordDocument no comments", type, RecordsToGenerate, readerNoCommentsForDocument,document1);
            TestSRecordDocument("SRecordDocument with comments", type, RecordsToGenerate, readerWithCommentsForDocument,document2);
            TestDocumentEnumerateSRecords(type, document1);
            TestDocumentSRecordsToList(type, document1);
            TestSRecordDataStatisticsGeneration(type, document1);
            TestSRecordElementStatisticsGeneration(type, document1);
        }

        private static void TestDocumentSRecordsToList(SRecordDataType type, SRecordDocument document)
        {
            ReportTimingForScenario("Generate List<SRecordData> from document.SRecords.ToList()", document.SRecords.Count(), type, () =>
            {
                var records = document.SRecords.ToList();
            });
        }
        
        private static void TestDocumentEnumerateSRecords(SRecordDataType type, SRecordDocument document)
        {
            int i = 0;
            ReportTimingForScenario("Enumerate document.SRecords via foreach", document.SRecords.Count(), type, () =>
            {
                foreach (var record in document.SRecords)
                    i++;
            });
            var bleh = i + 2;
        }

        private static void TestSRecordDataStatisticsGeneration(SRecordDataType type, SRecordDocument document)
        {
            var records = document.SRecords.ToList();
            var stats = new SRecordDataStatistics();
            ReportTimingForScenario("Generate SRecordDataStatistics (Increment)", records.Count, type, () =>
            {
                foreach (var record in records)
                {
                    stats.Increment(record);
                }
            });
            
            ReportTimingForScenario("Generate SRecordDataStatistics (Decrement)", records.Count, type, () =>
            {
                foreach (var record in records)
                {
                    stats.Decrement(record);
                }
            });
        }

        private static void TestSRecordElementStatisticsGeneration(SRecordDataType type, SRecordDocument document)
        {
            var stats = new SRecordElementStatistics();
            ReportTimingForScenario("Generate SRecordElementStatistics (Increment)", document.Elements.Count, type, () =>
            {
                foreach (var element in document.Elements)
                {
                    stats.Increment(element);
                }
            });
            ReportTimingForScenario("Generate SRecordElementStatistics (Decrement)", document.Elements.Count, type, () =>
            {
                foreach (var element in document.Elements)
                {
                    stats.Increment(element);
                }
            });
        }
        
        private static void TestSRecordElementParser(string scenario, SRecordDataType type, List<string> lines)
        {
            ReportTimingForScenario(scenario, lines.Count, type, () =>
            {
                var j = 0;
                foreach (var s in lines)
                {
                    j++;
                    SRecordElementParser.Default.Parse(j, s);
                }
            });
        }

        private static void TestSRecordDataParser(SRecordDataType type, List<string> lines)
        {
            ReportTimingForScenario("SRecordDataParser", lines.Count, type, () =>
            {
                foreach (var s in lines)
                {
                    SRecordDataParser.Default.Parse(s);
                }
            });
        }

        private static void TestSRecordElementReader(string scenario, SRecordDataType type, int count, SRecordElementReader reader)
        {
            ReportTimingForScenario(scenario, count, type, () =>
            {
                while (!reader.EndOfData)
                    reader.Read();
            });
        }

        private static void TestSRecordDocument(string scenario, SRecordDataType type, int count, SRecordElementReader reader, SRecordDocument document)
        {
            ReportTimingForScenario(scenario, count, type, () =>
            {
                document.Read(reader);
            });
        }
        
        private static string GenerateLines(List<string> lines, int count, SRecordDataType type, SRecordDataFormatter formatter=null, string formatString=null)
        {
            if (string.IsNullOrWhiteSpace(formatString))
                formatString = "{0}";
            
            formatter ??= SRecordDataFormatter.Default;
            lines.Clear();
            var data = new byte[type.MaximumDataBytesAllowed];
            var modulo = Math.Min((byte)28, type.MaximumDataBytesAllowed);
            for (uint i = 0; i < count; i++)
            {
                if (modulo > 4)
                {
                    var bytes = BitConverter.GetBytes(i);
                    bytes.CopyTo(data, i % modulo);
                }

                var recordText = formatter.Format(new SRecordData(type, i % 0xFFFF, data));
                if (!SRecordDataParser.Default.TryParse(recordText, out _))
                {
                    Console.Error.WriteLine("Data formatting error. unable to parse the formatted data correctly.");
                    Console.Error.WriteLine(($"{data.Length} bytes generated for {type.Key} at address {i:X8}, address length of {type.AddressLengthInBytes} bytes."));
                    Console.Error.WriteLine(($"Generated text: {recordText}"));
                    
                    throw new ApplicationException("Internal error. See previous messages.");
                }
                
                lines.Add(string.Format(formatString,recordText));
            }

            return string.Join("\r\n", lines);
        }

        private static void ReportTimingForScenario(string scenario, int count, SRecordDataType type, Action perfAction)
        {
            Console.Write($"{type.Key},{type.MaximumDataBytesAllowed},{count},{scenario},");
            var elapsed = CaptureActionTiming(perfAction);
            Console.Write($"{elapsed.TotalMilliseconds:0.##},{(count / elapsed.TotalMilliseconds):0.##}");
            Console.WriteLine();
            //GC.Collect();
        }

        private static TimeSpan CaptureActionTiming(Action perfAction)
        {
            var sw = new Stopwatch();
            sw.Start();
            perfAction?.Invoke();
            sw.Stop();
            return sw.Elapsed;
        }
    }
}
