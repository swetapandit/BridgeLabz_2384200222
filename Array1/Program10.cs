using System;

class Program10
{
    // FizzBuzz function
    static void FizzBuzz(int number)
    {
        // Create a string array to store the results
        string[] results = new string[number + 1];

        // Loop from 0 to the given number
        for (int i = 0; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0) // Check for multiples of both 3 and 5
            {
                results[i] = "FizzBuzz";
            }
            else if (i % 3 == 0) // Check for multiples of 3
            {
                results[i] = "Fizz";
            }
            else if (i % 5 == 0) // Check for multiples of 5
            {
                results[i] = "Buzz";
            }
            else // Otherwise, store the number as a string
            {
                results[i] = i.ToString();
            }
        }

        // Display the results with index positions
        Console.WriteLine("Results:");
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine($"Position {i} = {results[i]}");
        }
    }

    static void Main()
    {
        // Take user input for a number
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Validate the input
        if (number <= 0)
        {
            Console.Error.WriteLine("Invalid input! Please enter a positive integer.");
            Environment.Exit(0); // Exit if the input is not valid
        }

        // Call the FizzBuzz function
        FizzBuzz(number);
    }
}
