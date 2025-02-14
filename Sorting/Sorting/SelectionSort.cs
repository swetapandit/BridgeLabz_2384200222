/*using System;

class Program
{
    static void SelectionSort(int[] scores)
    {
        int n = scores.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i; // Assume the first unsorted element is the minimum

            // Find the minimum element in the remaining unsorted part
            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum element with the first unsorted element
            int temp = scores[minIndex];
            scores[minIndex] = scores[i];
            scores[i] = temp;

        }
    }

    

    static void Main()
    {
        int[] examScores = { 85, 72, 96, 60, 78, 90 };

        SelectionSort(examScores);
        for (int i = 0; i < examScores.Length; i++)
        {
            Console.Write(examScores[i] + " ");
        }
        Console.ReadLine();
    }
}
*/