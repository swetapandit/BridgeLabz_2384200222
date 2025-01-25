/*using System;

class Program7
{
    // Function to categorize numbers as odd and even
    static void CategorizeNumbers(int number)
    {
        // Create arrays for odd and even numbers
        int[] evenNumbers = new int[number / 2 + 1];
        int[] oddNumbers = new int[number / 2 + 1];
        
        int evenIndex = 0, oddIndex = 0;

        // Loop through 1 to the entered number
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex] = i;
                evenIndex++;
            }
            else
            {
                oddNumbers[oddIndex] = i;
                oddIndex++;
            }
        }

        // Display Odd Numbers
        Console.WriteLine("\nOdd Numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }

        // Display Even Numbers
        Console.WriteLine("\nEven Numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
    }

    static void Main()
    {
        // Take input for a number
        Console.Write("Enter a number: ");
        
        // Try to parse the input and check for negative numbers
        int number = int.Parse(Console.ReadLine());

        // Validate the input
        if (number <= 0)
        {
            Console.Error.WriteLine("Invalid Number. Please enter a positive number.");
            Environment.Exit(0);  // Exit the program if invalid
        }

        // Call the function to categorize numbers
        CategorizeNumbers(number);
    }
}
*/