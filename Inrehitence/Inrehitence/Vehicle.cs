/*using System;

class Vehicle
{
    private int maxSpeed;
    private string fuelType;

    public Vehicle(int maxSpeed, string fuelType)
    {
        this.maxSpeed = maxSpeed;
        this.fuelType = fuelType;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Maximum Speed: {maxSpeed}");
        Console.WriteLine($"Fuel Type: {fuelType}");
    }
}

class Car : Vehicle
{
    private int seatCapacity;
    public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType)
    {
        this.seatCapacity = seatCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Seat Capacity: {seatCapacity}");
    }
}

class Truck : Vehicle
{
    private int payLoadCapacity;
    public Truck(int maxSpeed, string fuelType, int payLoadCapacity) : base(maxSpeed, fuelType)
    {
        this.payLoadCapacity = payLoadCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Seat Capacity: {payLoadCapacity}");
    }
}

class MotorCycle : Vehicle
{
    private bool hasSideCar;
    public MotorCycle(int maxSpeed, string fuelType, bool hasSideCar) : base(maxSpeed, fuelType)
    {
        this.hasSideCar = hasSideCar;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Seat Capacity: {hasSideCar}");
    }
}

class Program
{
    public static void Main()
    {

        Vehicle vehicle = new Vehicle(50, "Petrol");
        vehicle.DisplayInfo();

        Vehicle vehicle1 = new Car(50, "Petrol", 5);
        vehicle1.DisplayInfo();

        Vehicle vehicle2 = new Truck(50, "Petrol", 200);
        vehicle2.DisplayInfo();

        Vehicle vehicle3 = new MotorCycle(50, "Petrol", true);
        vehicle3.DisplayInfo();

        Console.ReadLine();
    }
}*/