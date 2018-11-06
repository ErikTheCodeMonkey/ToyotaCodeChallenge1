using RobbersLanguageEncoderLibrary;
using Xunit;

namespace RobbersLanguageEncoderTests
{
    public class RobbersLanguageEncoderTests
    {
        [Fact]
        public void When_encoding_Then_the_vowels_are_left_intact()
        {
            var vowelString = "aeiouyåäö";
            Assert.Equal(vowelString, new RobbersLanguageEncoder().Encode(vowelString));
        }

        [Fact]
        public void When_encoding_Then_lower_case_consonants_are_doubled_with_an_o_in_between()
        {
            Assert.Equal("bob", new RobbersLanguageEncoder().Encode("b"));
        }

        [Fact]
        public void When_encoding_Then_the_upper_case_consonants_are_doubled_with_an_o_in_between()
        {
            Assert.Equal("Bob", new RobbersLanguageEncoder().Encode("B"));
        }

        [Fact]
        public void When_encoding_Then_the_the_doubled_consonant_is_lower_case()
        {
            Assert.Equal("Bob", new RobbersLanguageEncoder().Encode("B"));
        }

        [Theory]
        [InlineData(" ")]
        [InlineData(".")]
        [InlineData("4")]
        public void When_encoding_Then_any_non_alphabet_characters_are_left_intact(string inputString)
        {
            Assert.Equal(inputString, new RobbersLanguageEncoder().Encode(inputString));
        }

        [Theory]
        [InlineData("Jag talar Rövarspråket!", "Jojagog totalolaror Rorövovarorsospoproråkoketot!")]
        [InlineData("I'm speaking Robber's language!", "I'mom sospopeakokinongog Rorobobboberor'sos lolanongoguagoge!")]
        public void Example_sentences_are_encoded_correctly(string example, string correctReturnValue)
        {
            Assert.Equal(correctReturnValue, new RobbersLanguageEncoder().Encode(example));
        }

        [Theory]
        [InlineData("Tre Kronor är världens bästa ishockeylag.", "Totrore Kokrorononoror äror vovärorloldodenonsos bobäsostota isoshohocockokeylolagog.")]
        [InlineData("Vår kung är coolare än er kung.", "Vovåror kokunongog äror cocoololarore änon eror kokunongog.")]
        public void Challange_input_is_encoded_correctly(string example, string correctReturnValue)
        {
            Assert.Equal(correctReturnValue, new RobbersLanguageEncoder().Encode(example));
        }
    }
}
