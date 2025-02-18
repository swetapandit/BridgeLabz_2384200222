/*using System;
using System.Collections.Generic;

// Base class for course types
abstract class CourseType
{
    public string TypeName { get; }

    protected CourseType(string typeName)
    {
        TypeName = typeName;
    }
}

// Exam-based course
class ExamCourse : CourseType
{
    public ExamCourse() : base("Exam-Based Course") { }
}

// Assignment-based course
class AssignmentCourse : CourseType
{
    public AssignmentCourse() : base("Assignment-Based Course") { }
}

// Generic Course class
class Course<T> where T : CourseType
{
    public string CourseName { get; }
    public T CourseCategory { get; }

    public Course(string courseName, T courseCategory)
    {
        CourseName = courseName;
        CourseCategory = courseCategory;
    }

    public void DisplayCourse()
    {
        Console.WriteLine($"Course: {CourseName} | Type: {CourseCategory.TypeName}");
    }
}

// Course catalog
class CourseCatalog<T> where T : CourseType
{
    private List<Course<T>> courses = new List<Course<T>>();

    public void AddCourse(Course<T> course)
    {
        courses.Add(course);
    }

    public void DisplayCatalog()
    {
        Console.WriteLine("\nCourse Catalog:");
        foreach (var course in courses)
        {
            course.DisplayCourse();
        }
    }
}

class Program
{
    static void Main()
    {
        // Create course catalogs
        CourseCatalog<ExamCourse> examCatalog = new CourseCatalog<ExamCourse>();
        CourseCatalog<AssignmentCourse> assignmentCatalog = new CourseCatalog<AssignmentCourse>();

        // Create courses
        Course<ExamCourse> math = new Course<ExamCourse>("Mathematics", new ExamCourse());
        Course<ExamCourse> physics = new Course<ExamCourse>("Physics", new ExamCourse());

        Course<AssignmentCourse> history = new Course<AssignmentCourse>("History", new AssignmentCourse());
        Course<AssignmentCourse> literature = new Course<AssignmentCourse>("Literature", new AssignmentCourse());

        // Add courses to catalog
        examCatalog.AddCourse(math);
        examCatalog.AddCourse(physics);
        assignmentCatalog.AddCourse(history);
        assignmentCatalog.AddCourse(literature);

        // Display catalogs
        examCatalog.DisplayCatalog();
        assignmentCatalog.DisplayCatalog();
        Console.ReadLine();
    }
}
*/