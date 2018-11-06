using System.Collections.Generic;

namespace RobbersLanguageEncoderLibrary
{
    public static class AlphabetExtensions
    {

        private static readonly List<char> _consonants = new List<char>
        {
            'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Z'
        };

        public static bool IsConsonant(this char character)
        {
            return _consonants.Contains(char.ToUpper(character));
        }
    }
}