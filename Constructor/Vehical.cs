/*using System;

class Vehicle
{
    // Instance Variables (unique for each vehicle)
    public string ownerName;
    public string vehicleType;

    // Class Variable (shared among all vehicles)
    public static double registrationFee = 5000;

    // Constructor to initialize vehicle details
    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Instance Method to display vehicle details
    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Owner: {this.ownerName}, Vehicle Type: {this.vehicleType}, Registration Fee: {registrationFee:C}");
    }

    // Class Method to update the registration fee for all vehicles
    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the Owner Name ");
        string ownerName = Console.ReadLine();

        Console.WriteLine("Enter the Vehicle Type ");
        string vehicleType = Console.ReadLine();

        // Creating Vehicle Objects
        Vehicle vehicle1 = new Vehicle(ownerName, vehicleType);
        Vehicle vehicle2 = new Vehicle(ownerName, vehicleType);
        Vehicle vehicle3 = new Vehicle(ownerName, vehicleType);

        // Displaying Individual Vehicle Details
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();
        vehicle3.DisplayVehicleDetails();

        Console.WriteLine();

        // Updating the Registration Fee
        Vehicle.UpdateRegistrationFee(6000);

        // Displaying Updated Vehicle Details
        Console.WriteLine("After Updating Registration Fee:");
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();
        vehicle3.DisplayVehicleDetails();
        Console.ReadLine();
    }
}
*/