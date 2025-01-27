using System;

public class Program
{
    // Method to check the sign of a number
    public static int CheckNumberSign(int number)
    {
        if (number > 0)
            return 1; // Positive number
        else if (number < 0)
            return -1; // Negative number
        else
            return 0; // Zero
    }

    // Main method
    public static void Main(string[] args)
    {
        // Get user input
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        // Call the method to check the sign
        int result = CheckNumberSign(number);

        // Display the result
        if (result == 1)
            Console.WriteLine("The number is positive.");
        else if (result == -1)
            Console.WriteLine("The number is negative.");
        else
            Console.WriteLine("The number is zero.");
    }
}
