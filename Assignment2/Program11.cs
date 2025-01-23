/*using System;

class Program11
{
    // Function to calculate the sum until user enters 0 or a negative number
    static double CalculateSum()
    {
        double total = 0.0;  // Variable to store the sum of numbers
        double userInput;     // Variable to store the user's input

        // Infinite while loop
        while (true)
        {
            Console.WriteLine("Enter a number (or enter 0 or a negative number to stop):");
            userInput = Convert.ToDouble(Console.ReadLine());

            // If the user enters 0 or a negative number, break the loop
            if (userInput <= 0)
            {
                break;
            }

            // Add the entered number to the total
            total += userInput;
        }

        return total;
    }

    static void Main(string[] args)
    {
        // Call the CalculateSum function and store the result
        double total = CalculateSum();

        // Display the total sum
        Console.WriteLine($"Total sum: {total}");
    }
}
*/