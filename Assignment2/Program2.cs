// using System;

// class Program1
// {
//     // Non-static function to check if the first number is the smallest
//     public bool IsFirstSmallest(int num1, int num2, int num3)
//     {
//         // Check if the first number is smaller than both the second and third
//         return num1 < num2 && num1 < num3;
//     }

//     static void Main()
//     {
//         // Take three numbers as input
//         int number1 = Convert.ToInt32(Console.ReadLine());
//         int number2 = Convert.ToInt32(Console.ReadLine());
//         int number3 = Convert.ToInt32(Console.ReadLine());

//         // Create an instance of Program1 to call the non-static method
//         Program1 program = new Program1();

//         // Check if the first number is the smallest and print the result
//         if (program.IsFirstSmallest(number1, number2, number3))
//         {
//             Console.WriteLine("Is the first number the smallest? Yes");
//         }
//         else
//         {
//             Console.WriteLine("Is the first number the smallest? No");
//         }
//     }
// }
