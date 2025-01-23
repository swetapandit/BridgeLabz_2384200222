/*using System;

class Program12
{
    // Function to compute the sum using while loop
    static int SumUsingWhileLoop(int n)
    {
        int total = 0;
        int i = 1;
        while (i <= n)
        {
            total += i;
            i++;
        }
        return total;
    }

    // Function to compute the sum using formula n*(n+1)/2
    static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2;
    }

    static void Main(string[] args)
    {
        // Take user input
        Console.WriteLine("Enter a natural number:");
        int n = Convert.ToInt32(Console.ReadLine());

        // Check if the input is a natural number
        if (n <= 0)
        {
            Console.WriteLine("Please enter a valid natural number (positive integer).");
        }
        else
        {
            // Compute sum using while loop
            int sumWhileLoop = SumUsingWhileLoop(n);

            // Compute sum using formula
            int sumFormula = SumUsingFormula(n);

            // Display the results
            Console.WriteLine($"Sum using while loop: {sumWhileLoop}");
            Console.WriteLine($"Sum using formula: {sumFormula}");

            // Compare the two results
            if (sumWhileLoop == sumFormula)
            {
                Console.WriteLine("Both computations are correct and match!");
            }
            else
            {
                Console.WriteLine("There seems to be a mismatch in the computations.");
            }
        }
    }
}
*/