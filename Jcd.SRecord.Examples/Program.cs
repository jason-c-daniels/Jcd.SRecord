using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Jcd.SRecord.Examples
{
    internal static class Program
    {
        private const int RecordsToGenerate = 65536;
        private static void Main()
        {
            
            Console.WriteLine("Type,Payload Bytes,Record Count,Scenario Name,Duration(ms),Records/ms");
            var elapsed=CaptureActionTiming(() =>
            {
                DoPerfTestForAllRecordTypes(SRecordDataType.Flexible.TypeLookup);
                //Console.WriteLine();
                //Console.WriteLine();
                DoPerfTestForAllRecordTypes(SRecordDataType.Strict.TypeLookup);
            });
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Total execution time, {elapsed.TotalMilliseconds:n2}");
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
            //Console.WriteLine($"Generating {RecordsToGenerate:n0} {type.Key} records of test data with {type.MaximumDataBytesAllowed} bytes of data each.");
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
