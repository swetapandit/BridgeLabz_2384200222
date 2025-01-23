// using System;

// class Program1
// {
//     // Non-static function to check if the number is a natural number
//     public bool IsNaturalNumber(int num)
//     {
//         return num > 0; 
//     }

//     // Non-static function to calculate the sum of first n natural numbers
//     public int SumOfNaturalNumbers(int num)
//     {
//         return num * (num + 1) / 2;  // Formula for the sum of first n natural numbers
//     }

//     static void Main()
//     {
//         // Take input number
//         int number = Convert.ToInt32(Console.ReadLine());

//         // Create an instance of Program1 to call the non-static methods
//         Program1 program = new Program1();

//         // Check if the number is a natural number and print the result
//         if (program.IsNaturalNumber(number))
//         {
//             int sum = program.SumOfNaturalNumbers(number);
//             Console.WriteLine($"The sum of {number} natural numbers is {sum}");
//         }
//         else
//         {
//             Console.WriteLine($"The number {number} is not a natural number");
//         }
//     }
// }