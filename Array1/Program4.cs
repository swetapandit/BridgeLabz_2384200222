/*using System;

class Program4
{
    // Function to process numbers and calculate total
    static void ProcessNumbers(double[] numbers, int count)
    {
        double total = 0.0;

        // Display all numbers entered
        Console.WriteLine("\nNumbers entered:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i]; // Add to total
        }

        // Display the total
        Console.WriteLine($"\nThe total of all numbers is: {total}");
    }

    static void Main()
    {
        double[] numbers = new double[10]; // Array to store up to 10 elements
        int index = 0; // Variable to track the current index of the array

        Console.WriteLine("Enter numbers (up to 10). Enter 0 or a negative number to stop:");

        while (true)
        {
            Console.Write($"Enter number {index + 1}: ");
            double input = Convert.ToDouble(Console.ReadLine());

            // Check for 0 or negative input
            if (input <= 0)
            {
                Console.WriteLine("Input is 0 or negative. Stopping input.");
                break;
            }

            // Store valid input in the array
            numbers[index] = input;
            index++;

            // Stop input if array is full
            if (index == 10)
            {
                Console.WriteLine("Array limit of 10 reached. Stopping input.");
                break;
            }
        }

        // Call the function to process numbers and calculate total
        ProcessNumbers(numbers, index);
    }
}*/