/*using System;

class Program
{
    static void QuickSort(double[] prices, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(prices, low, high);

            QuickSort(prices, low, pivotIndex - 1);  // Sort left partition
            QuickSort(prices, pivotIndex + 1, high); // Sort right partition
        }
    }

    static int Partition(double[] prices, int low, int high)
    {
        double pivot = prices[high]; // Choosing the last element as pivot
        int i = low - 1; // Index for smaller elements

        for (int j = low; j < high; j++)
        {
            if (prices[j] <= pivot)
            {
                i++;
                Swap(prices, i, j);
            }
        }

        Swap(prices, i + 1, high);
        return i + 1;
    }

    static void Swap(double[] arr, int i, int j)
    {
        double temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static void Main()
    {
        double[] productPrices = { 999.99, 299.50, 499.75, 150.25, 1299.00, 699.99 };

        QuickSort(productPrices, 0, productPrices.Length - 1);
        for (int i = 0; i < productPrices.Length; i++)
        {
            Console.WriteLine(" " + productPrices[i]);
        }
        Console.ReadLine();
    }
}
*/