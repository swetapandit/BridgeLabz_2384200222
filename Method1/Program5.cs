using System;

public class Program
{
    // Method to check if the given month and day fall in the Spring Season
    public static bool IsSpringSeason(int month, int day)
    {
        if ((month == 3 && day >= 20 && day <= 31) || // March 20 to March 31
            (month == 4 && day >= 1 && day <= 30) ||  // April (entire month)
            (month == 5 && day >= 1 && day <= 31) ||  // May (entire month)
            (month == 6 && day >= 1 && day <= 20))    // June 1 to June 20
        {
            return true; // It's Spring Season
        }
        return false; // Not Spring Season
    }

    // Main method
    public static void Main(string[] args)
    {
        // Input: month and day
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the day (1-31): ");
        int day = int.Parse(Console.ReadLine());

        // Validate the input month and day
        if (month < 1 || month > 12 || day < 1 || day > 31)
        {
            Console.WriteLine("Invalid input. Please enter a valid month (1-12) and day (1-31).");
            return;
        }

        // Check if it's Spring Season
        bool isSpring = IsSpringSeason(month, day);

        // Display the result
        if (isSpring)
        {
            Console.WriteLine("It's a Spring Season.");
        }
        else
        {
            Console.WriteLine("Not a Spring Season.");
        }
    }
}
