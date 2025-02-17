/*using System;

public class Program
{
    public static string FindSentenceWithWord(string[] sentences, string word)
    {
        foreach (string sentence in sentences) if (sentence.IndexOf(word) >= 0) return sentence;
        return "Not Found";
    }

    public static void Main()
    {
        Console.WriteLine("Enter the number of sentences:");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] sentences = new string[n];

        Console.WriteLine("Enter the sentences:");
        for (int i = 0; i < n; i++) sentences[i] = Console.ReadLine();

        Console.WriteLine("Enter the word to search:");
        string searchWord = Console.ReadLine();
        string result = FindSentenceWithWord(sentences, searchWord);
        Console.WriteLine("First sentence which contains '" + searchWord + "':");
        Console.WriteLine(result);
        Console.ReadLine();

    }
}
*/