/*using System;

class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public char Grade { get; set; }

    public Student(int rollNumber, string name, int age, char grade)
    {
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
    }
}

class Node
{
    public Student Data { get; set; }
    public Node Next { get; set; }

    public Node(Student student)
    {
        Data = student;
        Next = null;
    }
}

class StudentList
{
    private Node head;

    public StudentList()
    {
        head = null;
    }

    // Add student at the beginning
    public void AddAtBeginning(Student student)
    {
        Node newNode = new Node(student);
        newNode.Next = head;
        head = newNode;
        Console.WriteLine("Student added at the beginning.");
    }

    // Add student at the end
    public void AddAtEnd(Student student)
    {
        Node newNode = new Node(student);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }
        Console.WriteLine("Student added at the end.");
    }

    // Add student at a specific position
    public void AddAtPosition(Student student, int position)
    {
        if (position < 1)
        {
            Console.WriteLine("Invalid position!");
            return;
        }

        Node newNode = new Node(student);
        if (position == 1)
        {
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            Node temp = head;
            for (int i = 1; temp != null && i < position - 1; i++)
            {
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine("Position out of range!");
                return;
            }
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }
        Console.WriteLine($"Student added at position {position}.");
    }

    // Delete student by Roll Number
    public void DeleteByRollNumber(int rollNumber)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty!");
            return;
        }

        if (head.Data.RollNumber == rollNumber)
        {
            head = head.Next;
            Console.WriteLine($"Student with Roll Number {rollNumber} deleted.");
            return;
        }

        Node temp = head;
        Node prev = null;
        while (temp != null && temp.Data.RollNumber != rollNumber)
        {
            prev = temp;
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Student not found!");
            return;
        }

        prev.Next = temp.Next;
        Console.WriteLine($"Student with Roll Number {rollNumber} deleted.");
    }

    // Search student by Roll Number
    public void SearchByRollNumber(int rollNumber)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.Data.RollNumber == rollNumber)
            {
                Console.WriteLine($"Student Found - Roll Number: {temp.Data.RollNumber}, Name: {temp.Data.Name}, Age: {temp.Data.Age}, Grade: {temp.Data.Grade}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found!");
    }

    // Display all students
    public void DisplayAll()
    {
        if (head == null)
        {
            Console.WriteLine("No student records found.");
            return;
        }

        Node temp = head;
        Console.WriteLine("Student Records:");
        while (temp != null)
        {
            Console.WriteLine($"Roll Number: {temp.Data.RollNumber}, Name: {temp.Data.Name}, Age: {temp.Data.Age}, Grade: {temp.Data.Grade}");
            temp = temp.Next;
        }
    }

    // Update student grade by Roll Number
    public void UpdateGrade(int rollNumber, char newGrade)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.Data.RollNumber == rollNumber)
            {
                temp.Data.Grade = newGrade;
                Console.WriteLine($"Grade updated for Roll Number {rollNumber}.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found!");
    }
}

class Program
{
    static void Main()
    {
        StudentList studentList = new StudentList();

        // Adding students
        studentList.AddAtBeginning(new Student(1, "Aarav", 20, 'A'));
        studentList.AddAtEnd(new Student(2, "Bhavya", 21, 'B'));
        studentList.AddAtPosition(new Student(3, "Chetan", 19, 'C'), 2);

        // Display all students
        studentList.DisplayAll();

        // Search for a student
        studentList.SearchByRollNumber(2);

        // Update grade
        studentList.UpdateGrade(2, 'A');

        // Delete student
        studentList.DeleteByRollNumber(1);

        // Display all students again
        studentList.DisplayAll();
    }
}
*/