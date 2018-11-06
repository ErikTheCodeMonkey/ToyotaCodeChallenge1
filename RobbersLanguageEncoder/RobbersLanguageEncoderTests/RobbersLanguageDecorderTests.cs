using RobbersLanguageEncoderLibrary;
using Xunit;

namespace RobbersLanguageEncoderTests
{
    public class RobbersLanguageDecorderTests
    {

        [Fact]
        public void When_decoding_Then_the_vowels_are_left_intact()
        {
            var vowelString = "aeiouyåäö";
            Assert.Equal(vowelString, new RobbersLanguageDecoder().Decode(vowelString));
        }

        [Fact]
        public void When_decoding_and_a_lower_case_consonant_is_encountered_Then_the_o__and_the_doubled_character_is_removed()
        {
            Assert.Equal("b", new RobbersLanguageDecoder().Decode("bob"));
        }

        [Fact]
        public void When_decoding_and_an_upper_case_consonant_is_encountered_Then_the_o_and_the_doubled_character_is_removed()
        {
            Assert.Equal("B", new RobbersLanguageDecoder().Decode("Bob"));
        }

        [Theory]
        [InlineData(" ")]
        [InlineData(".")]
        [InlineData("4")]
        public void When_decoding_Then_any_non_alphabet_characters_are_left_intact(string inputString)
        {
            Assert.Equal(inputString, new RobbersLanguageDecoder().Decode(inputString));
        }

        [Fact]
        public void When_decoding_and_input_is_not_valid_robbers_language_Then_an_exceptions_is_thrown()
        {
            Assert.Throws<InvalidRobbersLanguageException>(() => new RobbersLanguageDecoder().Decode("banana"));
        }

        [Theory]
        [InlineData("Jojagog totalolaror Rorövovarorsospoproråkoketot!", "Jag talar Rövarspråket!")]
        [InlineData("I'mom sospopeakokinongog Rorobobboberor'sos lolanongoguagoge!", "I'm speaking Robber's language!")]
        public void Example_sentences_are_decoded_correctly(string example, string correctReturnValue)
        {
            Assert.Equal(correctReturnValue, new RobbersLanguageDecoder().Decode(example));
        }

        [Theory]
        [InlineData("Totrore Kokrorononoror äror vovärorloldodenonsos bobäsostota isoshohocockokeylolagog.", "Tre Kronor är världens bästa ishockeylag.")]
        [InlineData("Vovåror kokunongog äror cocoololarore änon eror kokunongog.", "Vår kung är coolare än er kung.")]
        public void Challenge_input_is_decoded_correctly(string example, string correctReturnValue)
        {
            Assert.Equal(correctReturnValue, new RobbersLanguageDecoder().Decode(example));
        }
    }
}