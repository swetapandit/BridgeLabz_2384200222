//using System;

//class Program
//{
//    static double CalculateInterest(double amount, double rate, int years)
//    {
//        if (amount < 0 || rate < 0)
//        {
//            throw new ArgumentException("Invalid input: Amount and rate must be positive");
//        }

//        // Simple Interest Formula: Interest = (P * R * T) / 100
//        return (amount * rate * years) / 100;
//    }

//    static void Main()
//    {
//        try
//        {
//            // Taking user input
//            Console.Write("Enter principal amount: ");
//            double amount = double.Parse(Console.ReadLine());

//            Console.Write("Enter annual interest rate (%): ");
//            double rate = double.Parse(Console.ReadLine());

//            Console.Write("Enter number of years: ");
//            int years = int.Parse(Console.ReadLine());

//            // Calling the method
//            double interest = CalculateInterest(amount, rate, years);

//            Console.WriteLine("Calculated Interest: " + interest);
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Invalid input: Please enter numeric values.");
//        }
//    }
//}
