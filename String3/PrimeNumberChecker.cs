using System;

class PrimeNumberChecker
{
    // Function to check if a number is prime
    static bool IsPrime(int number)
    {
        // Check divisibility from 2 to the square root of the number
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) // If divisible by i, it's not prime
                return false;
        }

        return true; // The number is prime if no divisors were found
    }

    // Main function that drives the program
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it's prime:");
		int number = Convert.ToInt32(Console.ReadLine());
        
        if (number > 1)
        {
            // Call the IsPrime function to check if the number is prime
            bool result = IsPrime(number);

            // Output the result
            if (result)
                Console.WriteLine(number+" is a prime number.");
            else
                Console.WriteLine(number+" is not a prime number.");
        }
        else Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
}
