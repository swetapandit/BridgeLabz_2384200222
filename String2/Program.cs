/*using System;

class Program
{
    static void Main()
    {
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;  // Get current UTC time
        Console.WriteLine("UTC Time: " + utcNow);

        // Fetch different time zones
        TimeZoneInfo gmtZone = TimeZoneInfo.FindSystemTimeZoneById("GMT");  // GMT Time Zone
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");  // IST Time Zone
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");  // PST Time Zone

        // Convert UTC to these time zones
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcNow, gmtZone);
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcNow, istZone);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcNow, pstZone);

        // Display results
        Console.WriteLine("GMT Time: " + gmtTime);
        Console.WriteLine("IST Time: " + istTime);
        Console.WriteLine("PST Time: " + pstTime);
    }
}
*/