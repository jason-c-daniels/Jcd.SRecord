using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

namespace Jcd.SRecord
{
    /// <summary>
    /// Represents an SRecordData document that contains all the records that were read.
    /// </summary>
    /// <remarks>
    /// 1. This is a simple document reader/writer. No S19, S28, or S37 semantics are enforced.
    /// 2. Some statistics classes are provided to assist in enforcing those semantics should you find a need.
    /// 3. Any one instance of this class can handle reading in no more than int.Maxvalue records.
    ///   - This is intentional as the practical limit on allowed number of records in any one file is 0xFFFFFF. (Maximum for the S6 count)
    ///   - To process more than int.MaxValue records, consider periodically creating a new instance of this class, or directly use an instance of <c>SRecordElementParse</c> if you really don't care about line numbers. 
    /// </remarks>
    public class SRecordDocument
    {
        /// <summary>
        /// Gets a mutable collection of <c>SRecordElement</c>s contained in this document.
        /// </summary>
        [NotNull]
        public List<SRecordElement> Elements { get; } = new List<SRecordElement>();

        /// <summary>
        /// Gets an immutable collection of just the SRecordData entries contained in the Elements collection.
        /// </summary>
        [NotNull]
        // ReSharper disable once UnusedMember.Global
        public IEnumerable<SRecordData> SRecords => Elements
            .Where(x => x.ElementType.HasSRecordData)
            .Select(x => x.SRecordData);

        /// <summary>
        /// Gets the instance of the parser in use by this <c>SRecordDocument</c>. 
        /// </summary>
        [NotNull]
        // ReSharper disable once MemberCanBePrivate.Global
        public ISRecordElementParser Parser { get; }

        /// <summary>
        /// Gets the instance of the formatter used by this <c>SRecordDocument</c>.
        /// </summary>
        [NotNull]
        // ReSharper disable once MemberCanBePrivate.Global
        public ISRecordElementFormatter Formatter { get; }

        /// <summary>
        /// Computes a new set of statistics for the current set of Elements
        /// </summary>
        /// <returns>a new <c>SRecordElementStatistics</c> instance</returns>
        public SRecordElementStatistics CalculateParseStatistics()
        {
            var stats = new SRecordElementStatistics();
            foreach (var element in Elements)
            {
                stats.Increment(element);
            }

            return stats;
        }
        
        /// <summary>
        /// Computes a new set of statistics for the current set of Elements
        /// </summary>
        /// <returns>a new <c>SRecordDataStatistics</c> instance</returns>
        public SRecordDataStatistics CalculateDataStatistics()
        {
            var stats = new SRecordDataStatistics();
            foreach (var recordData in SRecords)
            {
                stats.Increment(recordData);
            }

            return stats;
        }
        
        /// <summary>
        /// Creates an instance of an <c>SRecordDocument</c>.
        /// </summary>
        /// <param name="parser">The parser to use for parsing <c>SRecordElement</c> text. If null the default one is used.</param>
        /// <param name="formatter">The formatter to use when writing <c>SRecordElement</c>s. If null the default one is used.</param>
        // ReSharper disable once MemberCanBePrivate.Global
        public SRecordDocument(ISRecordElementParser parser=null, ISRecordElementFormatter formatter=null)
        {
            Parser = parser ?? SRecordElementParser.Default;
            Formatter = formatter ?? SRecordElementFormatter.Default;
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
        /// Creates a <c>SRecordDocument</c> using the provided parser and formatter, then loads data from the specified file path.
        /// </summary>
        /// <param name="filePath">The file to read.</param>
        /// <param name="parser">The parser. If null the default one is used.</param>
        /// <param name="formatter">The formatter to used. If null the default one is used.</param>
        /// <returns>The new <c>SRecordDocument</c> instance</returns>
        [return: NotNull]
        public static SRecordDocument CreateFromFile(string filePath, ISRecordElementParser parser=null, ISRecordElementFormatter formatter=null)
        {
            var result = new SRecordDocument(parser,formatter);
            result.LoadFile(filePath);
            return result;
        }

        /// <summary>
        /// Creates the <c>SRecordDocument</c> using the provided parser and formatter, then asynchronously loads data from the specified file path.
        /// </summary>
        /// <param name="filePath">The file to read.</param>
        /// <param name="parser">The parser. If null the default one is used.</param>
        /// <param name="formatter">The formatter to used. If null the default one is used.</param>
        /// <returns>The new <c>SRecordDocument</c> instance</returns>
        [return: NotNull]
        public static async Task<SRecordDocument> CreateFromFileAsync(string filePath, ISRecordElementParser parser=null, ISRecordElementFormatter formatter=null)
        {
            var result = new SRecordDocument(parser,formatter);
            await result.LoadFileAsync(filePath);
            return result;
        }
        
        /// <summary>
        /// Asynchronously loads data from the specified file path into the current <c>SRecordDocument</c>.
        /// This appends to any existing entries.
        /// </summary>
        /// <param name="filePath">The file to read.</param>
        public async Task LoadFileAsync(string filePath)
        {
            using var reader = CreateReaderFromFileName(filePath);
            await ReadAsync(reader);
        }
        
        /// <summary>
        /// Loads data from the specified file path into the current <c>SRecordDocument</c>.
        /// This appends to any existing entries.
        /// </summary>
        /// <param name="filePath">The file to read.</param>
        public void LoadFile(string filePath)
        {
            using var reader = CreateReaderFromFileName(filePath);
            Read(reader);
        }

        /// <summary>
        /// Creates or replaces a file at the specified path and writes all of the formatted <c>SRecordElement</c> data into the file.
        /// </summary>
        /// <param name="filePath">The path of the file to write.</param>
        public void WriteFile(string filePath)
        {
            using var writer=CreateWriterFromFileName(filePath);
            Write(writer);
        }

        /// <summary>
        /// Asynchronously creates or replaces a file at the specified path and the writes all of the formatted <c>SRecordElement</c> data into the file.
        /// </summary>
        /// <param name="filePath">The path of the file to write.</param>
        public async Task WriteFileAsync(string filePath)
        {
            using var writer = CreateWriterFromFileName(filePath);
            await WriteAsync(writer);
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
        /// Creates a <c>SRecordDocument</c> using the provided parser and formatter, then loads data from the string.
        /// </summary>
        /// <param name="text">The string to load.</param>
        /// <param name="parser">The parser. If null the default one is used.</param>
        /// <param name="formatter">The formatter to used. If null the default one is used.</param>
        /// <returns>The new <c>SRecordDocument</c> instance</returns>
        [return: NotNull]
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
            using var reader = new SRecordElementReader(text, Parser);
            Read(reader);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var sw = new StringWriter();
            using var writer = new SRecordElementWriter(sw, Formatter);
            Write(writer);
            return sw.ToString();
        }        
        
        #endregion
    }
}