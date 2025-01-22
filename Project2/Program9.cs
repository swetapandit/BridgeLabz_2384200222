/*using System;

class Program9
{
    // Method to calculate the number of rounds
    public void CalculateRounds()
    {
        // Take input for the three sides of the triangular park in meters
        double side1 = Convert.ToDouble(Console.ReadLine());
        double side2 = Convert.ToDouble(Console.ReadLine());
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Calculate the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Total distance to cover in meters (5 km = 5000 meters)
        double totalDistance = 5000;

        // Calculate the number of rounds required
        double rounds = totalDistance / perimeter;

        // Print the result rounded to the nearest whole number
        Console.WriteLine($"The total number of rounds the athlete will run is {Math.Ceiling(rounds)} to complete 5 km");
    }

    static void Main()
    {
        // Create an instance of Program9 and call the method
        Program9 program = new Program9();
        program.CalculateRounds();
    }
}
*/