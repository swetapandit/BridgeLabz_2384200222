/*using System;

public static class NumberChecker
{
    // Method to count the digits in the number
    public static int CountDigits(int number)
    {
        int count = 0;
        number = Math.Abs(number);
        while (number > 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    // Method to store the digits of the number in a digits array
    public static int[] GetDigitsArray(int number)
    {
        number = Math.Abs(number);
        string numberStr = number.ToString();
        int[] digits = new int[numberStr.Length];
        for (int i = 0; i < numberStr.Length; i++)
        {
            digits[i] = numberStr[i] - '0';
        }
        return digits;
    }

    // Method to check if a number is a prime number
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // Method to check if a number is a neon number
    public static bool IsNeonNumber(int number)
    {
        int square = number * number;
        int sum = 0;
        while (square > 0)
        {
            sum += square % 10;
            square /= 10;
        }
        return sum == number;
    }

    // Method to check if a number is a spy number
    public static bool IsSpyNumber(int number)
    {
        int sum = 0, product = 1;
        int[] digits = GetDigitsArray(number);
        foreach (int digit in digits)
        {
            sum += digit;
            product *= digit;
        }
        return sum == product;
    }

    // Method to check if a number is an automorphic number
    public static bool IsAutomorphicNumber(int number)
    {
        int square = number * number;
        return square.ToString().EndsWith(number.ToString());
    }

    // Method to check if a number is a buzz number
    public static bool IsBuzzNumber(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }

    // Main method to call and display results
    public static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Is {number} a prime number? {IsPrime(number)}");
        Console.WriteLine($"Is {number} a neon number? {IsNeonNumber(number)}");
        Console.WriteLine($"Is {number} a spy number? {IsSpyNumber(number)}");
        Console.WriteLine($"Is {number} an automorphic number? {IsAutomorphicNumber(number)}");
        Console.WriteLine($"Is {number} a buzz number? {IsBuzzNumber(number)}");
    }
}
*/