using System.Text;

namespace RobbersLanguageEncoderLibrary
{
    public class RobbersLanguageDecoder
    {
        public string Decode(string inputString)
        {
            if (!new RobbersLanguageValidator().IsValidRobbersLanguage(inputString))
            {
                throw new InvalidRobbersLanguageException();
            }

            var decodedString = new StringBuilder();
            for (var i = 0; i < inputString.Length; i++)
            {
                var character = inputString[i];
                decodedString.Append(character);
                if (character.IsConsonant())
                {
                    i = i + 2;
                }
            }

            return decodedString.ToString();
        }
    }
}