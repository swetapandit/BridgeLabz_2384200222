using System;

public class Program12
{
    // Method to generate an array of 4-digit random numbers
    public int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] randomNumbers = new int[size];
        
        for (int i = 0; i < size; i++) randomNumbers[i] = random.Next(1000, 10000); // Generate a random 4-digit number
        
        return randomNumbers;
    }

    // Method to find average, min, and max values of an array
    public double[] FindAverageMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        int sum = 0;
        
        foreach (int num in numbers)
        {
            min = Math.Min(min, num);
            max = Math.Max(max, num);
            sum += num;
        }
        
        double average = (double)sum / numbers.Length;
        return new double[] { average, min, max };
    }

    // Main method
    public static void Main(string[] args)
    {
        Program12 program = new Program12();
        
        // Generate an array of five 4-digit random numbers
        int[] randomNumbers = program.Generate4DigitRandomArray(5);
        
        // Display the generated numbers
        Console.WriteLine("Generated 4-digit random numbers:");
        foreach (int num in randomNumbers) Console.WriteLine(num);
        // Find and display the average, min, and max values
        double[] results = program.FindAverageMinMax(randomNumbers);
        Console.WriteLine($"\nAverage: {results[0]:F2}");
        Console.WriteLine($"Minimum: {results[1]}");
        Console.WriteLine($"Maximum: {results[2]}");
    }
}
