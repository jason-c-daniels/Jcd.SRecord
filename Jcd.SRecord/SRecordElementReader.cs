using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Jcd.SRecord
{
    /// <summary>
    /// A forward only <c>SRecordElement</c> stream/string reader.
    /// This class always disposes its TextReader when disposed.
    /// </summary>
    public class SRecordElementReader : IDisposable
    {
        private readonly TextReader _textReader;
        private readonly ISRecordElementParser _parser;
        
        /// <summary>
        /// The line number of the most recently read line.
        /// </summary>
        /// <remarks>
        /// This is 0 if nothing has been read and number of the last line in the file, if all lines have been read.
        /// </remarks>
        public int CurrentLine { get; private set; }

        #region Constructors
        
        /// <summary>
        /// Constructs an <c>SRecordElementReader</c> from a block of text. The encoding is assumed to be UTF8.
        /// </summary>
        /// <param name="linesOfText">the block of text.</param>
        /// <param name="parser">the line parser.</param>
        public SRecordElementReader(string linesOfText, ISRecordElementParser parser)
            : this(new StringReader(linesOfText),parser)
        {
        }
        
        /// <summary>
        /// Constructs an <c>SRecordElementReader</c> from a stream.
        /// </summary>
        /// <param name="stream">The stream to read from.</param>
        /// <param name="parser">The parser to use</param>
        public SRecordElementReader(Stream stream, ISRecordElementParser parser)
            : this(new StreamReader(stream), parser)
        {
        }

        /// <summary>
        /// Constructs an <c>SRecordElementReader</c> from a stream.
        /// </summary>
        /// <param name="stream">The stream to read from.</param>
        /// <param name="parser">The parser to use</param>
        /// <param name="encoding">The text encoding to use.</param>
        public SRecordElementReader(Stream stream, Encoding encoding, ISRecordElementParser parser)
            : this(new StreamReader(stream, encoding), parser)
        {
        }
        
        /// <summary>
        /// Constructs an <c>SRecordElementReader</c> from a stream reader and line parser.
        /// </summary>
        /// <param name="textReader">The reader</param>
        /// <param name="parser">The parser</param>
        public SRecordElementReader(TextReader textReader, ISRecordElementParser parser)
        {
            _textReader = textReader ?? throw new ArgumentNullException(nameof(textReader));
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            CurrentLine = 0;
        }
        
        #endregion
        
        /// <summary>
        /// Get an enumerable of <c>SRecordElement</c>s from the input stream from the current position.
        /// </summary>
        /// <returns>an enumerable of <c>SRecordElement</c>s from the input stream</returns>
        /// <remarks>
        /// NOTE: This will overflow and depending on if it's used in an unchecked context, may or may not throw an exception if you try to parse more than int.MaxValue lines.
        /// </remarks>
        public IEnumerable<SRecordElement> ReadToEnd()
        {
            while (!EndOfData)
            {
                yield return Read();
            }
        }
        
        /// <summary>
        /// Get an enumerable of <c>SRecordElement</c>s from the input stream, asynchronously
        /// </summary>
        /// <returns>an enumerable of <c>SRecordElement</c>s from the input stream</returns>
        /// <remarks>
        /// NOTE: This will overflow and depending on if it's used in an unchecked context, may or may not throw an exception if you try to parse more than int.MaxValue lines.
        /// </remarks>
        public async IAsyncEnumerable<SRecordElement> ReadToEndAsync()
        {
            while (!EndOfData)
            {
                yield return await ReadAsync();
            }
        }

        /// <summary>
        /// Reads an <c>SRecordElement</c> from the stream.
        /// </summary>
        /// <returns>The <c>SRecordElement</c>, null if end of stream has been reached.</returns>
        /// <remarks>
        /// NOTE: This will overflow and depending on if it's used in an unchecked context, may or may not throw an exception if you try to parse more than int.MaxValue lines.
        /// </remarks>
        public SRecordElement Read()
        {
            var line = _textReader.ReadLine();
            return line !=null ? _parser.Parse(CurrentLine++, line) : null;
        }

        /// <summary>
        /// Reads an <c>SRecordElement</c> from the stream.
        /// </summary>
        /// <returns>The <c>SRecordElement</c>, null if end of stream has been reached.</returns>
        /// <remarks>
        /// NOTE: This will overflow and depending on if it's used in an unchecked context, may or may not throw an exception if you try to parse more than int.MaxValue lines.
        /// </remarks>
        public async Task<SRecordElement> ReadAsync()
        {
            var line = await _textReader.ReadLineAsync();
            return line !=null ? _parser.Parse(CurrentLine++, line) : null;
        }
        
        /// <summary>
        /// Indicates if all of the data has been read.
        /// </summary>
        public bool EndOfData => _textReader.Peek() == -1;
        
        #region IDisposable

        /// <inheritdoc cref="IDisposable.Dispose"/>
        public void Dispose()
        {
            _textReader.Dispose();
        }

        #endregion
    }
}