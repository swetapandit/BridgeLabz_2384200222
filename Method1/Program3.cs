using System;

public class Program
{
    // Method to calculate the number of rounds
    public static double CalculateRounds(double side1, double side2, double side3, double totalDistance)
    {
        // Calculate the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Calculate the number of rounds needed
        return totalDistance / perimeter;
    }

    // Main method
    public static void Main(string[] args)
    {
        // Take user input for the three sides of the triangular park
        Console.Write("Enter the length of side 1 (in meters): ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of side 2 (in meters): ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of side 3 (in meters): ");
        double side3 = double.Parse(Console.ReadLine());

        // Total distance the athlete wants to run in meters
        double totalDistance = 5000; // 5 km = 5000 meters

        // Calculate the number of rounds
        double rounds = CalculateRounds(side1, side2, side3, totalDistance);

        // Display the result
        Console.WriteLine($"The athlete needs to complete {Math.Ceiling(rounds)} rounds to complete a 5 km run.");
    }
}
