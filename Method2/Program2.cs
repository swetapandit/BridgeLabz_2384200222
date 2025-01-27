/*using System;

class Program2
{
    // Method to find the sum of n natural numbers using recursion
    public static int SumUsingRecursion(int n)
    {
        if (n == 1) return 1;
        return n + SumUsingRecursion(n - 1);
    }

    // Method to find the sum of n natural numbers using the formula
    public static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2;
    }

    // Method to compare results and display output
    public static void CompareResults(int n)
    {
        // Calculate sum using recursion
        int sumRecursion = SumUsingRecursion(n);

        // Calculate sum using the formula
        int sumFormula = SumUsingFormula(n);

        // Display results
        Console.WriteLine($"Sum using recursion: {sumRecursion}");
        Console.WriteLine($"Sum using formula: {sumFormula}");

        // Compare results
        if (sumRecursion == sumFormula) Console.WriteLine("The results from both computations are correct and match.");
        else Console.WriteLine("There is a mismatch between the results.");
    }

    // Main method
    public static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0) CompareResults(n);
        else Console.WriteLine("Invalid input! Please enter a natural number greater than 0.");
    }
}*/