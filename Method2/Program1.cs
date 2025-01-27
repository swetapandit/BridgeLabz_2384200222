// using System;

// class Program1
// {
//     // Method to find factors of a number
//     public static int[] FindFactors(int number)
//     {
//         // Step 1: Count the factors
//         int count = 0;
//         for (int i = 1; i <= number; i++)
//         {
//             if (number % i == 0)
//             {
//                 count++;
//             }
//         }

//         // Step 2: Save factors into an array
//         int[] factors = new int[count];
//         int index = 0;
//         for (int i = 1; i <= number; i++)
//         {
//             if (number % i == 0)
//             {
//                 factors[index++] = i;
//             }
//         }

//         return factors;
//     }

//     // Method to find the sum of factors
//     public static int SumOfFactors(int[] factors)
//     {
//         int sum = 0;
//         foreach (int factor in factors) sum += factor;
//         return sum;
//     }

//     // Method to find the product of factors
//     public static int ProductOfFactors(int[] factors)
//     {
//         int product = 1;
//         foreach (int factor in factors) product *= factor;
//         return product;
//     }

//     // Method to find the sum of squares of factors
//     public static double SumOfSquaresOfFactors(int[] factors)
//     {
//         double sumOfSquares = 0;
//         foreach (int factor in factors) sumOfSquares += Math.Pow(factor, 2);
//         return sumOfSquares;
//     }

//     // Main method
//     public static void Main(string[] args)
//     {
//         Console.Write("Enter a number: ");
//         int number = Convert.ToInt32(Console.ReadLine());

//         // Find factors
//         int[] factors = FindFactors(number);

//         // Display factors
//         Console.WriteLine("Factors of the number:");
//         foreach (int factor in factors) Console.Write(factor + " ");
//         Console.WriteLine();

//         // Calculate and display results
//         int sum = SumOfFactors(factors);
//         int product = ProductOfFactors(factors);
//         double sumOfSquares = SumOfSquaresOfFactors(factors);

//         Console.WriteLine($"Sum of factors: {sum}");
//         Console.WriteLine($"Product of factors: {product}");
//         Console.WriteLine($"Sum of squares of factors: {sumOfSquares}");
//     }
// }
