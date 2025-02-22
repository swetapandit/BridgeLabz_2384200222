using System;

class Program
{
    // Method1 throws an ArithmeticException if denominator is 0
    static void Method1()
    {
        int numerator = 10;
        int denominator = 0; // This can be changed to simulate different behavior

        int result = numerator / denominator; // Division by zero
    }

    // Method2 calls Method1, propagating the exception
    static void Method2()
    {
        Method1();
    }

    static void Main()
    {
        try
        {
            // Calling Method2, which will eventually call Method1
            Method2();
        }
        catch (ArithmeticException)
        {
            // Handling the exception in Main
            Console.WriteLine("Handled exception in Main");
        }
    }
}
