/*using System;

class Calendar
{
    // Method to get the name of the month
    public static string GetMonthName(int month)
    {
        string[] months = {
            "January", "February", "March", "April", "May", "June", 
            "July", "August", "September", "October", "November", "December"
        };
        return months[month - 1];
    }

    // Method to check if a year is a leap year
    public static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
    }

    // Method to get the number of days in the month
    public static int GetNumberOfDaysInMonth(int month, int year)
    {
        int[] daysInMonth = { 31, (IsLeapYear(year) ? 29 : 28), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        return daysInMonth[month - 1];
    }

    // Method to get the first day of the month using the Gregorian calendar algorithm
    public static int GetFirstDayOfMonth(int month, int year)
    {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + 31 * m0 / 12) % 7;
        return d0;
    }

    // Method to display the calendar for a given month and year
    public static void DisplayCalendar(int month, int year)
    {
        string monthName = GetMonthName(month);
        int daysInMonth = GetNumberOfDaysInMonth(month, year);
        int firstDay = GetFirstDayOfMonth(month, year);

        Console.WriteLine($"Calendar for {monthName} {year}");
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // Add leading spaces for the first day
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("    ");
        }

        // Print the days of the month
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day,3} ");

            // Move to the next line after Saturday
            if ((day + firstDay) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine(); // Move to the next line after the calendar
    }

    static void Main()
    {
        // Taking user input for month and year
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());

        // Display the calendar
        DisplayCalendar(month, year);
    }
}
*/