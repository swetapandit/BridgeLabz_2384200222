/*using System;

class Program
{
    public static void SearchNegative(int[] arr)
    {
        foreach (int ele in arr)
        {
            if (ele < 0)
            {
                Console.WriteLine($"{ele} is negative");
                return;
            }
        }
        Console.WriteLine("Every Number is Positive");
    }
    public static void Main()
    {
        Console.WriteLine("Enter the no. of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++) arr[i] = Convert.ToInt32(Console.ReadLine());
        SearchNegative(arr);
        Console.ReadLine();
    }
}*/