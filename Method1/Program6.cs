using System;

public class Program
{
    // Method to calculate the sum of n natural numbers
    public static int SumOfNaturalNumbers(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    // Main method
    public static void Main(string[] args)
    {
        // Get user input
        Console.Write("Enter a positive integer (n): ");
        int n = int.Parse(Console.ReadLine());

        // Validate the input
        if (n < 1)
        {
            Console.WriteLine("Please enter a positive integer greater than 0.");
            return;
        }

        // Calculate the sum of n natural numbers
        int result = SumOfNaturalNumbers(n);

        // Display the result
        Console.WriteLine($"The sum of the first {n} natural numbers is: {result}");
    }
}
