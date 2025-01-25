/*using System;

class Program2
{
    static void AnalyzeNumbers(int[] numbers)
    {
        Console.WriteLine("\nNumber Analysis:");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0) // Positive number
            {
                if (numbers[i] % 2 == 0) Console.WriteLine($"Number {numbers[i]} is positive and even.");
                else Console.WriteLine($"Number {numbers[i]} is positive and odd.");
            }
		// Negative number
            else if (numbers[i] < 0) Console.WriteLine($"Number {numbers[i]} is negative."); 
            else Console.WriteLine("Number 0 is zero.");
        }

        // Compare the first and last elements of the array
        Console.WriteLine("\nComparison of First and Last Elements:");
        if (numbers[0] == numbers[numbers.Length - 1]) Console.WriteLine("The first and last elements are equal.");
        else if (numbers[0] > numbers[numbers.Length - 1]) Console.WriteLine("The first element is greater than the last element.");
        else Console.WriteLine("The first element is less than the last element.");
    }

    static void Main()
    {
        int[] numbers = new int[5]; // Declare an integer array of size 5

        // Get user input to populate the array
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Call the function to analyze numbers
        AnalyzeNumbers(numbers);
    }
}*/
