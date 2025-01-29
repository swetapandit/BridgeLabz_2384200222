using System;

class Program
{
    static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        char[] result = new char[sentence.Length * 2]; // Extra space for new word
        int resIndex = 0;
        int i = 0;

        while (i < sentence.Length)
        {
            // Check if oldWord matches at position 'i'
            int j = 0;
            while (j < oldWord.Length && (i + j) < sentence.Length && sentence[i + j] == oldWord[j])
            {
                j++;
            }

            // If full word matches
            if (j == oldWord.Length && (i + j == sentence.Length || sentence[i + j] == ' ' || sentence[i + j] == ',' || sentence[i + j] == '.'))
            {
                // Add newWord to result
                for (int k = 0; k < newWord.Length; k++)
                {
                    result[resIndex++] = newWord[k];
                }
                i += oldWord.Length; // Move index ahead
            }
            else
            {
                // Otherwise, copy character from original string
                result[resIndex++] = sentence[i++];
            }
        }

        // Convert result array to string manually
        string finalResult = "";
        for (int k = 0; k < resIndex; k++)
        {
            finalResult += result[k];  // Character by character append
        }

        return finalResult;
    }

    static void Main()
    {
        string sentence = Console.ReadLine();
        string oldWord =  Console.ReadLine();
        string newWord =  Console.ReadLine();

        string replacedSentence = ReplaceWord(sentence, oldWord, newWord);
        Console.WriteLine("Updated Sentence: " + replacedSentence);
    }
}
