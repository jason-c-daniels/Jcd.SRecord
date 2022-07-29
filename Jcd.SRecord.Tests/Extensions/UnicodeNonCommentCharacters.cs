using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Jcd.SRecord.Tests.Extensions
{
    public class UnicodeNonCommentCharacters: IEnumerable<object[]>
    {
        const string _chars = "\u0000 \t\r\nabcdefABCDEF0123456789sS\uD800\uDBFF\uDFFF";
        public IEnumerator<object[]> GetEnumerator()
        {
            return _chars.Select(character => new object[]{ character}).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}