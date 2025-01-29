/*using System;

public class Program1
{
    // Method to generate random heights for players
    public int[] GeneratePlayerHeights(int size)
    {
        Random random = new Random();
        int[] heights = new int[size];

        for (int i = 0; i < size; i++)
        {
            heights[i] = random.Next(150, 251); // Random height between 150 and 250 cm
        }

        return heights;
    }

    // Method to find the sum of all heights
    public int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }

    // Method to find the mean height
    public double FindMean(int[] heights)
    {
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }

    // Method to find the shortest height
    public int FindShortest(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            shortest = Math.Min(shortest, height);
        }
        return shortest;
    }

    // Method to find the tallest height
    public int FindTallest(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            tallest = Math.Max(tallest, height);
        }
        return tallest;
    }

    // Main method
    public static void Main(string[] args)
    {
        Program1 program = new Program1();

        // Generate random heights for 11 players
        int[] heights = program.GeneratePlayerHeights(11);

        // Display all player heights
        Console.WriteLine("Heights of players in the football team (in cm):");
        foreach (int height in heights)
        {
            Console.WriteLine(height);
        }

        // Calculate and display the results
        double meanHeight = program.FindMean(heights);
        int shortestHeight = program.FindShortest(heights);
        int tallestHeight = program.FindTallest(heights);

        Console.WriteLine($"\nMean height of the players: {meanHeight:F2} cm");
        Console.WriteLine($"Shortest height of the players: {shortestHeight} cm");
        Console.WriteLine($"Tallest height of the players: {tallestHeight} cm");
    }
}
*/