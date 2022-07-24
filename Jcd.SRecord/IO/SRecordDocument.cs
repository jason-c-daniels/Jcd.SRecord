using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Jcd.SRecord.IO;

namespace Jcd.SRecord.IO
{
    /// <summary>
    /// Represents an SRecord document. This is a simple document reader/writer.
    /// No S37, or other semantics are enforced.
    /// </summary>
    public class SRecordDocument
    {
        private readonly ISRecordElementParser _parser;
        private readonly ISRecordElementFormatter _formatter;
        
        /// <summary>
        /// Gets a mutable collection of <c>SRecordElement</c>s contained in this document.
        /// </summary>
        public ObservableCollection<SRecordElement> Elements { get; } = new ObservableCollection<SRecordElement>();

        /// <summary>
        /// Gets an immutable collection of just the SRecord entries contained in the Elements collection.
        /// </summary>
        public IEnumerable<SRecord> SRecords => Elements
            .Where(x => x.ElementType.HasSRecord)
            .Select(x => x.SRecord);

        /// <summary>
        /// Gets the instance of the parser in use by this <c>SRecordDocument</c>. 
        /// </summary>
        public ISRecordElementParser Parser => _parser;

        /// <summary>
        /// Gets the instance of the formatter used by this <c>SRecordDocument</c>.
        /// </summary>
        public ISRecordElementFormatter Formatter => _formatter;


        /// <summary>
        /// Creates an instance of an <c>SRecordDocument</c>.
        /// </summary>
        /// <param name="parser">The parser to use for parsing <c>SRecordElement</c> text. If null the default one is used.</param>
        /// <param name="formatter">The formatter to use when writing <c>SRecordElement</c>s. If null the default one is used.</param>
        public SRecordDocument(ISRecordElementParser parser=null, ISRecordElementFormatter formatter=null)
        {
            _parser = parser ?? SRecordElementParser.Default;
            _formatter = formatter ?? SRecordElementFormatter.Default;
        }
        
        #region Read and ReadAsync
        
        /// <summary>
        /// Reads all of the remaining <c>SRecordElement</c> entries 
        /// from the <c>SRecordElementReader</c>
        /// </summary>
        /// <param name="reader">The element reader.</param>
        public void Read(SRecordElementReader reader)
        {
            foreach (var line in reader.ReadToEnd())
                Elements.Add(line);
        }
        
        /// <summary>
        /// Asynchronously reads all of the remaining <c>SRecordElement</c> entries 
        /// from the <c>SRecordElementReader</c>
        /// </summary>
        /// <param name="reader">The element reader.</param>
        public async Task ReadAsync(SRecordElementReader reader)
        {
            await foreach (var line in reader.ReadToEndAsync())
                Elements.Add(line);
        }
        
        #endregion

        #region Write and WriteAsync

        /// <summary>
        /// Writes all of the <c>SRecordElement</c>s in this document to the
        /// <c>SRecordElementWriter</c>
        /// </summary>
        /// <param name="writer">The <c>SRecordElementWriter</c> instance to write to.</param>
        public void Write(SRecordElementWriter writer)
        {
            writer.Write(Elements);
        }
        
        /// <summary>
        /// Asynchronously writes all of the <c>SRecordElement</c>s in this document to the
        /// <c>SRecordElementWriter</c>
        /// </summary>
        /// <param name="writer">The <c>SRecordElementWriter</c> instance to write to.</param>
        public async Task WriteAsync(SRecordElementWriter writer)
        {
            await writer.WriteAsync(Elements);
        }
        
        #endregion
        
        #region File methods.
        
        /// <summary>
        /// Creates a <c>SRecordDocument</c> using the provided parser and formatter
        /// Then loads data from the specified file path.
        /// </summary>
        /// <param name="filePath">The file to read.</param>
        /// <param name="parser">The parser. If null the default one is used.</param>
        /// <param name="formatter">The formatter to used. If null the default one is used.</param>
        /// <returns>The new <c>SRecordDocument</c> instance</returns>
        public static SRecordDocument CreateFromFile(string filePath, ISRecordElementParser parser=null, ISRecordElementFormatter formatter=null)
        {
            var result = new SRecordDocument(parser,formatter);
            result.LoadFile(filePath);
            return result;
        }

