using System.Diagnostics.CodeAnalysis;

namespace Jcd.SRecord
{
    /// <summary>
    /// Represents a set of statistics about a set of <c>SRecordElement</c> instances.
    /// </summary>
    public class SRecordElementStatistics
    {
        /// <summary>
        /// The number of elements that were flagged as having an error.
        /// </summary>
        public int ErrorElementCount { get; private set; }
        
        /// <summary>
        /// The number of elements that just had comment data.
        /// </summary>
        public int StandAloneCommentCount { get; private set; }
        
        /// <summary>
        /// The number of elements with both SRecordData and comments.
        /// </summary>
        public int SRecordDataWithCommentCount { get; private set; }

        /// <summary>
        /// The total number of elements with comments.  
        /// </summary>
        public int ElementsWithCommentsCount { get; private set; }

        /// <summary>
        /// The number of elements which were not in error but did not
        /// parse comments or SRecordData
        /// </summary>
        public int BlankElementCount { get; private set; }
        
        /// <summary>
        /// The total number of elements that contained SRecordData
        /// </summary>
        public int ElementsWithSRecordDataCount { get; private set; }

        /// <summary>
        ///  The total number of elements evaluated.
        /// </summary>
        public int TotalElementsCount => BlankElementCount +         // elements tagged as blank.
                                         ErrorElementCount +         // elements flagged as in error.
                                         StandAloneCommentCount +    // elements containing just comments
                                         ElementsWithSRecordDataCount;// elements containing SRecordData and optionally comments.

        /// <summary>
        /// Sets all datapoints to 0
        /// </summary>
        public void Reset()
        {
            ErrorElementCount = 0;
            StandAloneCommentCount = 0;
            SRecordDataWithCommentCount = 0;
            BlankElementCount = 0;
            ElementsWithSRecordDataCount = 0;
            ElementsWithCommentsCount = 0;
        }

        /// <summary>
        /// Increments the this instance's statistics based on the
        /// passed in element.
        /// </summary>
        /// <param name="element">The element to evaluate.</param>
        public void Increment([NotNull] SRecordElement element)
        {
            var type = element.ElementType;
            if (type.IsBlank) BlankElementCount++;
            if (type.HasError) ErrorElementCount++;
            if (type.HasSRecordData) ElementsWithSRecordDataCount++;
            if (type.HasComment) ElementsWithCommentsCount++;
            if (type.HasComment && type.HasSRecordData) SRecordDataWithCommentCount++;
            if (type.HasComment && !type.HasSRecordData && !type.HasError) StandAloneCommentCount++;
        }

        /// <summary>
        /// Decrements the this instance's statistics based on the
        /// passed in element.
        /// </summary>
        /// <param name="element">The element to evaluate.</param>
        public void Decrement([NotNull] SRecordElement element)
        {
            var type = element.ElementType;
            if (type.IsBlank) BlankElementCount--;
            if (type.HasError) ErrorElementCount--;
            if (type.HasSRecordData) ElementsWithSRecordDataCount--;
            if (type.HasComment) ElementsWithCommentsCount--;
            if (type.HasComment && type.HasSRecordData) SRecordDataWithCommentCount--;
            if (type.HasComment && !type.HasSRecordData && !type.HasError) StandAloneCommentCount--;
        }
    }
}