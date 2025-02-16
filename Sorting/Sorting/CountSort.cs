/*using System;

class Program
{
    static void CountingSort(int[] ages, int min, int max)
    {
        int range = max - min + 1;
        int[] count = new int[range];
        int[] output = new int[ages.Length];

        for (int i = 0; i < ages.Length; i++)
            count[ages[i] - min]++;

        for (int i = 1; i < range; i++)
            count[i] += count[i - 1];

        for (int i = ages.Length - 1; i >= 0; i--)
        {
            output[count[ages[i] - min] - 1] = ages[i];
            count[ages[i] - min]--;
        }

        for (int i = 0; i < ages.Length; i++)
            ages[i] = output[i];
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    static void Main()
    {
        int[] studentAges = { 12, 15, 14, 18, 11, 10, 17, 13, 12, 16 };

        CountingSort(studentAges, 10, 18);

        PrintArray(studentAges);
        Console.ReadLine();
    }
}
*/