        /// <summary>
        /// Creates the <c>SRecordDocument</c> using the provided parser and formatter
        /// Then asynchronously loads data from the specified file path.
        /// </summary>
        /// <param name="filePath">The file to read.</param>
        /// <param name="parser">The parser. If null the default one is used.</param>
        /// <param name="formatter">The formatter to used. If null the default one is used.</param>
        /// <returns>The new <c>SRecordDocument</c> instance</returns>
        public static async Task<SRecordDocument> CreateFromFileAsync(string filePath, ISRecordElementParser parser=null, ISRecordElementFormatter formatter=null)
        {
            var result = new SRecordDocument(parser,formatter);
            await result.LoadFileAsync(filePath);
            return result;
        }
        
        /// <summary>
        /// Asynchronously loads data from the specified file path into the current
        /// <c>SRecordDocument</c>. This appends to any existing entries.
        /// </summary>
        /// <param name="filePath">The file to read.</param>
        public async Task LoadFileAsync(string filePath)
        {
            await ReadAsync(CreateReaderFromFileName(filePath));
        }
        
        /// <summary>
        /// Loads data from the specified file path into the current
        /// <c>SRecordDocument</c>. This appends to any existing entries.
        /// </summary>
        /// <param name="filePath">The file to read.</param>
        public void LoadFile(string filePath)
        {
            Read(CreateReaderFromFileName(filePath));
        }

        /// <summary>
        /// Creates or replaces a file at the specified path and writes
        /// all of the formatted <c>SRecordElement</c> data into the file.
        /// </summary>
        /// <param name="filePath">The path of the file to write.</param>
        public void WriteFile(string filePath)
        {
            Write(CreateWriterFromFileName(filePath));
        }

        /// <summary>
        /// Asynchronously creates or replaces a file at the specified path and the
        /// writes all of the formatted <c>SRecordElement</c> data into the file.
        /// </summary>
        /// <param name="filePath">The path of the file to write.</param>
        public async Task WriteFileAsync(string filePath)
        {
            await WriteAsync(CreateWriterFromFileName(filePath));
        }
        
        private SRecordElementReader CreateReaderFromFileName(string filePath)
        {
            return new SRecordElementReader(File.OpenRead(filePath),Parser);
        }
        
        private SRecordElementWriter CreateWriterFromFileName(string filePath)
        {
            return new SRecordElementWriter(File.CreateText(filePath),Formatter);
        }

        #endregion
        
        #region String methods
        
        /// <summary>
        /// Creates a <c>SRecordDocument</c> using the provided parser and formatter
        /// Then loads data from the string.
        /// </summary>
        /// <param name="text">The string to load.</param>
        /// <param name="parser">The parser. If null the default one is used.</param>
        /// <param name="formatter">The formatter to used. If null the default one is used.</param>
        /// <returns>The new <c>SRecordDocument</c> instance</returns>
        public static SRecordDocument CreateFromString(string text, ISRecordElementParser parser=null, ISRecordElementFormatter formatter=null)
        {
            var result = new SRecordDocument(parser,formatter);
            result.LoadString(text);
            return result;
        }
        
        /// <summary>
        /// Loads data from the provided string into the current  <c>SRecordDocument</c>.
        /// This appends to any existing entries.
        /// </summary>
        /// <param name="text">The string to load.</param>
        public void LoadString(string text)
        {
            Read(new SRecordElementReader(text, Parser));
        }


        /// <inheritdoc />
        public override string ToString()
        {
            var sr = new StringWriter();
            Write(new SRecordElementWriter(sr, Formatter));
            return sr.ToString();
        }        
        
        #endregion
        
    }
}