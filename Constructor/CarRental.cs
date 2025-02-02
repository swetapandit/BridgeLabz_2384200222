/*using System;

class CarRental
{
    private string customerName;
    private string carModel;
    private int rentalDays;
    private double rentalCostPerDay = 1000;  // Fixed daily rental cost

    // Default Constructor
    public CarRental()
    {
        this.customerName = "";
        this.carModel = "";
        this.rentalDays = 1;
    }

    // Parameterized Constructor
    public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
    }

    // Copy Constructor
    public CarRental(CarRental other)
    {
        this.customerName = other.customerName;
        this.carModel = other.carModel;
        this.rentalDays = other.rentalDays;
    }

    // Method to calculate total rental cost
    public double CalculateTotalCost()
    {
        return this.rentalDays * this.rentalCostPerDay;
    }

    // Display rental details
    public void DisplayDetails()
    {
        Console.WriteLine($"Customer: {this.customerName}\nCar Model: {this.carModel}\nRental Days: {this.rentalDays}\nTotal Cost: {this.CalculateTotalCost():C}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the Customer Name ");
        string customerName = Console.ReadLine();

        Console.WriteLine("Enter the Car model ");
        string carModel = Console.ReadLine();

        Console.WriteLine("Enter No. of Rental Days ");
        int rentalDays = Convert.ToInt32(Console.ReadLine());


        // Using Default Constructor
        CarRental rental1 = new CarRental();
        Console.WriteLine("Rental 1 (Default Constructor):");
        rental1.DisplayDetails();

        Console.WriteLine();

        // Using Parameterized Constructor
        CarRental rental2 = new CarRental(customerName, carModel, rentalDays);
        Console.WriteLine("Rental 2 (Parameterized Constructor):");
        rental2.DisplayDetails();

        Console.WriteLine();

        // Using Copy Constructor
        CarRental rental3 = new CarRental(rental2);
        Console.WriteLine("Rental 3 (Copy Constructor - Cloned from Rental 2):");
        rental3.DisplayDetails();

        Console.ReadLine();
    }
}
*/