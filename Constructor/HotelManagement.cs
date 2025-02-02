/*using System;

class HotelManagement {

    private string guestName;
    private string roomType;
    private int nights;

    public HotelManagement() {
        this.guestName = "";
        this.roomType = "standard";
        this.nights = 1;
    }

    public HotelManagement(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    public HotelManagement(HotelManagement hm)
    {
        this.guestName = hm.guestName;
        this.roomType = hm.roomType;
        this.nights = hm.nights;
    }

    public void Display()
    {
        Console.WriteLine($"Name of the guest {this.guestName}");
        Console.WriteLine($"Type of the room {this.roomType}");
        Console.WriteLine($"No. of the Nights {this.nights}");
    }

    public static void Main()
    {
        Console.WriteLine("Enter the name of the guest ");
        string guestName = Console.ReadLine();
        Console.WriteLine("Enter the room type required ");
        string roomType = Console.ReadLine();
        Console.WriteLine("Enter the no. of nights to stay ");
        int nights = Convert.ToInt32(Console.ReadLine());

        HotelManagement h1 = new HotelManagement();
        Console.WriteLine("Default Construstor");
        h1.Display();

        Console.WriteLine("-------------------------------");

        HotelManagement h2 = new HotelManagement(guestName, roomType,nights);
        Console.WriteLine("Parameterized Construstor");
        h1.Display();

        Console.WriteLine("-------------------------------");

        HotelManagement h3 = new HotelManagement(h2);
        Console.WriteLine("Copy Construstor");
        h1.Display();
        Console.ReadLine();
    }
}*/