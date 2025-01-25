/*using System;

class Program8
{
    // Function to find factors of a number and display them
    static void FindFactors(int number)
    {
        int maxFactor = 10;  // Initial size for the factors array
        int[] factors = new int[maxFactor];  // Array to store factors
        int index = 0;  // Index to keep track of the next available position in the array

        // Loop through numbers from 1 to the given number to find factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)  // If 'i' is a factor of the number
            {
                // Check if the factors array has enough space
                if (index == maxFactor)
                {
                    // Double the size of the array if needed
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    Array.Copy(factors, temp, factors.Length);  // Copy existing factors to temp array
                    factors = temp;  // Assign temp to factors
                }

                factors[index] = i;  // Store the factor in the array
                index++;  // Increment index
            }
        }

        // Display the factors
        Console.WriteLine($"Factors of {number}:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
    }

    static void Main()
    {
        // Take input from the user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Call the function to find and display the factors
        FindFactors(number);
    }
}
*/