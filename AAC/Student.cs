/*using System;
using System.Collections.Generic;

// Course class (Many-to-Many Association with Student)
class Course
{
    public string courseName;
    private List<Student> enrolledStudents;

    public Course(string name)
    {
        courseName = name;
        enrolledStudents = new List<Student>();
    }

    public void EnrollStudent(Student student)
    {
        if (!enrolledStudents.Contains(student))
        {
            enrolledStudents.Add(student);
            student.EnrollInCourse(this);
        }
    }

    public void ShowEnrolledStudents()
    {
        Console.WriteLine("Course: " + courseName);
        Console.WriteLine("Enrolled Students:");
        foreach (var student in enrolledStudents)
        {
            Console.WriteLine(" - " + student.studentName);
        }
    }
}

// Student class (Many-to-Many Association with Course)
class Student
{
    public string studentName;
    private List<Course> enrolledCourses;

    public Student(string name)
    {
        studentName = name;
        enrolledCourses = new List<Course>();
    }

    public void EnrollInCourse(Course course)
    {
        if (!enrolledCourses.Contains(course))
        {
            enrolledCourses.Add(course);
            course.EnrollStudent(this);
        }
    }

    public void ShowEnrolledCourses()
    {
        Console.WriteLine("Student: " + studentName);
        Console.WriteLine("Enrolled Courses:");
        foreach (var course in enrolledCourses)
        {
            Console.WriteLine(" - " + course.courseName);
        }
    }
}

// School class (Aggregation with Students)
class School
{
    public string schoolName;
    private List<Student> students;

    public School(string name)
    {
        schoolName = name;
        students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void ShowStudents()
    {
        Console.WriteLine("School: " + schoolName);
        Console.WriteLine("Students:");
        foreach (var student in students)
        {
            Console.WriteLine(" - " + student.studentName);
        }
    }
}

// Main Program
class Program
{
    static void Main()
    {
        // Creating a school
        School mySchool = new School("Greenwood High");

        // Creating students
        Student alice = new Student("Alice");
        Student bob = new Student("Bob");

        // Adding students to the school (Aggregation)
        mySchool.AddStudent(alice);
        mySchool.AddStudent(bob);

        // Creating courses
        Course math = new Course("Mathematics");
        Course science = new Course("Science");

        // Enrolling students in courses (Many-to-Many Association)
        alice.EnrollInCourse(math);
        alice.EnrollInCourse(science);
        bob.EnrollInCourse(math);

        // Displaying enrolled courses for students
        alice.ShowEnrolledCourses();
        bob.ShowEnrolledCourses();

        // Displaying students enrolled in a course
        math.ShowEnrolledStudents();
        science.ShowEnrolledStudents();

        // Displaying school students
        mySchool.ShowStudents();

        Console.ReadLine();
    }
}
*/