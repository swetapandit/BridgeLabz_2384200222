using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] numbers = { 10, 20, 30, 40 };
            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());

            Console.Write("Enter divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            try
            {
                int number = numbers[index];
                int result = number / divisor;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Invalid index.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input.");
        }
    }
}
