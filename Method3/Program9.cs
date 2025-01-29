/*using System;

class EuclideanDistanceAndLineEquation
{
    // Method to calculate the Euclidean distance between two points (x1, y1) and (x2, y2)
    public static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));  // Euclidean Distance formula
    }

    // Method to find the equation of the line given two points
    public static double[] CalculateLineEquation(double x1, double y1, double x2, double y2)
    {
        double[] lineEquation = new double[2];  // Array to store slope (m) and y-intercept (b)

        // Calculate the slope (m)
        double m = (y2 - y1) / (x2 - x1);

        // Calculate the y-intercept (b)
        double b = y1 - m * x1;

        // Store the results in the array
        lineEquation[0] = m;  // Slope
        lineEquation[1] = b;  // Y-intercept

        return lineEquation;
    }

    static void Main()
    {
        // Input for two points (x1, y1) and (x2, y2)
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        // Calculate and display the Euclidean distance
        double distance = CalculateEuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine($"Euclidean distance between the points: {distance:F2}");

        // Calculate and display the equation of the line
        double[] lineEquation = CalculateLineEquation(x1, y1, x2, y2);
        Console.WriteLine($"Equation of the line: y = {lineEquation[0]:F2}x + {lineEquation[1]:F2}");
    }
}
*/