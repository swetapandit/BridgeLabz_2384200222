using System;

public class Program
{
    // Method to calculate the maximum number of handshakes
    public static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }

    // Main method
    public static void Main(string[] args)
    {
        // Take user input for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculate the maximum number of handshakes
        int maxHandshakes = CalculateHandshakes(numberOfStudents);

        // Display the result
        Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {maxHandshakes}.");
    }
}
