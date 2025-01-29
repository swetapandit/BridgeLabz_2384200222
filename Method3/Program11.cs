using System;

class StudentScore
{
    // Method to generate random 2-digit scores for Physics, Chemistry, and Math for each student
    public static int[,] GenerateScores(int numStudents)
    {
        Random rand = new Random();
        int[,] scores = new int[numStudents, 3]; // 3 columns for Physics, Chemistry, and Math

        for (int i = 0; i < numStudents; i++)
        {
            scores[i, 0] = rand.Next(50, 101);  // Physics score (50 to 100)
            scores[i, 1] = rand.Next(50, 101);  // Chemistry score (50 to 100)
            scores[i, 2] = rand.Next(50, 101);  // Math score (50 to 100)
        }
        return scores;
    }

    // Method to calculate total, average, and percentage for each student
    public static double[,] CalculateResults(int[,] scores, int numStudents)
    {
        double[,] results = new double[numStudents, 3]; // 3 columns for total, average, and percentage

        for (int i = 0; i < numStudents; i++)
        {
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = total / 3.0;
            double percentage = (total / 300.0) * 100;

            results[i, 0] = total; // Store total score
            results[i, 1] = Math.Round(average, 2); // Round average to 2 decimal places
            results[i, 2] = Math.Round(percentage, 2); // Round percentage to 2 decimal places
        }
        return results;
    }

    // Method to display the scorecard for all students
    public static void DisplayScorecard(int[,] scores, double[,] results, int numStudents)
    {
        Console.WriteLine("Student\t\tPhysics\t\tChemistry\tMath\t\tTotal\t\tAverage\t\tPercentage");

        for (int i = 0; i < numStudents; i++)
        {
            Console.Write($"{i + 1}\t\t");
            Console.Write($"{scores[i, 0]}\t\t");
            Console.Write($"{scores[i, 1]}\t\t");
            Console.Write($"{scores[i, 2]}\t\t");
            Console.Write($"{results[i, 0]}\t\t");
            Console.Write($"{results[i, 1]}\t\t");
            Console.WriteLine($"{results[i, 2]}%");
        }
    }

    static void Main()
    {
        // Take input for the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Generate random scores for the students
        int[,] scores = GenerateScores(numStudents);

        // Calculate total, average, and percentage for each student
        double[,] results = CalculateResults(scores, numStudents);

        // Display the scorecard
        DisplayScorecard(scores, results, numStudents);
    }
}
