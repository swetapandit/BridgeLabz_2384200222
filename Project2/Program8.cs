/*using System;

class Program8
{
    public void ComputeTripDetails()
    {
        // Take user input for name and cities
        string name = Console.ReadLine();
        string fromCity = Console.ReadLine();
        string viaCity = Console.ReadLine();
        string toCity = Console.ReadLine();

        // Take user input for distances
        double fromToVia = Convert.ToDouble(Console.ReadLine());
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        // Take user input for the time taken
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        // Calculate total distance and average speed
        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        // Print the results
        Console.WriteLine($"The results of the trip are: {name}, traveling from {fromCity} via {viaCity} to {toCity}, covering {totalDistance} miles at an average speed of {averageSpeed} miles per hour.");
    }

    static void Main()
    {
        // Create an instance of Program2 and call the method
        Program8 program = new Program8();
        program.ComputeTripDetails();
    }
}*/
