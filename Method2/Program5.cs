/*using System;

class Program4
{
    // Method to convert kilometers to miles
    public static double ConvertKmToMiles(double km)
    {
        double km2miles = 0.621371;
        return km * km2miles;
    }

    // Method to convert miles to kilometers
    public static double ConvertMilesToKm(double miles)
    {
        double miles2km = 1.60934;
        return miles * miles2km;
    }

    // Method to convert meters to feet
    public static double ConvertMetersToFeet(double meters)
    {
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }

    // Method to convert feet to meters
    public static double ConvertFeetToMeters(double feet)
    {
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }

    // Method to convert yards to feet
    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3;
        return yards * yards2feet;
    }

    // Method to convert feet to yards
    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    // Method to convert meters to inches
    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    // Method to convert inches to meters
    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    // Method to convert inches to centimeters
    public static double ConvertInchesToCm(double inches)
    {
        double inches2cm = 2.54;
        return inches * inches2cm;
    }

    // Main method
    public static void Main()
    {
        Console.WriteLine("Unit Converter:");

        Console.Write("Enter kilometers to convert to miles: ");
        double km = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{km} kilometers = {ConvertKmToMiles(km)} miles");

        Console.Write("Enter miles to convert to kilometers: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{miles} miles = {ConvertMilesToKm(miles)} kilometers");

        Console.Write("Enter meters to convert to feet: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{meters} meters = {ConvertMetersToFeet(meters)} feet");

        Console.Write("Enter feet to convert to meters: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{feet} feet = {ConvertFeetToMeters(feet)} meters");

        Console.Write("Enter yards to convert to feet: ");
        double yards = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{yards} yards = {ConvertYardsToFeet(yards)} feet");

        Console.Write("Enter feet to convert to yards: ");
        feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{feet} feet = {ConvertFeetToYards(feet)} yards");

        Console.Write("Enter meters to convert to inches: ");
        meters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{meters} meters = {ConvertMetersToInches(meters)} inches");

        Console.Write("Enter inches to convert to meters: ");
        double inches = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{inches} inches = {ConvertInchesToMeters(inches)} meters");

        Console.Write("Enter inches to convert to centimeters: ");
        inches = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{inches} inches = {ConvertInchesToCm(inches)} centimeters");
    }
}
*/