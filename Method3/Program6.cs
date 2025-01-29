/*using System;

class NumberChecker
{
    // Method to find factors of a number and return them as an array
    public static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }
        return factors;
    }

    // Method to find the greatest factor of a number
    public static int FindGreatestFactor(int number)
    {
        int[] factors = FindFactors(number);
        return factors[factors.Length - 1];
    }

    // Method to find the sum of the factors
    public static int SumOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of the factors
    public static int ProductOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        int product = 1;
        foreach (var factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the product of the cube of the factors
    public static double ProductOfCubeOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        double product = 1;
        foreach (var factor in factors)
        {
            product *= Math.Pow(factor, 3);
        }
        return product;
    }

    // Method to check if a number is a perfect number
    public static bool IsPerfectNumber(int number)
    {
        int sum = SumOfFactors(number) - number;
        return sum == number;
    }

    // Method to check if a number is an abundant number
    public static bool IsAbundantNumber(int number)
    {
        int sum = SumOfFactors(number) - number;
        return sum > number;
    }

    // Method to check if a number is a deficient number
    public static bool IsDeficientNumber(int number)
    {
        int sum = SumOfFactors(number) - number;
        return sum < number;
    }

    // Method to check if a number is a strong number
    public static bool IsStrongNumber(int number)
    {
        int sum = 0;
        int temp = number;
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }
        return sum == number;
    }

    // Helper method to calculate factorial of a number
    private static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}

class Program
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());

        // Calling the static methods and displaying results
        int[] factors = NumberChecker.FindFactors(number);
        Console.WriteLine("Factors: " + string.Join(", ", factors));

        Console.WriteLine("Greatest Factor: " + NumberChecker.FindGreatestFactor(number));
        Console.WriteLine("Sum of Factors: " + NumberChecker.SumOfFactors(number));
        Console.WriteLine("Product of Factors: " + NumberChecker.ProductOfFactors(number));
        Console.WriteLine("Product of Cube of Factors: " + NumberChecker.ProductOfCubeOfFactors(number));
        Console.WriteLine("Is Perfect Number: " + NumberChecker.IsPerfectNumber(number));
        Console.WriteLine("Is Abundant Number: " + NumberChecker.IsAbundantNumber(number));
        Console.WriteLine("Is Deficient Number: " + NumberChecker.IsDeficientNumber(number));
        Console.WriteLine("Is Strong Number: " + NumberChecker.IsStrongNumber(number));
    }
}
*/