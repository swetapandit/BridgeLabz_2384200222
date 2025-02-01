using System;

class MaxOfThreeNumbers
{
    // Function to take an integer input from the user
    static int GetInput()
    {
        Console.WriteLine("Enter the 1st number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the 2nd number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the 3rd number");
        int num3 = Convert.ToInt32(Console.ReadLine());
        int max = FindMax(num1, num2, num3);
        return max;
    }

    // Function to calculate the maximum of three integers
    static int FindMax(int num1, int num2, int num3)
    {
        if (num1 >= num2 && num1 >= num3)
            return num1;
        else if (num2 >= num1 && num2 >= num3)
            return num2;
        else
            return num3;
    }

    // Main function that drives the program
    static void Main(string[] args)
    {
        // Find the maximum number using the FindMax function
        int maxNumber =  GetInput();

        // Display the result
        Console.WriteLine("The maximum number is : " + maxNumber);
    }
}
