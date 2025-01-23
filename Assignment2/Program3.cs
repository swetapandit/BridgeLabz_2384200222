// using System;

// class Program1
// {
//     // Non-static function to check if the first number is the largest
//     public bool IsFirstLargest(int num1, int num2, int num3)
//     {
//         return num1 > num2 && num1 > num3;
//     }

//     // Non-static function to check if the second number is the largest
//     public bool IsSecondLargest(int num1, int num2, int num3)
//     {
//         return num2 > num1 && num2 > num3;
//     }

//     // Non-static function to check if the third number is the largest
//     public bool IsThirdLargest(int num1, int num2, int num3)
//     {
//         return num3 > num1 && num3 > num2;
//     }

//     static void Main()
//     {
//         // Take three numbers as input
//         int number1 = Convert.ToInt32(Console.ReadLine());
//         int number2 = Convert.ToInt32(Console.ReadLine());
//         int number3 = Convert.ToInt32(Console.ReadLine());

//         // Create an instance of Program1 to call the non-static methods
//         Program1 program = new Program1();

//         // Check if the first number is the largest and print the result
//         Console.WriteLine($"Is the first number the largest? {program.IsFirstLargest(number1, number2, number3)}");

//         // Check if the second number is the largest and print the result
//         Console.WriteLine($"Is the second number the largest? {program.IsSecondLargest(number1, number2, number3)}");

//         // Check if the third number is the largest and print the result
//         Console.WriteLine($"Is the third number the largest? {program.IsThirdLargest(number1, number2, number3)}");
//     }
// }
