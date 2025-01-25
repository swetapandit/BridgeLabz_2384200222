using System;

class Program
{
    static void Main(string[] args)
    {
        // Take input for the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());

        // Define a 2D array to store marks (rows: students, columns: subjects)
        int[,] marks = new int[numStudents, 3]; // 3 columns for Physics, Chemistry, Maths
        double[] percentages = new double[numStudents];
        char[] grades = new char[numStudents];

        // Input marks for each student
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"\nEnter marks for Student {i + 1}:");
            marks[i, 0] = GetPositiveMarks("Physics");
            marks[i, 1] = GetPositiveMarks("Chemistry");
            marks[i, 2] = GetPositiveMarks("Maths");

            // Calculate percentage
            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = (double)totalMarks / 3;

            // Assign grade based on percentage
            grades[i] = GetGrade(percentages[i]);
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tPercentage\tGrade");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"{i + 1}\t{marks[i, 0]}\t{marks[i, 1]}\t\t{marks[i, 2]}\t{percentages[i]:F2}%\t\t{grades[i]}");
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
