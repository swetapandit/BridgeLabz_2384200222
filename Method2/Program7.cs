/*using System;

public class Program7
{
    // Method to check if a student can vote based on their age
    public bool CanStudentVote(int age)
    {
        if (age < 0)  return false; // Cannot vote if age is negative

        // Check if the age is 18 or greater
        return age >= 18;
    }

    // Main method to get user input and check voting eligibility
    public static void Main(string[] args)
    {
        Program7 checker = new Program7();
        int[] ages = new int[10]; // Array to hold the ages of 10 students

        // Loop through the array and take user input for each student's age
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter age of student {i + 1}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            // Check if the student can vote
            bool canVote = checker.CanStudentVote(ages[i]);
            if (canVote) Console.WriteLine($"Student {i + 1} can vote.");
            else Console.WriteLine($"Student {i + 1} cannot vote.");
        }
    }
}
*/