using System;

namespace Jcd.SRecord.Extensions
{
    /// <summary>
    /// A set of utility methods for interacting with <c>char</c>s.
    /// </summary>
    public static class CharExtensions
    {
        /// <summary>
        ///  Returns true if a character is a hexadecimal digit.
        /// </summary>
        /// <param name="character">the character to inspect.</param>
        /// <returns>True if the character is a hexadecimal digit.</returns>
        public static bool IsHexDigit(this char character)
        {
            switch (character)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                case 'a':
                case 'b':
                case 'c':
                case 'd':
                case 'e':
                case 'f':
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Gets the value from a hexadecimal digit.
        /// </summary>
        /// <param name="digit">The digit to evaluate.</param>
        /// <returns>The numeric value.</returns>
        /// <exception cref="ArgumentException">Thrown if the character isn't actually a hexadecimal digit.</exception>
        public static byte GetHexValue(this char digit)
        {
            switch (digit)
            {
                case '0': return 0;
                case '1': return 1;
                case '2': return 2;
                case '3': return 3;
                case '4': return 4;
                case '5': return 5;
                case '6': return 6;
                case '7': return 7;
                case '8': return 8;
                case '9': return 9;
                case 'a': 
                case 'A': return 0xA;
                case 'b':
                case 'B': return 0xB;
                case 'c':
                case 'C': return 0xC;
                case 'd':
                case 'D': return 0xD;
                case 'e':
                case 'E': return 0xE;
                case 'f':
                case 'F': return 0xF;
            }
            throw new ArgumentException($"'{digit}' is not a hexadecimal digit.", nameof(digit));
        }

        /// <summary>
        /// Throws an ArgumentException if the character can't be used for an SRecordData comment.
        /// </summary>
        /// <param name="character">the character to check.</param>
        /// <exception cref="ArgumentException">Thrown if the character is invalid.</exception>
        public static void ThrowArgumentExceptionIfNotValidForSRecordComment(this char character)
        {
            if (char.IsWhiteSpace(character))
                throw new ArgumentException($"'{character}' is invalid. A comment character cannot be whitespace.");
            
            if (character.IsHexDigit())
                throw new ArgumentException($"'{character}' is invalid. A comment character cannot be a hexadecimal digit ('a' to 'f','A' to 'F', and '0' to '9' are hexadecimal digits.");
            
            if (character == 's' || character == 'S')
                throw new ArgumentException($"'{character}' is invalid. A comment character cannot be 'S' or 's'.");

            if (char.IsControl(character) ||
                char.IsSurrogate(character) ||
                char.IsHighSurrogate(character) ||
                char.IsLowSurrogate(character))
                throw new ArgumentException($"'\\u+{Convert.ToUInt16(character):X4}' is cannot be used as a comment character. Invalid Unicode Category: {char.GetUnicodeCategory(character)}.");
        }
    }
}