using System;
namespace MyStrings;
public class Program
{
    public static void Main()
    {
        StringClass stringClass = new StringClass();
        string input = "raceca";
        Console.WriteLine("Reversed: " + stringClass.Reverse(input));
        Console.WriteLine("Is Palindrome: " + stringClass.IsPalindrome(input));
        Console.WriteLine("Uppercase: " + stringClass.ToUpperCase(input));
        Console.ReadLine();
    }
}