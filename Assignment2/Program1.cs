// using System;

// class Program1
// {
//     // Non-static function to check if the number is divisible by 5
//     public bool IsDivisibleBy5(int num)
//     {
//         return num % 5 == 0;  // Returns true if divisible by 5, otherwise false
//     } 	
//     static void Main()
//     {
//         // Create an instance of Program1 to call the non-static method
//         Program1 program = new Program1();

//         // Ask the user to input a number
//         int number = Convert.ToInt32(Console.ReadLine());

//         // Check if the number is divisible by 5 and print the result
//         if (program.IsDivisibleBy5(number))
//         {
//             Console.WriteLine($"Is the number {number} divisible by 5? Yes");
//         }
//         else
//         {
//             Console.WriteLine($"Is the number {number} divisible by 5? No");
//         }
//     }
// }