using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Jcd.SRecord
{
    /// <summary>
    /// Provides the logic necessary to write <c>SRecordElement</c>s to a <c>Stream</c> or <c>TextWriter</c>.
    /// </summary>
    public class SRecordElementWriter : IDisposable
    {
        private readonly TextWriter _textWriter;
        private readonly ISRecordElementFormatter _elementFormatter;

        /// <summary>
        /// Constructs an instance from a stream and element formatter. 
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="elementFormatter">The element formatter.</param>
        public SRecordElementWriter(Stream stream, ISRecordElementFormatter elementFormatter)
            : this(new StreamWriter(stream,new UTF8Encoding(false)),elementFormatter)
        {
            
        } 

        /// <summary>
        /// Constructs an instance from a stream, an encoding, and element formatter. 
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="encoding">The encoding to use.</param>
        /// <param name="elementFormatter">The element formatter.</param>
        public SRecordElementWriter(Stream stream, Encoding encoding, ISRecordElementFormatter elementFormatter)
         : this(new StreamWriter(stream,encoding),elementFormatter)
        {
            
        } 
        
        /// <summary>
        /// Constructs an instance from a <c>StreamWriter</c> and an <c>ISRecordElementFormatter</c>
        /// </summary>
        /// <param name="streamWriter">The StreamWriter</param>
        /// <param name="elementFormatter">The element formatter</param>
        /// <exception cref="ArgumentNullException">Thrown when either parameter is null.</exception>
        public SRecordElementWriter(TextWriter streamWriter, ISRecordElementFormatter elementFormatter)
        {
            _textWriter = streamWriter ?? throw new ArgumentNullException(nameof(streamWriter));
            _elementFormatter = elementFormatter ?? throw new ArgumentNullException(nameof(elementFormatter));
        }

        /// <summary>
        /// Format and write an SRecordElement to the stream.
        /// </summary>
        /// <param name="element">the element to format and write.</param>
        public void Write(SRecordElement element)
        {
            var formattedLine = _elementFormatter.Format(element);
            if (formattedLine == null) return;
            _textWriter.WriteLine(formattedLine);
            _textWriter.Flush();
        }

        /// <summary>
        /// Formats and writes a element to the stream, asynchronously.
        /// </summary>
        /// <param name="element">The element to write.</param>
        public async Task WriteAsync(SRecordElement element)
        {
            var formattedLine = _elementFormatter.Format(element);
            if (formattedLine != null)
            {
                await _textWriter.WriteLineAsync(formattedLine);
                await _textWriter.FlushAsync();
            }
        }

        /// <summary>
        /// Writes a set of lines to the stream.
        /// </summary>
        /// <param name="lines">The lines to write.</param>
        public void Write([NotNull] IEnumerable<SRecordElement> lines)
        {
            foreach (var line in lines)
                Write(line);
        }
        
        /// <summary>
        /// Writes a set of lines to a stream, asynchronously.
        /// </summary>
        /// <param name="lines">The lines to write.</param>
        public async Task WriteAsync([NotNull] IEnumerable<SRecordElement> lines)
        {
            foreach (var line in lines) 
                await WriteAsync(line);
        }

        /// <summary>
        /// Writes a set of lines, obtained asynchronously, to a stream, asynchronously.
        /// </summary>
        /// <param name="lines">The lines to write.</param>
        public async Task WriteAsync([NotNull] IAsyncEnumerable<SRecordElement> lines)
        {
            await foreach (var line in lines) 
                await WriteAsync(line);
        }
        
        /// <inheritdoc cref="IDisposable.Dispose"/>
        public void Dispose()
        {
            _textWriter.Dispose();
        }
    }
}