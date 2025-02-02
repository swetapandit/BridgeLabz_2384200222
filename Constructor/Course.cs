/*using System;

class Course
{
    // Instance Variables (unique for each course)
    public string CourseName { get; set; }
    public double Duration { get; set; }
    public double Fee { get; set; }

    // Class Variable (shared among all courses)
    public static string InstituteName = "Default Institute";

    // Constructor to initialize course details
    public Course(string courseName, double duration, double fee)
    {
        this.CourseName = courseName;
        this.Duration = duration;
        this.Fee = fee;
    }

    // Instance Method to display course details
    public void DisplayCourseDetails()
    {
        Console.WriteLine($"Course Name: {this.CourseName}, Duration: {this.Duration} weeks, Fee: ₹{this.Fee:C}, Institute: {InstituteName}");
    }

    // Class Method to update the institute name for all courses
    public static void UpdateInstituteName(string newInstituteName)
    {
        InstituteName = newInstituteName;
    }
}

class Program
{
    static void Main()
    {
        // Creating Course Objects
        Course course1 = new Course("Java Programming", 12, 15000);
        Course course2 = new Course("Web Development", 10, 12000);
        Course course3 = new Course("Data Science", 14, 18000);

        // Displaying Individual Course Details
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
        course3.DisplayCourseDetails();

        Console.WriteLine();

        // Updating the Institute Name
        Course.UpdateInstituteName("Tech Academy");

        // Displaying Updated Course Details
        Console.WriteLine("After Updating Institute Name:");
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
        course3.DisplayCourseDetails();
        Console.ReadLine();
    }
}
*/