/*using System;

namespace Generics
{
    //Generic Class
    class Storage<T> where T: WareHouseItem
    {
        private List<T> data = new List<T>();
        public void AddItem(T item)
        {
            data.Add(item);
        }
        public void Display()
        {
            foreach (var i in data) i.DisplayInfo();
        }
    }
    // WareHouse Abstract class
    abstract class WareHouseItem
    {
        public string name;
        public double price;
        protected WareHouseItem(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public abstract void DisplayInfo();
    }

    //Electronics Class
    class Electronics : WareHouseItem
    {
        public string brand;
        public Electronics(string name, double price, string brand): base(name, price)
        {
            this.brand = brand;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Price: " + price);
        }
    }

    //Groceries Class
    class Groceries : WareHouseItem
    {
        public string expiryDate;
        public Groceries(string name, double price, string expiryDate) : base(name, price)
        {
            this.expiryDate = expiryDate;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Expiry Date: " + expiryDate);
        }
    }

    // Furniture Class
    class Furniture : WareHouseItem
    {
        public string material;
        public Furniture(string name, double price, string material) : base(name, price)
        {
            this.material = material;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Material Used: " + material);
        }
    }
    class Program
    {
        public static void Main()
        {
            Storage<Electronics> storageE = new Storage<Electronics>();
            Storage<Groceries> storageG = new Storage<Groceries>();
            Storage<Furniture> storageF = new Storage<Furniture>();

            storageE.AddItem(new Electronics("Laptop", 23000, "Dell"));
            storageE.AddItem(new Electronics("IPhone", 50000, "Apple"));
            storageE.AddItem(new Electronics("KeyBoard", 3000, "Intel"));
            storageE.Display();
            Console.WriteLine("--------------------------");

            storageG.AddItem(new Groceries("Milk", 30, "2025-02-25"));
            storageG.AddItem(new Groceries("Bread", 20, "2025-03-01"));
            storageG.Display();
            Console.WriteLine("--------------------------");

            storageF.AddItem(new Furniture("Chair", 500, "Wood"));
            storageF.AddItem(new Furniture("Table", 150, "Metals"));
            storageF.Display();
            Console.WriteLine("--------------------------");

            Console.ReadLine();
        }
    }
}*/