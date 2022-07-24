using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Jcd.SRecord.IO
{
    /// <summary>
    /// Encapsulates the logic necessary to format an <c>SRecordElement</c>
    /// as a line of text.
    /// </summary>
    public partial class SRecordElementFormatter : ISRecordElementFormatter
    {
        /// <summary>
        /// Gets the default instance of <c>SRecordElementFormatter</c> 
        /// </summary>
        public static readonly SRecordElementFormatter Default = new SRecordElementFormatter();
        
        /// <summary>
        /// Gets the currently configured options.
        /// </summary>
        public Options CurrentOptions { get; }

        /// <summary>
        /// Gets the currently configured <c>ISRecordFormatter</c>
        /// </summary>
        public ISRecordFormatter RecordFormatter { get; }

        /// <summary>
        /// Constructs an instance of <c>SRecordElementFormatter</c> with the specified
        /// options and <c>ISRecordFormatter</c>.
        /// </summary>
        /// <param name="options">The options to use, if null, <c>Options.DefaultOptions</c> is used.</param>
        /// <param name="recordFormatter">The ISRecordFormatter to use. If null, <c>SRecordFormatter.UppercaseHex</c> is used.</param>
        public SRecordElementFormatter(Options? options=null, ISRecordFormatter recordFormatter=null)
        {
            CurrentOptions = options ?? Options.DefaultOptions;
            RecordFormatter = recordFormatter ?? SRecordFormatter.UppercaseHex;
        }

        /// <inheritdoc />
        public string Format([NotNull]SRecordElement element)
        {
            try
            {
                RaiseFormattingEvent(element);
                return ProcessResult(Format(CurrentOptions, RecordFormatter, element), element);
            }
            catch
            {
                ProcessResult(null, element);
                throw;
            }
        }

        /// <inheritdoc />
        public event EventHandler<SRecordElementFormattingEventArgs> Formatting;

        /// <inheritdoc />
        public event EventHandler<SRecordElementFormattedEventArgs> Formatted;

        private static string Format(Options options, ISRecordFormatter sRecordFormatter,[NotNull] SRecordElement element)
        {
            if (options.EmitOriginalText) 
                return element.OriginalLine;
            
            if (element.ElementType.HasError)
            {
                if (options.EmitErrorLineAsCommentLine && options.EmitComment)
                {
                    return $"{options.CommentCharacter.ToString()}{element.OriginalLine}";
                }
                return EmptyResult(options);
            }
            
            if (element.ElementType.IsBlank) 
                return EmptyResult(options);

            var sb = new StringBuilder();

            if (element.ElementType.HasSRecord && options.EmitSRecordContent)
                sb.Append(sRecordFormatter.Format(element.SRecord));
            
            if (element.ElementType.HasSRecord && element.ElementType.HasComment && options.EmitSpaceBeforeEndOfLineComment && options.EmitComment)
                sb.Append(" ");

            if (element.ElementType.HasComment && options.EmitSpaceBeforeEndOfLineComment && options.EmitComment)
                sb.AppendFormat("{0}{1}",options.CommentCharacter.ToString(),element.Comment);

            return sb.Length == 0 
                ? EmptyResult(options) 
                : sb.ToString();
        }

        private string ProcessResult(string result, SRecordElement element)
        {
            RaiseFormattedEvent(element,result!=null,result);
            return result;
        }
        
        private static string EmptyResult(Options options)
        {
            return options.EmitBlankLineAsEmptyString ? string.Empty : null;
        }
        
        private void RaiseFormattingEvent(SRecordElement element)
        {
            Formatting?.Invoke(this,new SRecordElementFormattingEventArgs(element));
        }
        
        private void RaiseFormattedEvent(SRecordElement element, bool successful, string formattedText)
        {
            Formatted?.Invoke(this,new SRecordElementFormattedEventArgs(successful,element,formattedText));
        }
    }
}