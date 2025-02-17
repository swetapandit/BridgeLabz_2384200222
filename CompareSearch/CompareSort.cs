/*using System;
using System.Diagnostics;

class SortingComparison
{
    static void Main()
    {
        int N = 10_000;
        int[] data1 = GenerateRandomData(N);
        int[] data2 = (int[])data1.Clone();
        int[] data3 = (int[])data1.Clone();

        Stopwatch sw = Stopwatch.StartNew();
        BubbleSort(data1);
        sw.Stop();
        Console.WriteLine($"Bubble Sort: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        MergeSort(data2, 0, data2.Length - 1);
        sw.Stop();
        Console.WriteLine($"Merge Sort: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        QuickSort(data3, 0, data3.Length - 1);
        sw.Stop();
        Console.WriteLine($"Quick Sort: {sw.ElapsedMilliseconds} ms");
        Console.ReadLine();
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left >= right) return;
        int mid = (left + right) / 2;
        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);
        Merge(arr, left, mid, right);
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;

        while (i <= mid && j <= right)
            temp[k++] = arr[i] <= arr[j] ? arr[i++] : arr[j++];

        while (i <= mid) temp[k++] = arr[i++];
        while (j <= right) temp[k++] = arr[j++];

        for (i = left, k = 0; i <= right; i++, k++)
            arr[i] = temp[k];
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low >= high) return;
        int pivot = Partition(arr, low, high);
        QuickSort(arr, low, pivot - 1);
        QuickSort(arr, pivot + 1, high);
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high], i = low;
        for (int j = low; j < high; j++)
            if (arr[j] < pivot)
                (arr[i], arr[j]) = (arr[j], arr[i++]);

        (arr[i], arr[high]) = (arr[high], arr[i]);
        return i;
    }

    static int[] GenerateRandomData(int N)
    {
        Random rand = new Random();
        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
            arr[i] = rand.Next(N);
        return arr;
    }
}
*/