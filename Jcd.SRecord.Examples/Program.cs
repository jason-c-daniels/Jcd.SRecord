using System;
using System.Collections.Generic;
using System.Diagnostics;
using Jcd.SRecord.IO;

namespace Jcd.SRecord.Examples
{
    internal static class Program
    {
        private static void Main()
        {
            
            DoPerfTest(SRecordType.Flexible.S3);
            DoPerfTest(SRecordType.Strict.S3);
        }

        private static void DoPerfTest(SRecordType type)
        {
            var l = new List<string>();
            Console.WriteLine($"Generating test data for {type.Key} with {type.MaximumDataBytesAllowed} bytes of data each.");
            var data = new byte[type.MaximumDataBytesAllowed];
            for (uint i = 0; i < 100_000; i++)
            {
                var bytes = BitConverter.GetBytes(i);
                bytes.CopyTo(data, i % 28);
                l.Add(SRecordFormatter.Default.Format(new SRecord(type, i, data)));
            }


            Console.WriteLine("Initializing SRecordParser");
            for (var i = 0; i < 1000; i++)
                SRecordParser.Flexible.Parse(l[i]);

            Console.WriteLine("Timing performance.");
            var sw = new Stopwatch();
            sw.Start();
            foreach (var s in l)
            {
                SRecordParser.Flexible.Parse(s);
            }

            sw.Stop();
            Console.Write(
                $"{l.Count} items containing {type.MaximumDataBytesAllowed} bytes of data parsed in {sw.ElapsedMilliseconds}ms");
            Console.WriteLine($" at a rate of {(l.Count / (double)sw.ElapsedMilliseconds):0.##} items/ms");
        }
    }
}
