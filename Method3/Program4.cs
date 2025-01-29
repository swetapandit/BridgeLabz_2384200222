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

    // Method to reverse the digits array
    public static int[] ReverseDigitsArray(int[] digitsArray)
    {
        int[] reversedArray = new int[digitsArray.Length];
        for (int i = 0, j = digitsArray.Length - 1; i < digitsArray.Length; i++, j--)
        {
            reversedArray[i] = digitsArray[j];
        }
        return reversedArray;
    }

    // Method to compare two arrays and check if they are equal
    public static bool AreArraysEqual(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
            return false;

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
                return false;
        }
        return true;
    }

    // Method to check if a number is a palindrome using the digits
    public static bool IsPalindrome(int number)
    {
        int[] digitsArray = GetDigitsArray(number);
        int[] reversedArray = ReverseDigitsArray(digitsArray);
        return AreArraysEqual(digitsArray, reversedArray);
    }

    // Method to check if a number is a duck number
    public static bool IsDuckNumber(int number)
    {
        if (number <= 0) return false; // Duck numbers are positive

        int[] digitsArray = GetDigitsArray(number);
        foreach (int digit in digitsArray)
        {
            if (digit == 0)
                return true;
        }
        return false;
    }

    // Main method to call and display results
    public static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Count of digits in {number}: {CountDigits(number)}");

        int[] digitsArray = GetDigitsArray(number);
        Console.WriteLine($"Digits array: [{string.Join(", ", digitsArray)}]");

        int[] reversedArray = ReverseDigitsArray(digitsArray);
        Console.WriteLine($"Reversed digits array: [{string.Join(", ", reversedArray)}]");

        Console.WriteLine($"Are the original and reversed arrays equal? {AreArraysEqual(digitsArray, reversedArray)}");

        Console.WriteLine($"Is {number} a palindrome? {IsPalindrome(number)}");

        Console.WriteLine($"Is {number} a duck number? {IsDuckNumber(number)}");
    }
}
*/