using System.Text;

namespace RobbersLanguageEncoderLibrary
{
    public class RobbersLanguageEncoder
    {
        public const char FillingVocal = 'o';


        public string Encode(string inputString)
        {
            var encodedString = new StringBuilder();
            foreach (var character in inputString)
            {
                encodedString.Append(character);
                if (character.IsConsonant())
                {
                    encodedString.Append(FillingVocal);
                    encodedString.Append(char.ToLower(character));
                }
            }

            return encodedString.ToString();
        }
    }
}