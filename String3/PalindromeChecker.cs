using System;

class PalindromeChecker
{
    static bool CheckPalin(string str){
        string rev="";
        for(int i = str.Length-1; i&gt;=0; i--) {
        rev+=str[i];
        }

        return str == rev;
    }

    // Function to display the result
    static void DisplayResult(string input, bool isPalindrome)
    {
        if (isPalindrome)
        {
            Console.WriteLine(input+" is a palindrome.");
        }
        else
        {
            Console.WriteLine(input+" is not a palindrome.");
        }
    }

    // Main function to drive the program
    static void Main(string[] args)
    {
        // Get the input string
        string userInput = GetInput();

        // Check if the string is a palindrome
        bool result = IsPalindrome(userInput);

        // Display the result
        DisplayResult(userInput, result);
    }
}
