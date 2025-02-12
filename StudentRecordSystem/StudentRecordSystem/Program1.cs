/*using System;

public class Student
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
    public Student Student { get; set; }
    public Node Next { get; set; }

    public Node(Student student)
    {
        Student = student;
        Next = null;
    }

}

class StudentList<T>
{
    private Node head;
    private Node tail;
    public LinkedList()
    {
        head = null;
    }
    
    // Node Added to Beginning
    public void AddBeginning(Student student)
    {
        Node newNode = new Node(student);
        if (head == null) head = tail = newNode;
        else
        {
            newNode.Next = head;
            head = newNode;
        }
    }

    // Node added to End
    public void AddEnd(Student student) {
        Node newNode = new Node(student);
        if (head == null) head = tail = newNode;
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
    }

    // Node added at specific position
    public void AddAtPosition(Student student, int pos)
    {
        Node newNode = new Node(student);
        if (head == null) head = tail = newNode;
        if (pos <= 1)
        {
            AddBeginning(student);
            return;
        }

        Node temp = head;
        int cnt = 1;
        while(cnt < pos-1 && temp.Next != null)
        {
            temp = temp.Next;
            cnt++;
        }
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    //Delete Student by its Roll number.
    public void DeleteStudent(int rollNumber)
    {
        if(head == null)
        {
            Console.WriteLine("We Don't have any student!!!");
            return;
        }
        //if (head.Student.RollNumber == rollNumber)
        //{
        //    head = head.Next;
        //    return;
        //}

        Node temp = head;
        Node prev = null;
        if(temp.Student.RollNumber == rollNumber) // edge case for first node.
        {
            Console.WriteLine("Student Found");
            return;
        }
        while(temp.Student.RollNumber != rollNumber && temp != null)
        {
            prev = temp;
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Student not Fount with roll Number: " + rollNumber);
            return;
        }
        prev.Next = temp.Next;

    }

    //Search student by RollNumber
    public void SearchStudent(int rollNumber)
    {
        if (head == null)
        {
            Console.WriteLine("We Don't have any student!!!");
            return;
        }
        if (head.Student.RollNumber == rollNumber)
        {
            Console.WriteLine("Student Found");
            Console.Write(head.Student.RollNumber);
            Console.Write(" " + head.Student.Name);
            Console.Write(" " + head.Student.Age);
            Console.Write(" " + head.Student.Grade);
            Console.WriteLine("\n------------------------");
            return;
        }

        Node temp = head;
        while (temp.Student.RollNumber != rollNumber && temp != null)
        {
            temp = temp.Next;
            if (temp.Next == null)
            {
                Console.WriteLine("Student not Fount with roll Number: " + rollNumber);
                return;
            }
        }

        if (temp.Student.RollNumber == rollNumber)
        {
            Console.WriteLine("Student Found");
            Console.Write(temp.Student.RollNumber);
            Console.Write(" " + temp.Student.Name);
            Console.Write(" " + temp.Student.Age);
            Console.Write(" " + temp.Student.Grade);
            Console.WriteLine("\n------------------------");
            return;
        }

    }

    //Update Student grade by its RollNumber
    public void UpdateStudent(int rollNumber,char grade)
    {
        if (head == null)
        {
            Console.WriteLine("We Don't have any student!!!");
            return;
        }
        if (head.Student.RollNumber == rollNumber)
        {
            head.Student.Grade = grade;
            return;
        }

        Node temp = head;
        if (temp.Student.RollNumber == rollNumber) // edge case for first node.
        {
            Console.WriteLine("Student Found");
            temp.Student.Grade = grade;
            return;
        }
        while (temp.Student.RollNumber != rollNumber && temp != null)
        {
            temp = temp.Next;
            if (temp.Next == null)
            {
                Console.WriteLine("Student not Fount with roll Number: " + rollNumber);
                return;
            }
        }
    }

    //Display Method
    public void Display()
    {
        Node temp = head;
        if(head == null)
        {
            Console.WriteLine("No student exists!");
            return;
        }
        
        while (temp != null)
        {
            Console.Write(" " + temp.Student.RollNumber);
            Console.Write(" " + temp.Student.Name);
            Console.Write(" " + temp.Student.Age);
            Console.Write(" " + temp.Student.Grade);
            Console.WriteLine("\n------------------------");
            temp = temp.Next;
        }
    }
}



public class Program
{
    public static void Main()
    {
        StudentList<Student> studentList = new StudentList<Student>();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Student at Beginning");
            Console.WriteLine("2. Add Student at End");
            Console.WriteLine("3. Delete Student by Roll Number");
            Console.WriteLine("4. Display Students");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                case 2:
                    Console.Write("Enter Roll Number: ");
                    int roll = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Enter Grade: ");
                    char grade = char.Parse(Console.ReadLine());
                    Student newStudent = new Student(roll, name, age, grade);
                    if (choice == 1)
                        studentList.AddBeginning(newStudent);
                    else
                        studentList.AddEnd(newStudent);
                    break;

                case 3:
                    Console.Write("Enter Roll Number to delete: ");
                    int rollToDelete = int.Parse(Console.ReadLine());
                    studentList.DeleteStudent(rollToDelete);
                    break;

                case 4:
                    studentList.Display();
                    break;

                case 5:
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;

            }
        }
    }
}*/

