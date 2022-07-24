using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Jcd.SRecord.Parsers;

namespace Jcd.SRecord.IO
{
    /// <summary>
    /// Writes <c>SRecordLine</c>s to a stream.
    /// </summary>
    public class SRecordLineWriter : IDisposable
    {
        private readonly StreamWriter _streamWriter;
        private readonly ISRecordLineFormatter _lineFormatter;

        /// <summary>
        /// Constructs an instance from a stream and line formatter. 
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="lineFormatter">The line formatter.</param>
        public SRecordLineWriter(Stream stream, ISRecordLineFormatter lineFormatter)
            : this(new StreamWriter(stream,new UTF8Encoding(false)),lineFormatter)
        {
            
        } 

        /// <summary>
        /// Constructs an instance from a stream, an encoding, and line formatter. 
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="encoding">The encoding to use.</param>
        /// <param name="lineFormatter">The line formatter.</param>
        public SRecordLineWriter(Stream stream, Encoding encoding, ISRecordLineFormatter lineFormatter)
         : this(new StreamWriter(stream,encoding),lineFormatter)
        {
            
        } 
        
        /// <summary>
        /// Constructs an instance from a <c>StreamWriter</c> and an <c>ISRecordLineFormatter</c>
        /// </summary>
        /// <param name="streamWriter">The StreamWriter</param>
        /// <param name="lineFormatter">The line formatter</param>
        /// <exception cref="ArgumentNullException">Thrown when either parameter is null.</exception>
        public SRecordLineWriter(StreamWriter streamWriter, ISRecordLineFormatter lineFormatter)
        {
            _streamWriter = streamWriter ?? throw new ArgumentNullException(nameof(streamWriter));
            _lineFormatter = lineFormatter ?? throw new ArgumentNullException(nameof(lineFormatter));
        }

        /// <summary>
        /// Format and write an SRecordLine to the stream.
        /// </summary>
        /// <param name="line">the line to format and write.</param>
        public void WriteLine(SRecordLine line)
        {
            var formattedLine = _lineFormatter.Format(line);
            if (formattedLine != null)
            {
                _streamWriter.WriteLine(formattedLine);
                _streamWriter.Flush();
            }
        }

        /// <summary>
        /// Formats and writes a line to the stream, asynchronously.
        /// </summary>
        /// <param name="line">The line to write.</param>
        public async Task WriteLineAsync(SRecordLine line)
        {
            var formattedLine = _lineFormatter.Format(line);
            if (formattedLine != null)
            {
                await _streamWriter.WriteLineAsync(formattedLine);
                await _streamWriter.FlushAsync();
            }
        }

        /// <summary>
        /// Writes a set of lines to the stream.
        /// </summary>
        /// <param name="lines">The lines to write.</param>
        public void WriteLines([NotNull] IEnumerable<SRecordLine> lines)
        {
            foreach (var line in lines)
                WriteLine(line);
        }
        
        /// <summary>
        /// Writes a set of lines to a stream, asynchronously.
        /// </summary>
        /// <param name="lines">The lines to write.</param>
        public async Task WriteLinesAsync([NotNull] IEnumerable<SRecordLine> lines)
        {
            foreach (var line in lines) 
                await WriteLineAsync(line);
        }
        
        /// <inheritdoc cref="IDisposable.Dispose"/>
        public void Dispose()
        {
            _streamWriter.Dispose();
        }
    }
}