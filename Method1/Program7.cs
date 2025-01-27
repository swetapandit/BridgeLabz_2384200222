using System;

public class Program
{
    // Method to find the smallest and largest of three numbers
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int smallest = Math.Min(number1, Math.Min(number2, number3));
        int largest = Math.Max(number1, Math.Max(number2, number3));
        return new int[] { smallest, largest };
    }

    // Main method
    public static void Main(string[] args)
    {
        // Take user input for three numbers
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int number3 = int.Parse(Console.ReadLine());

        // Call the method to find smallest and largest
        int[] result = FindSmallestAndLargest(number1, number2, number3);

        // Display the result
        Console.WriteLine($"The smallest number is: {result[0]}");
        Console.WriteLine($"The largest number is: {result[1]}");
    }
}
