using System;

// Abstract class Vehicle
abstract class Vehicle
{
    protected int maxSpeed;
    protected string model;

    public Vehicle(int maxSpeed, string model)
    {
        this.maxSpeed = maxSpeed;
        this.model = model;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Model: " + model + ", Max Speed: " + maxSpeed + " km/h");
    }
}

// Interface for refuelable vehicles
interface IRefuelable
{
    void Refuel();
}

// Derived class for Electric Vehicles
class ElectricVehicle : Vehicle
{
    private int batteryCapacity; // in kWh

    public ElectricVehicle(int maxSpeed, string model, int batteryCapacity)
        : base(maxSpeed, model)
    {
        this.batteryCapacity = batteryCapacity;
    }

    public void Charge()
    {
        Console.WriteLine(model + " is charging. Battery capacity: " + batteryCapacity + " kWh");
    }
}

// Derived class for Petrol Vehicles implementing IRefuelable
class PetrolVehicle : Vehicle, IRefuelable
{
    private int fuelCapacity; // in liters

    public PetrolVehicle(int maxSpeed, string model, int fuelCapacity)
        : base(maxSpeed, model)
    {
        this.fuelCapacity = fuelCapacity;
    }

    public void Refuel()
    {
        Console.WriteLine(model + " is refueling. Fuel capacity: " + fuelCapacity + " liters");
    }
}

// Main Program
class Program
{
    static void Main()
    {
        ElectricVehicle tesla = new ElectricVehicle(200, "Tesla Model S", 100);
        PetrolVehicle honda = new PetrolVehicle(180, "Honda Civic", 50);

        tesla.DisplayInfo();
        tesla.Charge();

        Console.WriteLine();

        honda.DisplayInfo();
        honda.Refuel();

        Console.ReadLine();
    }
}
