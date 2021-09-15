using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("radar", true)]
        [InlineData("level", true)]
        [InlineData("Deified", true)]
        [InlineData("madAm", true)]
        [InlineData("reDividEr", true)]
        [InlineData("Joey", false)]
        [InlineData("Camel", false)]
        [InlineData("Google", false)]
        public void Test1(string word, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();

            //Act
            var actual = wordSmith.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
