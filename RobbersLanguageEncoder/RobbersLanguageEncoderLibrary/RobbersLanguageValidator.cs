namespace RobbersLanguageEncoderLibrary
{
    public class RobbersLanguageValidator
    {
        public bool IsValidRobbersLanguage(string inputString)
        {
            for (var i = 0; i < inputString.Length; i++)
            {
                var character = inputString[i];

                if (character.IsConsonant())
                {
                    if (!HasFillingVocal(inputString, i) || !HasTrailingCharacter(inputString, i, character))
                    {
                        return false;
                    }

                    i = i + 2;
                }
            }

            return true;
        }

        private bool HasTrailingCharacter(string inputString, int i, char character)
        {
            return inputString[i+2] == char.ToLower(character);
        }

        private bool HasFillingVocal(string inputString, int i)
        {
            return inputString[i + 1] == RobbersLanguageEncoder.FillingVocal;
        }
    }
}