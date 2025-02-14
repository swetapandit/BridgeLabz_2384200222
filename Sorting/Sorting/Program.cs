/*using System;

class Sorting
{
    public void SortArr(int[] arr)
    {
        int n = arr.Length;
        for(int i = 0; i<n-1; i++)
        {
            for(int j=0; j<n-i-1 ; j++)
            {
                if (arr[j] > arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
    }
}

class Program
{
    public static void Main()
    {
        int[] arr = { -1, 2, 4, 1, -3, 5 };
        Sorting sorting = new Sorting();
        sorting.SortArr(arr);

        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(" " + arr[i]);
        }
        Console.ReadLine();
    }
}
*/