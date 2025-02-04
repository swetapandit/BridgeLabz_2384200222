/*using System;

class Student
{
    private static string UniversityName = "XYZ University"; // Shared across all students
    private static int totalStudents = 0; // Keeps track of total students

    public readonly int RollNumber; // Unique roll number, cannot be changed
    private string Name;
    private char Grade;

    // Constructor using 'this' keyword
    public Student(int roll, string name, char grade)
    {
        this.RollNumber = roll;
        this.Name = name;
        this.Grade = grade;
        totalStudents++; // Increment student count
    }

    // Static method to display total students
    public static void DisplayTotalStudents()
    {
        Console.WriteLine($"\nTotal students enrolled: {totalStudents}\n");
    }

    // Method to display student details
    public void DisplayStudentInfo()
    {
        Console.WriteLine($"University: {UniversityName}");
        Console.WriteLine($"Roll Number: {RollNumber}, Name: {Name}, Grade: {Grade}\n");
    }

    // Method to update student grade
    public void UpdateGrade(char newGrade)
    {
        if (this is Student) // Checking if 'this' is an instance of Student class
        {
            this.Grade = newGrade;
            Console.WriteLine($"Grade updated for {Name} (Roll No: {RollNumber}) to {Grade}\n");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        Student[] students = new Student[numStudents];

        // Taking user input to create student records
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"\nEnter details for Student {i + 1}:");
            Console.Write("Roll Number: ");
            int roll = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Grade (A/B/C/D/F): ");
            char grade = char.Parse(Console.ReadLine());

            students[i] = new Student(roll, name, grade);
        }

        // Displaying all student details
        Console.WriteLine("\nStudent Records:");
        foreach (var student in students)
        {
            if (student is Student) // Checking instance before displaying
            {
                student.DisplayStudentInfo();
            }
        }

        // Allowing grade update for a student
        Console.Write("\nEnter Roll Number to update grade: ");
        int rollToUpdate = int.Parse(Console.ReadLine());
        Console.Write("Enter new Grade: ");
        char newGrade = char.Parse(Console.ReadLine());

        foreach (var student in students)
        {
            if (student.RollNumber == rollToUpdate)
            {
                student.UpdateGrade(newGrade);
                break;
            }
        }

        // Display total students enrolled
        Student.DisplayTotalStudents();
    }
}
*/