using System;
namespace MyStrings
{
	public class StringClass
	{
        // Method to reverse a string
        public string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Method to check if a string is a palindrome
        public bool IsPalindrome(string str)
        {
            string reversed = Reverse(str);
            return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
        }

        // Method to convert a string to uppercase
        public string ToUpperCase(string str)
        {
            return str.ToUpper();
        }
    }
}