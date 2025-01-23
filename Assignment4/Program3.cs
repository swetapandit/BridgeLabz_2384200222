/*using System;

class Program
{
    // Function to check it is Harshad number.
    static bool HarshadNumber(int num)
    {
	int temp = num;
	int sum = 0;
	while(num>0){
		int rem = num % 10;
		sum += rem;
		num /= 10;
	}
	if(temp % sum == 0) return true;
	else return false;
    }

    // Main function to take input and display the result
    static void Main()
    {
        Console.Write("Enter a number: "); // Prompt the user to enter a number
        int num = Convert.ToInt32(Console.ReadLine()); // Read and convert the input to an integer

        if(HarshadNumber(num)) Console.WriteLine($"{num} is Harshad Number");
	  else Console.WriteLine($"{num} is not Harshad Number");
    }
}*/