/*using System;

class Program
{
    static void HeapSort(int[] salaries)
    {
        int n = salaries.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(salaries, n, i);

        for (int i = n - 1; i > 0; i--)
        {
            Swap(salaries, 0, i);
            Heapify(salaries, i, 0);
        }
    }

    static void Heapify(int[] salaries, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && salaries[left] > salaries[largest])
            largest = left;

        if (right < n && salaries[right] > salaries[largest])
            largest = right;

        if (largest != i)
        {
            Swap(salaries, i, largest);
            Heapify(salaries, n, largest);
        }
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    static void Main()
    {
        int[] salaryDemands = { 50000, 70000, 45000, 90000, 65000, 80000 };

        HeapSort(salaryDemands);

        PrintArray(salaryDemands);
        Console.ReadLine();
    }
}
*/