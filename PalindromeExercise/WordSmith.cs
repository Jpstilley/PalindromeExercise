using System;
namespace PalindromeExercise
{
    public class WordSmith
    {



        public bool IsAPalindrome(string word)
        {
            char[] charaters = word.ToCharArray();
            Array.Reverse(charaters);
            string reversed = new string(charaters);
            return word.ToLower().Equals(reversed.ToLower());
        }
    }
}
