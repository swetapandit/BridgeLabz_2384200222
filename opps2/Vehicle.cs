/*using System;

class Vehicle
{
    public static double RegistrationFee = 5000; // Shared registration fee for all vehicles
    private static int totalVehicles = 0; // Counter for total registered vehicles

    private readonly int RegistrationNumber; // Unique registration number, cannot be changed
    private string OwnerName;
    private string VehicleType;

    // Constructor using 'this' keyword
    public Vehicle(int regNumber, string owner, string type)
    {
        this.RegistrationNumber = regNumber;
        this.OwnerName = owner;
        this.VehicleType = type;
        totalVehicles++; // Increment vehicle count
    }

    // Static method to update registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
        Console.WriteLine($"\nUpdated Registration Fee: {RegistrationFee}");
    }

    // Static method to display total vehicles registered
    public static void DisplayTotalVehicles()
    {
        Console.WriteLine($"\nTotal registered vehicles: {totalVehicles}\n");
    }

    // Method to display vehicle details
    public void DisplayVehicleInfo()
    {
        if (this is Vehicle) // Checking instance before displaying
        {
            Console.WriteLine($"Owner: {OwnerName}");
            Console.WriteLine($"Vehicle Type: {VehicleType}");
            Console.WriteLine($"Registration Number: {RegistrationNumber}");
            Console.WriteLine($"Registration Fee: {RegistrationFee}\n");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter number of vehicles to register: ");
        int numVehicles = int.Parse(Console.ReadLine());

        Vehicle[] vehicles = new Vehicle[numVehicles];

        // Taking user input to register vehicles
        for (int i = 0; i < numVehicles; i++)
        {
            Console.WriteLine($"\nEnter details for Vehicle {i + 1}:");
            Console.Write("Registration Number: ");
            int regNumber = int.Parse(Console.ReadLine());
            Console.Write("Owner Name: ");
            string owner = Console.ReadLine();
            Console.Write("Vehicle Type (Car/Bike/Truck etc.): ");
            string type = Console.ReadLine();

            vehicles[i] = new Vehicle(regNumber, owner, type);
        }

        // Displaying all vehicle details
        Console.WriteLine("\nRegistered Vehicles:");
        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayVehicleInfo();
        }

        // Updating registration fee
        Console.Write("\nEnter new registration fee: ");
        double newFee = double.Parse(Console.ReadLine());
        Vehicle.UpdateRegistrationFee(newFee);

        // Display total registered vehicles
        Vehicle.DisplayTotalVehicles();

        Console.ReadLine();
    }
}
*/