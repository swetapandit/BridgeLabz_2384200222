/*using System;
using System.Collections.Generic;
using System.IO;

namespace Collection
{
    public class WordFrequencyCounter
    {
        public static void CountWordFrequency(string filePath)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            string text = File.ReadAllText(filePath);
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                string cleanedWord = word.ToLower(); // Convert to lowercase to count words case-insensitively
                if (wordCount.ContainsKey(cleanedWord))
                {
                    wordCount[cleanedWord]++;
                }
                else
                {
                    wordCount.Add(cleanedWord, 1);
                }
            }

            Console.WriteLine("Word Frequencies:");
            foreach (var item in wordCount)
            {
                Console.WriteLine($"\"{item.Key}\": {item.Value}");
            }
        }

        public static void Main()
        {
            string filePath = "/Users/swetapandit/Desktop/Mydotnet/file.txt"; // Replace with your file path
            CountWordFrequency(filePath);

            Console.ReadLine();
        }
    }
}
*/