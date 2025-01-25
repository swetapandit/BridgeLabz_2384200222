/*using System;

class Program3
{
    // Function to generate and print the multiplication table
    static void GenerateMultiplicationTable(int number)
    {
        int[] multiplicationTable = new int[10]; // Array to store the results

        // Generate multiplication results
        for (int i = 1; i <= 10; i++) multiplicationTable[i - 1] = number * i; // Store the result in the array

        // Display the multiplication table
        Console.WriteLine($"\nMultiplication Table of {number}:");
        for (int i = 1; i <= 10; i++) Console.WriteLine($"{number} * {i} = {multiplicationTable[i - 1]}");
    }

    static void Main()
    {
        Console.Write("Enter a number to generate its multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Call the function to generate and print the table
        GenerateMultiplicationTable(number);
    }
}
*/