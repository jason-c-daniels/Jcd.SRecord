using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Jcd.SRecord
{
    /// <summary>
    /// Represents summary information about the contents of
    /// an any collection of SRecordData.
    /// </summary>
    public class SRecordDataStatistics
    {
        /// <summary>
        /// A cache of the number of times a data bearing record
        /// </summary>
        public Dictionary<int, int> DataLengthCounts { get; } = new Dictionary<int, int>();

        /// <summary>
        /// The count of all S0 records.
        /// </summary>
        public int S0Count { get; private set;  }
        
        /// <summary>
        /// The count of all S1 records.
        /// </summary>
        public int S1Count { get; private set;  }
        
        /// <summary>
        /// The count of all S2 records.
        /// </summary>
        public int S2Count { get; private set;  }
        
        /// <summary>
        /// The count of all S3 records.
        /// </summary>
        public int S3Count { get; private set;  }
        
        /// <summary>
        /// The count of all S4 records.
        /// </summary>
        public int S4Count { get; private set;  }
        
        /// <summary>
        /// The count of all S5 records.
        /// </summary>
        public int S5Count { get; private set;  }
        
        /// <summary>
        /// The count of all S6 records.
        /// </summary>
        public int S6Count { get; private set;  }
        
        /// <summary>
        /// The count of all S7 records.
        /// </summary>
        public int S7Count { get; private set;  }
        
        /// <summary>
        /// The count of all S0 records.
        /// </summary>
        public int S8Count { get; private set;  }
        
        /// <summary>
        /// The count of all S0 records.
        /// </summary>
        public int S9Count { get; private set;  }

        /// <summary>
        /// The maximum value of any SRecordData.Data.Length entry
        /// </summary>
        public int MaximumDataLength { get; private set; }

        /// <summary>
        /// The same as S0Count, a convenience getter.
        /// </summary>
        public int HeaderCount => S0Count;
        
        /// <summary>
        /// The count of all S1, S2, and S3 records.
        /// </summary>
        public int DataRecordCount => S1Count + S2Count + S3Count;

        /// <summary>
        /// The count of all S5 and S6 records. (Ideally 0 or 1!)
        /// </summary>
        public int CounterRecordCount => S5Count + S6Count;

        /// <summary>
        /// The count of all S7, S8 and S9 records. (Ideally only 1!)
        /// </summary>
        public int StartAddressRecordCount => S7Count + S8Count + S9Count;

        /// <summary>
        /// A count of all the SRecord entries these statistics account for.
        /// </summary>
        public int TotalSRecordDataCount => HeaderCount +
                                            CounterRecordCount +
                                            DataRecordCount +
                                            StartAddressRecordCount;

        /// <summary>
        /// Resets all properties to 0;
        /// </summary>
        public void Reset()
        {
            S0Count = 0;
            S1Count = 0;
            S2Count = 0;
            S3Count = 0;
            S4Count = 0;
            S5Count = 0;
            S6Count = 0;
            S7Count = 0;
            S8Count = 0;
            S9Count = 0;
            MaximumDataLength = 0;
            DataLengthCounts.Clear();
        }

        /// <summary>
        /// Increments the statistics based on the passed in record.
        /// </summary>
        /// <param name="record">record</param>
        public void Increment([NotNull] SRecordData record)
        {
            IncrementDataLengthCount(record);
            if (record.Type.Key == "S0") S0Count++;
            if (record.Type.Key == "S1") S1Count++;
            if (record.Type.Key == "S2") S2Count++;
            if (record.Type.Key == "S3") S3Count++;
            if (record.Type.Key == "S4") S4Count++;
            if (record.Type.Key == "S5") S5Count++;
            if (record.Type.Key == "S6") S6Count++;
            if (record.Type.Key == "S7") S7Count++;
            if (record.Type.Key == "S8") S8Count++;
            if (record.Type.Key == "S9") S9Count++;
        }
        
        private void IncrementDataLengthCount([NotNull]SRecordData record)
        {
            var dataLength = record.Data.Length;
            if (!DataLengthCounts.ContainsKey(dataLength))
                DataLengthCounts.Add(dataLength, 0);
            DataLengthCounts[dataLength]++;
            if (MaximumDataLength < dataLength) MaximumDataLength = dataLength;
        }

        /// <summary>
        /// Decrements the statistics based on the passed in record.
        /// </summary>
        /// <param name="record"></param>
        public void Decrement([NotNull] SRecordData record)
        {
            if (record.Type.Key == "S0") S0Count--;
            if (record.Type.Key == "S1") S1Count--;
            if (record.Type.Key == "S2") S2Count--;
            if (record.Type.Key == "S3") S3Count--;
            if (record.Type.Key == "S4") S4Count--;
            if (record.Type.Key == "S5") S5Count--;
            if (record.Type.Key == "S6") S6Count--;
            if (record.Type.Key == "S7") S7Count--;
            if (record.Type.Key == "S8") S8Count--;
            if (record.Type.Key == "S9") S9Count--;
            DecrementDataLengthCount(record);
            ValidateCountsAfterDecrement();
        }

        private void ValidateCountsAfterDecrement()
        {
            var errorDetected = S0Count < 0 ||
                                S1Count < 0 ||
                                S2Count < 0 ||
                                S3Count < 0 ||
                                S4Count < 0 ||
                                S5Count < 0 ||
                                S6Count < 0 ||
                                S7Count < 0 ||
                                S8Count < 0 ||
                                S9Count < 0;
            if (errorDetected) 
                throw new ApplicationException("Decrement called too many times.");
        }
        
        private void DecrementDataLengthCount([NotNull]SRecordData record)
        {
            var dataLength = record.Data.Length;
            if (!DataLengthCounts.ContainsKey(dataLength)) return;
            DataLengthCounts[dataLength]--;
            if (DataLengthCounts[dataLength] != 0) return;
            DataLengthCounts.Remove(dataLength);
            if (DataLengthCounts.Count == 0) return;
            while (!DataLengthCounts.ContainsKey(MaximumDataLength))
                MaximumDataLength--;
        }
    }
}