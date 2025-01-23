/*using System;

class Program
{
    // Function to check if a number is an Armstrong number
    static bool CheckArmstrong(int num)
    {
        int temp = num; // Store the original number for comparison later
        int cnt = 0; // Variable to count the number of digits in the number
        int res = 0; // Variable to store the sum of digits raised to the power of cnt

        // Calculate the number of digits in the number
        while (temp > 0)
        {
            temp /= 10; // Divide temp by 10 to remove the last digit
            cnt++; // Increment digit count
        }

        temp = num; // Reset temp to the original number for the next loop

        // Calculate the sum of each digit raised to the power of cnt
        while (num > 0)
        {
            int rem = num % 10; // Extract the last digit of the number
            res += (int)Math.Pow(rem, cnt); // Add the power of the digit to the result
            num /= 10; // Remove the last digit from the number
        }

        // Check if the calculated result matches the original number
        if (temp == res) 
            return true; // If yes, it's an Armstrong number
        else 
            return false; // Otherwise, it's not an Armstrong number
    }

    // Main function to take input and display the result
    static void Main()
    {
        Console.Write("Enter a number: "); // Prompt the user to enter a number
        int num = Convert.ToInt32(Console.ReadLine()); // Read and convert the input to an integer

        // Check if the number is an Armstrong number and print the result
        if (CheckArmstrong(num)) 
            Console.WriteLine("Armstrong Number");
        else 
            Console.WriteLine("Not Armstrong Number");
    }
}
*/