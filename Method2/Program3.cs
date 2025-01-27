/*using System;

class Program3
{
    // Method to check if a year is a leap year
    public bool IsLeap(int year)
    {
        return year >= 1582 && ((year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0));
    }

    // Main method
    public static void Main()
    {
        Console.Write("Enter a year (>= 1582): ");
        int year = int.Parse(Console.ReadLine());

        if (year >= 1582)
        {
            Program p = new Program(); // Instance Created

            // Checking if the year is a leap year or not
            if (p.IsLeap(year))
                Console.WriteLine($"{year} is a Leap Year");
            else
                Console.WriteLine($"{year} is not a Leap Year");
        }
        else
        {
            Console.WriteLine("The program only works for years >= 1582.");
        }
    }
}*/
