using System;

namespace Jcd.SRecord
{
    /// <summary>
    /// Defines a set of flags that describe the results of parsing a line
    /// of text from an <c>SRecordDocument</c> 
    /// </summary>
    public readonly struct SRecordElementType : IEquatable<SRecordElementType>
    {
        /// <summary>
        /// Indicates that the parsed data contains a comment. (This may be an empty string) 
        /// </summary>
        public readonly bool HasComment;
        
        /// <summary>
        /// Indicates that the parsed data contains <c>SRecordData</c> data.
        /// </summary>
        public readonly bool HasSRecordData;
        
        /// <summary>
        /// Indicates that the parsed line was blank.
        /// </summary>
        public readonly bool IsBlank;
        
        /// <summary>
        /// Indicates that an error occurred during parsing.
        /// </summary>
        public readonly bool HasError;

        /// <summary>
        /// A single line comment.
        /// </summary>
        public static readonly SRecordElementType Comment = new SRecordElementType(true);

        /// <summary>
        /// An SRecordData without a comment.
        /// </summary>
        public static readonly SRecordElementType SRecord = new SRecordElementType(hasSRecordData:true);

        /// <summary>
        /// An SRecordData with end of line comment.
        /// </summary>
        public static readonly SRecordElementType SRecordWithEndOfElementComment = new SRecordElementType(true, true);

        /// <summary>
        /// A blank line (Empty or all whitespace.)
        /// </summary>
        public static readonly SRecordElementType Blank = new SRecordElementType(isBlank:true);

        /// <summary>
        ///  Indicates if some error was detected while parsing the line.
        /// </summary>
        public static readonly SRecordElementType Error = new SRecordElementType(hasError:true,hasComment:false,hasSRecordData:false,isBlank:false);

        private SRecordElementType(bool hasComment=false, bool hasSRecordData=false, bool isBlank=false, bool hasError=false)
        {
            HasComment = hasComment;
            HasSRecordData = hasSRecordData;
            IsBlank = isBlank;
            HasError = hasError;
        }
        
        #region Equality Operators and Hashcode
        /// <summary>
        /// Compares this instance to another.
        /// </summary>
        /// <param name="other">The other instance to compare to.</param>
        /// <returns>true if equal.</returns>
        public bool Equals(SRecordElementType other)
        {
            return HasComment == other.HasComment && HasSRecordData == other.HasSRecordData && IsBlank == other.IsBlank && HasError == other.HasError;
        }

        /// <summary>
        /// Compares this instance to another object.
        /// </summary>
        /// <param name="obj">The other instance to compare to.</param>
        /// <returns>true if equal.</returns>
        public override bool Equals(object obj)
        {
            return obj is SRecordElementType other && Equals(other);
        }

        /// <summary>
        /// Generates a hashcode for the instance.
        /// </summary>
        /// <returns>The hashcode</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(HasComment, HasSRecordData, IsBlank, HasError);
        }

        /// <summary>
        /// Compares two instances of <c>SRecordElementType</c> for equality.
        /// </summary>
        /// <param name="left">The left hand side of the comparison.</param>
        /// <param name="right">The right hand side of the comparison.</param>
        /// <returns>True if equal</returns>
        public static bool operator ==(SRecordElementType left, SRecordElementType right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances of <c>SRecordElementType</c> for inequality.
        /// </summary>
        /// <param name="left">The left hand side of the comparison.</param>
        /// <param name="right">The right hand side of the comparison.</param>
        /// <returns>True if not equal</returns>
        public static bool operator !=(SRecordElementType left, SRecordElementType right)
        {
            return !left.Equals(right);
        }
        
        #endregion
    }
}