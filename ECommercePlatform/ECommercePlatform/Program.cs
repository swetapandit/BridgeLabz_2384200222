using System;

namespace ECommercePlatform
{
    class Program
    {
        static void Main()
        {
            // Electronics product
            Electronics laptop = new Electronics();
            laptop.ProductId = 101;
            laptop.Name = "Laptop";
            laptop.Price = 50000;

            Console.WriteLine($"Product: {laptop.Name}");
            Console.WriteLine($"Original Price: {laptop.Price}");
            Console.WriteLine($"Discount: {laptop.CalculateDiscount()}");
            laptop.GetTaxDetails();
            Console.WriteLine("----------------------------------");

            // Clothing product
            Clothing tshirt = new Clothing();
            tshirt.ProductId = 102;
            tshirt.Name = "T-Shirt";
            tshirt.Price = 1000;

            Console.WriteLine($"Product: {tshirt.Name}");
            Console.WriteLine($"Original Price: {tshirt.Price}");
            Console.WriteLine($"Discount: {tshirt.CalculateDiscount()}");
            tshirt.GetTaxDetails();
            Console.WriteLine("----------------------------------");

            // Groceries product
            Groceries rice = new Groceries();
            rice.ProductId = 103;
            rice.Name = "Rice Bag";
            rice.Price = 2000;

            Console.WriteLine($"Product: {rice.Name}");
            Console.WriteLine($"Original Price: {rice.Price}");
            Console.WriteLine($"Discount: {rice.CalculateDiscount()}");
            rice.GetTaxDetails();
            Console.ReadLine();

        }
    }
}
