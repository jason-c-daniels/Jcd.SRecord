using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jcd.SRecord.IO;
using Jcd.SRecord.Parsers;

namespace Jcd.SRecord.Files
{
    public class SRecordContainer
        : IList<SRecordLine>,
          IList<SRecord>
    {
        private readonly ISRecordLineParser _parser;
        private readonly ISRecordLineFormatter _formatter;

        private List<SRecordLine> _lines = new List<SRecordLine>();

        private IEnumerable<SRecord> SRecords => _lines
            .Where(x => x.LineType.HasSRecord)
            .Select(x => x.SRecord);
        
        public SRecordContainer(ISRecordLineParser parser=null, ISRecordLineFormatter formatter=null)
        {
            _parser = parser;
            _formatter = formatter;
        }
        
        #region IList<SRecord> overloads
        
        public void Add([NotNull]SRecord sRecord)
        {
            Add(MakeSRecordLine(_lines.Count + 1, sRecord));
        }
        
        public int IndexOf(SRecord item)
        {
            return _lines.FindIndex(srl=> ReferenceEquals(srl.SRecord,item));
        }

        public void Insert(int index, SRecord item)
        {
            Insert(index,MakeSRecordLine(index+1,item));
        }

        SRecord IList<SRecord>.this[int index]
        {
            get => _lines[index].SRecord;
            set => _lines[index].SRecord = value;
        }

        IEnumerator<SRecord> IEnumerable<SRecord>.GetEnumerator()
        {
            return SRecords.GetEnumerator();
        }

        public bool Contains(SRecord item)
        {
            return _lines.Any(x => ReferenceEquals(x.SRecord,item));
        }

        public void CopyTo(SRecord[] array, int arrayIndex)
        {
            foreach (var sRecord in SRecords)
                array[arrayIndex++] = sRecord;
        }

        public bool Remove(SRecord item)
        {
            return _lines.Remove(_lines[IndexOf(item)]);
        }

        public bool Contains(SRecordLine item)
        {
            return _lines.Contains(item);
        }

        public void CopyTo(SRecordLine[] array, int arrayIndex)
        {
            _lines.CopyTo(array, arrayIndex);
        }

        public bool Remove(SRecordLine item)
        {
            return _lines.Remove(item);
        }
        
        #endregion

        #region IList<SRecordLine> overloads
        public void Add(SRecordLine line)
        {
            if (line == null) throw new ArgumentNullException(nameof(line));
            line.LineNumber = _lines.Count + 1;
            _lines.Add(line);
        }
        

        public void Clear()
        {
            _lines.Clear();
        }
        
        public int Count => _lines.Count;
        public bool IsReadOnly => false;
        
        public IEnumerator<SRecordLine> GetEnumerator()
        {
            return _lines.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int IndexOf(SRecordLine item)
        {
            return _lines.IndexOf(item);
        }

        public void Insert(int index, SRecordLine item)
        {
            _lines.Insert(index,item);
        }
        
        public void RemoveAt(int index)
        {
            _lines.RemoveAt(index);
        }
        
        public SRecordLine this[int index]
        {
            get => _lines[index];
            set => _lines[index]=value;
        }
        
        #endregion
        
        #region ReadFrom and ReadFromAsync
        
        public void ReadFrom(Stream stream)
        {
            ReadFrom(new SRecordLineReader(stream, _parser));
        }

        public void ReadFrom(Stream stream, Encoding encoding)
        {
            ReadFrom(new SRecordLineReader(stream, encoding ,_parser));
        }

        public void ReadFrom(StreamReader streamReader)
        {
            ReadFrom(new SRecordLineReader(streamReader, _parser));
        }
        
        public async Task ReadFromAsync(Stream stream)
        {
            await ReadFromAsync(new SRecordLineReader(stream, _parser));
        }

        public async Task ReadFromAsync(Stream stream, Encoding encoding)
        {
            await ReadFromAsync(new SRecordLineReader(stream, encoding ,_parser));
        }

        public async Task ReadFromAsync(StreamReader streamReader)
        {
            await ReadFromAsync(new SRecordLineReader(streamReader, _parser));
        }
        
        public void ReadFrom(SRecordLineReader reader)
        {
            foreach (var line in reader.ReadRemainingLines())
            {
                Add(line);
            }
        }
        
        public async Task ReadFromAsync(SRecordLineReader reader)
        {
            await foreach (var line in reader.ReadRemainingLinesAsync())
            {
                Add(line);
            }
        }
        
        #endregion

        #region WriteTo and WriteToAsync
        public void WriteTo(Stream stream)
        {
            WriteTo(new SRecordLineWriter(stream, _formatter));
        }

        public void WriteTo(Stream stream, Encoding encoding)
        {
            WriteTo(new SRecordLineWriter(stream, encoding ,_formatter));
        }

        public void WriteTo(StreamWriter streamWriter)
        {
            WriteTo(new SRecordLineWriter(streamWriter, _formatter));
        }

        public void WriteTo(SRecordLineWriter writer)
        {
            writer.WriteLines(_lines);
        }

        public async Task WriteToAsync(Stream stream)
        {
            await WriteToAsync(new SRecordLineWriter(stream, _formatter));
        }

        public async Task WriteToAsync(Stream stream, Encoding encoding)
        {
            await WriteToAsync(new SRecordLineWriter(stream, encoding ,_formatter));
        }

        public async Task WriteToAsync(StreamWriter streamWriter)
        {
            await WriteToAsync(new SRecordLineWriter(streamWriter, _formatter));
        }
        
        public async Task WriteToAsync(SRecordLineWriter writer)
        {
            writer.WriteLinesAsync(_lines);
        }
        
        #endregion
        
        #region File methods.
        
        public static SRecordContainer CreateFromFile(string filePath, ISRecordLineParser parser=null, ISRecordLineFormatter formatter=null)
        {
            var result = new SRecordContainer(parser,formatter);
            result.LoadFromFile(filePath);
            return result;
        }

        public static async Task<SRecordContainer> CreateFromFileAsync(string filePath, ISRecordLineParser parser=null, ISRecordLineFormatter formatter=null)
        {
            var result = new SRecordContainer(parser,formatter);
            await result.LoadFromFileAsync(filePath);
            return result;
        }
        public async Task LoadFromFileAsync(string filePath)
        {
            await ReadFromAsync(File.OpenRead(filePath));
        }
        
        public void LoadFromFile(string filePath)
        {
            ReadFrom(File.OpenRead(filePath));
        }

        public void WriteToFile(string filePath)
        {
            WriteTo(File.CreateText(filePath));
        }
        
        public async Task WriteToFileAsync(string filePath)
        {
            await WriteToAsync(File.CreateText(filePath));
        }
        
        #endregion
        
        #region Text methods
        public static SRecordContainer CreateFromText(string text, ISRecordLineParser parser=null, ISRecordLineFormatter formatter=null)
        {
            var result = new SRecordContainer(parser,formatter);
            result.LoadFromText(text);
            return result;
        }
        
        public void LoadFromText(string text, Encoding encoding=null)
        {
            if (encoding == null) encoding=Encoding.UTF8;
            ReadFrom(new MemoryStream(encoding.GetBytes(text)), encoding);
        }

        public string ToString(Encoding encoding=null)
        {
            encoding ??= new UTF8Encoding(false);
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream, encoding);
            WriteTo(writer);
            var bytes = stream.ToArray();
            return encoding.GetString(bytes);
        }        
        
        #endregion

        private static SRecordLine MakeSRecordLine(int lineNumber, SRecord sRecord)
        {
            return new SRecordLine(lineNumber,SRecordLineType.SRecord,sRecord);
        }
    }
}