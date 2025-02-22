//using System;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            // Accept array input
//            Console.Write("Enter space-separated integers: ");
//            string input = Console.ReadLine();

//            int[] numbers = null;

//            // Initialize array if input is not empty
//            if (!string.IsNullOrWhiteSpace(input))
//            {
//                string[] parts = input.Split(' ');
//                numbers = Array.ConvertAll(parts, int.Parse);
//            }

//            // Accept index input
//            Console.Write("Enter index to access: ");
//            int index = int.Parse(Console.ReadLine());

//            // Access and print value
//            Console.WriteLine($"Value at index {index}: {numbers[index]}");
//        }
//        catch (IndexOutOfRangeException)
//        {
//            Console.WriteLine("Invalid index!");
//        }
//        catch (NullReferenceException)
//        {
//            Console.WriteLine("Array is not initialized!");
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Invalid input. Please enter numeric values.");
//        }
//    }
//}
