//using System;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            // Taking user input
//            Console.Write("Enter first number: ");
//            int num1 = int.Parse(Console.ReadLine());

//            Console.Write("Enter second number: ");
//            int num2 = int.Parse(Console.ReadLine());

//            // Performing division
//            int result = num1 / num2;

//            Console.WriteLine($"Result: {result}");
//        }
//        catch (DivideByZeroException)
//        {
//            Console.WriteLine("Error: Cannot divide by zero.");
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Error: Please enter valid integers.");
//        }
//        finally
//        {
//            Console.WriteLine("Operation completed");
//        }
//    }
//}
