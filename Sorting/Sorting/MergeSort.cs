/*using System;

class Program
{
    static void MergeSort(double[] prices, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            // Recursively sort the left and right halves
            MergeSort(prices, left, mid);
            MergeSort(prices, mid + 1, right);

            // Merge the sorted halves
            Merge(prices, left, mid, right);
        }
    }

    static void Merge(double[] prices, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        double[] leftArr = new double[n1];
        double[] rightArr = new double[n2];

        for (int i = 0; i < n1; i++)
            leftArr[i] = prices[left + i];

        for (int j = 0; j < n2; j++)
            rightArr[j] = prices[mid + 1 + j];

        int iIndex = 0, jIndex = 0, k = left;

        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArr[iIndex] <= rightArr[jIndex])
            {
                prices[k] = leftArr[iIndex];
                iIndex++;
            }
            else
            {
                prices[k] = rightArr[jIndex];
                jIndex++;
            }
            k++;
        }

        while (iIndex < n1)
        {
            prices[k] = leftArr[iIndex];
            iIndex++;
            k++;
        }

        while (jIndex < n2)
        {
            prices[k] = rightArr[jIndex];
            jIndex++;
            k++;
        }

        
    }
    static void Main()
    {
        double[] bookPrices = { 499.99, 199.50, 349.75, 150.25, 699.00, 299.99 };
        int n = bookPrices.Length;
        MergeSort(bookPrices, 0, bookPrices.Length - 1);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(" " + bookPrices[i]);
        }
        Console.ReadLine();
    }
}*/