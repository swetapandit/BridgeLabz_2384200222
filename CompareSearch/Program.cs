/*using System;
using System.Diagnostics;

class SearchComparison
{
    static void Main()
    {
        int N = 1000000;
        int[] data = GenerateData(N);
        int target = 999999;

        Stopwatch sw = Stopwatch.StartNew();
        int linearResult = LinearSearch(data, target);
        sw.Stop();
        Console.WriteLine($"Linear Search: Found at index {linearResult}, Time = {sw.ElapsedMilliseconds} ms");

        Array.Sort(data);
        sw.Restart();
        int binaryResult = BinarySearch(data, target);
        sw.Stop();
        Console.WriteLine($"Binary Search: Found at index {binaryResult}, Time = {sw.ElapsedMilliseconds} ms");
        Console.ReadLine();
    }

    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }

    static int[] GenerateData(int N)
    {
        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
            arr[i] = i + 1;
        return arr;
    }
}
*/