/*using System;

class Program
{
    static void Main(string[] args)
    {
        // Take input for the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());

        // Arrays to store student data
        int[] physicsMarks = new int[numStudents];
        int[] chemistryMarks = new int[numStudents];
        int[] mathsMarks = new int[numStudents];
        double[] percentages = new double[numStudents];
        char[] grades = new char[numStudents];

        // Input marks for each student
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"\nEnter marks for Student {i + 1}:");

            physicsMarks[i] = GetPositiveMarks("Physics");
            chemistryMarks[i] = GetPositiveMarks("Chemistry");
            mathsMarks[i] = GetPositiveMarks("Maths");

            // Calculate percentage
            int totalMarks = physicsMarks[i] + chemistryMarks[i] + mathsMarks[i];
            percentages[i] = (double)totalMarks / 3;

            // Assign grade based on percentage
            grades[i] = GetGrade(percentages[i]);
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tPercentage\tGrade");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"{i + 1}\t{physicsMarks[i]}\t{chemistryMarks[i]}\t\t{mathsMarks[i]}\t{percentages[i]:F2}%\t\t{grades[i]}");
        }
    }

    // Function to get positive marks
    static int GetPositiveMarks(string subject)
    {
        int marks;
        while (true)
        {
            Console.Write($"Enter marks for {subject}: ");
            marks = Convert.ToInt32(Console.ReadLine());
            if (marks >= 0)
            {
                break;
            }
            Console.WriteLine("Marks cannot be negative. Please enter a positive value.");
        }
        return marks;
    }

    // Function to get grade based on percentage
    static char GetGrade(double percentage)
    {
        if (percentage >= 80)
            return 'A';
        else if (percentage >= 70)
            return 'B';
        else if (percentage >= 60)
            return 'C';
        else if (percentage >= 50)
            return 'D';
        else if (percentage >= 40)
            return 'E';
        else
            return 'R';
    }
}
*/