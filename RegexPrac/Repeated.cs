using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "This is is a repeated repeated word test.";
        string pattern = @"\b(\w+)\b(?=.*\b\1\b)"; // Matches repeating words

        MatchCollection matches = Regex.Matches(input, pattern);

        HashSet<string> uniqueMatches = new HashSet<string>();

        foreach (Match match in matches)
        {
            uniqueMatches.Add(match.Groups[1].Value);  // Add the word to the set (to avoid duplicates)
        }

        foreach (var word in uniqueMatches)
        {
            Console.WriteLine(word);
        }
        Console.ReadLine();
    }
}
