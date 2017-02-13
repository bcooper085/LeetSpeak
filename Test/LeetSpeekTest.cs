using Xunit;

namespace LeetSpeekTranslator
{
    public class LeetSpeekTest
    {
        [Fact]
        public void LeetSpeek_InputOutputText_InputText()
        {
            // Arrange
            string userInputString = "Hello";
            LeetSpeek LeetSpeekTest = new LeetSpeek(userInputString);

            // Act
            string appOutput = LeetSpeekTest.GetUserInput();

            // Assert
            Assert.Equal(userInputString, appOutput);
        }
        [Fact]
        public void CharacterReplace_UserInputEWith3_InputT3xt()
        {
            //Arrange
            string userInputString = "Weevil";
            LeetSpeek LeetSpeekTest = new LeetSpeek(userInputString);

            //Act
            string appOutput = LeetSpeekTest.CharacterReplace();

            //Assert
            Assert.Equal("W33vil", appOutput);
        }
        [Fact]
        public void CharacterReplace_UserInputOWith0_InputTextHell0()
        {
            //Arrange
            string userInputString = "Owl";
            LeetSpeek LeetSpeekTest = new LeetSpeek(userInputString);

            //Act
            string appOutput = LeetSpeekTest.CharacterReplace();

            //Assert
            Assert.Equal("0wl", appOutput);
        }
        [Fact]
        public void CharacterReplace_UserInputIWith1_InputText1ggy()
        {
            //Arrange
            string userInputString = "Iggy";
            LeetSpeek LeetSpeekTest = new LeetSpeek(userInputString);

            //Act
            string appOutput = LeetSpeekTest.CharacterReplace();

            //Assert
            Assert.Equal("1ggy", appOutput);
        }
        [Fact]
        public void CharacterReplace_UserInputSWithZ_InputTextSam()
        {
            //Arrange
            string userInputString = "SaSass ss SS";
            LeetSpeek LeetSpeekTest = new LeetSpeek(userInputString);

            //Act
            string appOutput = LeetSpeekTest.CharacterReplace();

            //Assert
            Assert.Equal("SaZazz sz SZ", appOutput);
        }
    }
}
