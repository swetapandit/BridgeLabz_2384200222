/*using System;

class Program13
{
    // Function to compute the factorial using a while loop
    static int ComputeFactorial(int number)
    {
        int factorial = 1;

        // Using a for loop to compute the factorial
        for(int i=1; i<=number; i++) factorial *= i;

        return factorial;
    }

    static void Main(string[] args)
    {
        // Take user input
        Console.WriteLine("Enter a positive integer:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the entered number is positive
        if (number < 0)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else
        {
            // Call the function to compute the factorial
            int factorial = ComputeFactorial(number);

            // Print the factorial
            Console.WriteLine($"The factorial of {number} is: {factorial}");
        }
    }
}*/