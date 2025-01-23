/*using System;

class Program4
{
    // Function to check it is Harshad number.
    static bool AbundantNumber(int num)
    {
	int sum = 0;
	for(int i=1; i<=num/2; i++) if(num%i == 0) sum+=i;
	if(sum > num) return true;
	else return false;
    }

    // Main function to take input and display the result
    static void Main()
    {
        Console.Write("Enter a number: "); // Prompt the user to enter a number
        int num = Convert.ToInt32(Console.ReadLine()); // Read and convert the input to an integer

        if(AbundantNumber(num)) Console.WriteLine($"{num} is Abundant Number");
	  else Console.WriteLine($"{num} is not Abundant Number");
    }
}*/