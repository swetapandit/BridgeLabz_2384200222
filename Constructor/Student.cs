using System;

class Student
{
    public int rollNumber;
    protected string name;
    private double cgpa;

    // Constructor to initialize student details
    public Student(int rollNumber, string name, double cgpa)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.cgpa = cgpa;
    }

    // Public method to access CGPA
    public double GetCGPA()
    {
        return cgpa;
    }

    // Public method to modify CGPA
    public void SetCGPA(double cgpa)
    {
        if (cgpa >= 0.0 && cgpa <= 10.0) // Assuming CGPA is on a scale of 0 to 10
        {
            cgpa = cgpa;
        }
        else
        {
            Console.WriteLine("Invalid CGPA. Please enter a value between 0 and 10.");
        }
    }

    // Method to display student details
    public void DisplayStudentDetails()
    {
        Console.WriteLine($"Roll Number: {rollNumber}, Name: {name}, CGPA: {cgpa}");
    }
}

// Subclass demonstrating the use of protected members
class PostgraduateStudent : Student
{
    public PostgraduateStudent(int rollNumber, string name, double cgpa)
        : base(rollNumber, name, cgpa) // Call to the base class constructor
    {
    }

    // Method to display postgraduate student details
    public void DisplayPostgraduateDetails()
    {
        Console.WriteLine($"Postgraduate Student - Roll Number: {rollNumber}, Name: {name}");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Student object
        Student student1 = new Student(101, "Alice", 8.5);
        student1.DisplayStudentDetails();

        // Modifying CGPA
        student1.SetCGPA(9.0);
        Console.WriteLine($"Updated CGPA: {student1.GetCGPA()}");

        Console.WriteLine();

        // Creating a PostgraduateStudent object
        PostgraduateStudent pgStudent = new PostgraduateStudent(102, "Bob", 8.8);
        pgStudent.DisplayPostgraduateDetails();
        pgStudent.DisplayStudentDetails();
    }
}
