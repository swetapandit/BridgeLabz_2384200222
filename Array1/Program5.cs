/*using System;

class Program5
{
    // Function to calculate the multiplication table and display the result
    static void DisplayMultiplicationTable(int number)
    {
        int[] multiplicationResult = new int[4]; // Array to store results for 6 to 9

        Console.WriteLine($"\nMultiplication table of {number} from 6 to 9:");

        // Loop from 6 to 9 and calculate the multiplication
        for (int i = 6; i <= 9; i++)
        {
            multiplicationResult[i - 6] = number * i;
            Console.WriteLine($"{number} * {i} = {multiplicationResult[i - 6]}");
        }
    }

    static void Main()
    {
        Console.Write("Enter a number to find its multiplication table from 6 to 9: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Call the function to display the multiplication table
        DisplayMultiplicationTable(number);
    }
}
*/