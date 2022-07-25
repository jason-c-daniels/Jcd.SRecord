﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Jcd.SRecord.Examples
{
    internal static class Program
    {
        private static void Main()
        {
            
            DoPerfTest(SRecordDataType.Flexible.S3);
            DoPerfTest(SRecordDataType.Strict.S3);
        }

        private static void DoPerfTest(SRecordDataType type)
        {
            var l = new List<string>();
            Console.WriteLine($"Generating test data for {type.Key} with {type.MaximumDataBytesAllowed} bytes of data each.");
            var data = new byte[type.MaximumDataBytesAllowed];
            for (uint i = 0; i < 1_000_000; i++)
            {
                var bytes = BitConverter.GetBytes(i);
                bytes.CopyTo(data, i % 28);
                l.Add($"{SRecordDataFormatter.Default.Format(new SRecordData(type, i, data))} # with comment.");
            }
            
            Console.WriteLine("Initializing SRecordElementParser");
            for (var i = 0; i < 1000; i++)
            {
                SRecordElementParser.Default.Parse(i,l[i]);
            }

            Console.WriteLine("Timing performance.");
            var sw = new Stopwatch();
            sw.Start();
            var j = 0;
            foreach (var s in l)
            {
                j++;
                SRecordElementParser.Default.Parse(j,s);
            }

            sw.Stop();
            Console.Write(
                $"{l.Count} items containing {type.MaximumDataBytesAllowed} bytes of data parsed in {sw.ElapsedMilliseconds}ms");
            Console.WriteLine($" at a rate of {(l.Count / (double)sw.ElapsedMilliseconds):0.##} items/ms");
        }
    }
}
