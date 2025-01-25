/*using System;

class Program3
{
    static void Main(string[] args)
    {
        // Take user input
        Console.Write("Enter a number: ");
        long number = Convert.ToInt64(Console.ReadLine());

        // Define the array to store digits
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        // Extract digits and store them in the array
        while (number != 0)
        {
            digits[index] =(int) number % 10; // Get the last digit
            number /= 10; // Remove the last digit
            index++;

            // Break if the array size limit is reached
            if (index == maxDigit)
            {
		maxDigit += 10;
	 	int[] temp = new int[maxDigit];
		Array.Copy(digits, temp, digits.Length);
		digits = temp;
            }
        }

        // Find the largest and second largest digits
        (int largest, int secondLargest) = FindLargestAndSecondLargest(digits, index);

        // Display results
        Console.WriteLine($"The largest digit is: {largest}");
        Console.WriteLine($"The second largest digit is: {secondLargest}");
    }

    // Function to find the largest and second-largest digits
    static (int, int) FindLargestAndSecondLargest(int[] digits, int size)
    {
        int largest = 0;
        int secondLargest = 0;

        for (int i = 0; i < size; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] < largest)
            {
                secondLargest = digits[i];
            }
        }

        return (largest, secondLargest);
    }
}
*/