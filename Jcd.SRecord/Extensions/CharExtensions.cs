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
        /// <returns>True if the character</returns>
        public static bool IsHexDigit(this char character)
        {
            return (character >= '0' && character <= '9') ||
                   (character >= 'A' && character <= 'F') ||
                   (character >= 'a' && character <= 'f');
        }


        /// <summary>
        /// Throws an ArgumentException if the character can't be used for an SRecord comment.
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