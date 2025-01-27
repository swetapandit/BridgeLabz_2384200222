using System;

public class Program
{
    // Method to find the quotient and remainder
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;   // Division to get the quotient
        int remainder = number % divisor;  // Modulus to get the remainder
        return new int[] { quotient, remainder };
    }

    // Main method
    public static void Main(string[] args)
    {
        // Take user input for the number and divisor
        Console.Write("Enter the dividend (number): ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        // Ensure divisor is not zero
        if (divisor == 0)
        {
            Console.WriteLine("Divisor cannot be zero.");
            return;
        }

        // Call the method to find quotient and remainder
        int[] result = FindRemainderAndQuotient(number, divisor);

        // Display the result
        Console.WriteLine($"The quotient is: {result[0]}");
        Console.WriteLine($"The remainder is: {result[1]}");
    }
}
