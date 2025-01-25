/*using System;

class Program6
{
    // Function to calculate the mean height
    static void CalculateMeanHeight(double[] heights)
    {
        double sum = 0.0;

        // Calculate the sum of all heights
        for (int i = 0; i < heights.Length; i++) sum += heights[i];

        // Calculate the mean height
        double meanHeight = sum / heights.Length;

        // Display the mean height
        Console.WriteLine($"\nThe mean height of the football team is: {meanHeight:F2} meters.");
    }

    static void Main()
    {
        double[] heights = new double[11]; // Array to store the heights of 11 players

        Console.WriteLine("Enter the heights of the 11 players:");

        // Get input from the user
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Enter height of player {i + 1}: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Call the function to calculate and display the mean height
        CalculateMeanHeight(heights);
    }
}
*/