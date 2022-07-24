using System;

namespace Jcd.SRecord.IO
{
    public struct SRecordLineType : IEquatable<SRecordLineType>
    {
        public readonly bool HasComment;
        public readonly bool HasSRecord;
        public readonly bool IsBlank;
        public readonly bool HasError;

        /// <summary>
        /// A single line comment.
        /// </summary>
        public static readonly SRecordLineType Comment = new SRecordLineType(true);

        /// <summary>
        /// An SRecord without a comment.
        /// </summary>
        public static readonly SRecordLineType SRecord = new SRecordLineType(hasSRecord:true);

        /// <summary>
        /// An SRecord with end of line comment.
        /// </summary>
        public static readonly SRecordLineType SRecordWithEndOfLineComment = new SRecordLineType(true, true);

        /// <summary>
        /// A blank line (Empty or all whitespace.)
        /// </summary>
        public static readonly SRecordLineType Blank = new SRecordLineType(isBlank:true);

        /// <summary>
        ///  Indicates if some error was detected while parsing the line.
        /// </summary>
        public static readonly SRecordLineType Error = new SRecordLineType(hasError:true,hasComment:false,hasSRecord:false,isBlank:false);

        private SRecordLineType(bool hasComment=false, bool hasSRecord=false, bool isBlank=false, bool hasError=false)
        {
            HasComment = hasComment;
            HasSRecord = hasSRecord;
            IsBlank = isBlank;
            HasError = hasError;
        }
        
        #region Equality Operators and Hashcode
        /// <summary>
        /// Compares this instance to another.
        /// </summary>
        /// <param name="other">The other instance to compare to.</param>
        /// <returns>true if equal.</returns>
        public bool Equals(SRecordLineType other)
        {
            return HasComment == other.HasComment && HasSRecord == other.HasSRecord && IsBlank == other.IsBlank && HasError == other.HasError;
        }

        /// <summary>
        /// Compares this instance to another object.
        /// </summary>
        /// <param name="other">The other instance to compare to.</param>
        /// <returns>true if equal.</returns>
        public override bool Equals(object obj)
        {
            return obj is SRecordLineType other && Equals(other);
        }

        /// <summary>
        /// Generates a hashcode for the instance.
        /// </summary>
        /// <returns>The hashcode</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(HasComment, HasSRecord, IsBlank, HasError);
        }

        /// <summary>
        /// Compares two instances of <c>SRecordLineType</c> for equality.
        /// </summary>
        /// <param name="left">The left hand side of the comparison.</param>
        /// <param name="right">The right hand side of the comparison.</param>
        /// <returns>True if equal</returns>
        public static bool operator ==(SRecordLineType left, SRecordLineType right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances of <c>SRecordLineType</c> for inequality.
        /// </summary>
        /// <param name="left">The left hand side of the comparison.</param>
        /// <param name="right">The right hand side of the comparison.</param>
        /// <returns>True if not equal</returns>
        public static bool operator !=(SRecordLineType left, SRecordLineType right)
        {
            return !left.Equals(right);
        }
        
        #endregion
    }
}