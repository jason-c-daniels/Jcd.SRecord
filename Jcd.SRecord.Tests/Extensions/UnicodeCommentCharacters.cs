using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Jcd.SRecord.Extensions;

namespace Jcd.SRecord.Tests.Extensions
{
    public class UnicodeCommentCharacters: IEnumerable<object[]>
    {
        const string _chars = "ghijklmnopqrtuvwxyzGHIJKLMNOPQRTUVWXYZ!@#$%^&*(){}[]=-_|\\'\":;,.<>µ/?®°ÅŠɅ˅˄ߡ";
        public IEnumerator<object[]> GetEnumerator()
        {
            return _chars.Select(character => new object[]{ character}).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}