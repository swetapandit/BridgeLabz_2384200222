using System;

public class Program
{
    // Method to calculate trigonometric functions: sine, cosine, and tangent
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert angle from degrees to radians
        double radians = Math.PI * angle / 180;

        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        // Return the results in an array
        return new double[] { sine, cosine, tangent };
    }

    // Main method
    public static void Main(string[] args)
    {
        // Take user input for the angle in degrees
        Console.Write("Enter the angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());

        // Call the method to calculate trigonometric functions
        double[] result = CalculateTrigonometricFunctions(angle);

        // Display the results
        Console.WriteLine($"Sine of {angle}°: {result[0]:F4}");
        Console.WriteLine($"Cosine of {angle}°: {result[1]:F4}");
        Console.WriteLine($"Tangent of {angle}°: {result[2]:F4}");
    }
}
