using System;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {
        }

        public bool IsAPalindrome(string word)
        {
            string res = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
    
                res += word[i];
            }
            if (word.ToLower() == res.ToLower())
            {
                return true;
            }
            return false;
        }
    }
}
