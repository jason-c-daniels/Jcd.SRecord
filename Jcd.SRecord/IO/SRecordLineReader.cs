using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Jcd.SRecord.Parsers;

namespace Jcd.SRecord.IO
{
    /// <summary>
    /// A forward only SRecordLine stream/string reader.
    /// This class always disposes its Stream/StreamReader when disposed.
    /// </summary>
    public class SRecordLineReader : IDisposable
    {
        private readonly StreamReader _streamReader;
        private readonly ISRecordLineParser _parser;
        
        /// <summary>
        /// The line number of the most recently read line.
        /// This is 0 if nothing has been read and number of the last line in the file,
        /// if all lines have been read.
        /// </summary>
        public int CurrentLine { get; private set; }

        #region Constructors
        /// <summary>
        /// Constructs an <c>SRecordLineReader</c> from a block of text. The encoding is assumed to be UTF8.
        /// </summary>
        /// <param name="linesOfText">the block of text.</param>
        /// <param name="parser">the line parser.</param>
        public SRecordLineReader(string linesOfText, ISRecordLineParser parser)
        : this(linesOfText, Encoding.UTF8, parser)
        {
        }
        
        /// <summary>
        /// Constructs an <c>SRecordLineReader</c> from a block of text. The encoding is assumed to be UTF8.
        /// </summary>
        /// <param name="linesOfText">the block of text.</param>
        /// <param name="parser">the line parser.</param>
        /// <param name="encoding">The encoding to use for linesOfText.</param>
        public SRecordLineReader(string linesOfText, Encoding encoding, ISRecordLineParser parser)
            : this(new MemoryStream(encoding.GetBytes(linesOfText)),parser)
        {
        }
        
        /// <summary>
        /// Constructs an <c>SRecordLineReader</c> from a stream.
        /// </summary>
        /// <param name="stream">The stream to read from.</param>
        /// <param name="parser">The parser to use</param>
        public SRecordLineReader(Stream stream, ISRecordLineParser parser)
            : this(new StreamReader(stream), parser)
        {
            
        }

        /// <summary>
        /// Constructs an <c>SRecordLineReader</c> from a stream.
        /// </summary>
        /// <param name="stream">The stream to read from.</param>
        /// <param name="parser">The parser to use</param>
        /// <param name="encoding">The text encoding to use.</param>
        public SRecordLineReader(Stream stream, Encoding encoding, ISRecordLineParser parser)
            : this(new StreamReader(stream, encoding), parser)
        {
            
        }
        
        /// <summary>
        /// Constructs an <c>SRecordLineReader</c> from a stream reader and line parser.
        /// </summary>
        /// <param name="streamReader">The reader</param>
        /// <param name="parser">The parser</param>
        public SRecordLineReader(StreamReader streamReader, ISRecordLineParser parser)
        {
            _streamReader = streamReader ?? throw new ArgumentNullException(nameof(streamReader));
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            CurrentLine = 0;
        }
        
        #endregion
        
        /// <summary>
        /// Get an enumerable of <c>SRecordLine</c>s from the input stream from the current position.
        /// </summary>
        /// <returns>an enumerable of <c>SRecordLine</c>s from the input stream</returns>
        public IEnumerable<SRecordLine> ReadRemainingLines()
        {
            while (!_streamReader.EndOfStream)
            {
                yield return ReadLine();
            }
        }
        
        /// <summary>
        /// Get an enumerable of <c>SRecordLine</c>s from the input stream, asynchronously
        /// </summary>
        /// <returns>an enumerable of <c>SRecordLine</c>s from the input stream</returns>
        public async IAsyncEnumerable<SRecordLine> ReadRemainingLinesAsync()
        {
            while (!_streamReader.EndOfStream)
            {
                yield return await ReadLineAsync();
            }
        }

        /// <summary>
        /// Reads an <c>SRecordLine</c> from the stream.
        /// </summary>
        /// <returns>The <c>SRecordLine</c>, null if end of stream has been reached.</returns>
        public SRecordLine ReadLine()
        {
            var line = _streamReader.ReadLine();
            return line !=null ? _parser.Parse(CurrentLine++, line) : null;
        }

        /// <summary>
        /// Reads an <c>SRecordLine</c> from the stream.
        /// </summary>
        /// <returns>The <c>SRecordLine</c>, null if end of stream has been reached.</returns>
        public async Task<SRecordLine> ReadLineAsync()
        {
            var line = await _streamReader.ReadLineAsync();
            return line !=null ? _parser.Parse(CurrentLine++, line) : null;
        }
        
        /// <summary>
        /// Indicates if all of the data has been read.
        /// </summary>
        public bool EndOfData => _streamReader.EndOfStream;
        
        #region IDisposable

        /// <inheritdoc cref="IDisposable.Dispose"/>
        public void Dispose()
        {
            _streamReader.Dispose();
        }

        #endregion
    }
}