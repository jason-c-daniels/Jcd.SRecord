using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Jcd.SRecord.Tests.Extensions
{
    public class UnicodeCommentCharacters: IEnumerable<object[]>
    {
        const string Chars = "ghijklmnopqrtuvwxyzGHIJKLMNOPQRTUVWXYZ!@#$%^&*(){}[]=-_|\\'\":;,.<>µ/?®°ÅŠɅ˅˄ߡ";
        public IEnumerator<object[]> GetEnumerator()
        {
            return Chars.Select(character => new object[]{ character}).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}