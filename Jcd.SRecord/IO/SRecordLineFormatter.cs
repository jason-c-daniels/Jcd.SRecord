using System.Text;
using Jcd.SRecord.Parsers;

namespace Jcd.SRecord.IO
{
    /// <summary>
    /// Encapsulates the logic necessary to format an <c>SRecordLine</c>
    /// as a line of text.
    /// </summary>
    public partial class SRecordLineFormatter : ISRecordLineFormatter
    {
        private readonly SRecordFormatter _sRecordFormatter;
        private readonly Options _options;

        /// <summary>
        /// Gets the default instance of <c>SRecordLineFormatter</c> 
        /// </summary>
        public static SRecordLineFormatter DefaultFormatter = new SRecordLineFormatter();
        
        /// <summary>
        /// Gets the currently configured options.
        /// </summary>
        public Options CurrentOptions => _options;

        /// <summary>
        /// Gets the currently configured SRecordFormatter
        /// </summary>
        public SRecordFormatter SRecordFormatter => _sRecordFormatter;
        
        /// <summary>
        /// Constructs an instance of <c>SRecordLineFormatter</c> with the specified
        /// options and SRecordFormatter.
        /// </summary>
        /// <param name="options">The options to use, if null, <c>Options.DefaultOptions</c> is used.</param>
        /// <param name="sRecordFormatter">The SRecordFormatter to use. If null, <c>SRecordFormatter.UppercaseHex</c> is used.</param>
        public SRecordLineFormatter(Options? options=null, SRecordFormatter sRecordFormatter=null)
        {
            _options = options ?? Options.DefaultOptions;
            _sRecordFormatter = sRecordFormatter ?? SRecordFormatter.UppercaseHex;
        }

        /// <inheritdoc />
        public string Format(SRecordLine line)
        {
            return Format(_options, SRecordFormatter, line);
        }

        private static string Format(Options options, SRecordFormatter sRecordFormatter, SRecordLine line)
        {
            if (options.EmitOriginalText) 
                return line.OriginalLine;
            
            if (line.LineType.HasError)
            {
                if (options.EmitErrorLineAsCommentLine && options.EmitComment)
                {
                    return $"{options.CommentCharacter.ToString()}{line.OriginalLine}";
                }
                return EmptyResult(options);
            }
            
            if (line.LineType.IsBlank) 
                return EmptyResult(options);

            var sb = new StringBuilder();

            if (line.LineType.HasSRecord && options.EmitSRecordContent)
                sb.Append(sRecordFormatter.Format(line.SRecord));
            
            if (line.LineType.HasSRecord && line.LineType.HasComment && options.EmitSpaceBeforeEndOfLineComment && options.EmitComment)
                sb.Append(" ");

            if (line.LineType.HasComment && options.EmitSpaceBeforeEndOfLineComment && options.EmitComment)
                sb.AppendFormat("{0}{1}",options.CommentCharacter.ToString(),line.Comment);

            return sb.Length == 0 
                ? EmptyResult(options) 
                : sb.ToString();
        }

        private static string EmptyResult(Options options)
        {
            return options.EmitBlankLineAsEmptyString ? string.Empty : null;
        }
    }
}