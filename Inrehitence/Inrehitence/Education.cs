/*using System;

class Course
{
    private string courseName;
    private string duration;

    public Course(string courseName, string duration)
    {
        this.courseName = courseName;
        this.duration = duration;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Course Name: {courseName}");
        Console.WriteLine($"Course Duration: {duration}");
    }
}

class OnlineCourse : Course
{
    string platform;
    bool isRecorded;

    public OnlineCourse(string courseName, string duration, string platform, bool isRecorded) : base(courseName, duration)
    {
        this.platform = platform;
        this.isRecorded = isRecorded;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Platform: {platform}");
        Console.WriteLine($"Is Recorded: {isRecorded}");
    }
}

class PaidOnlineCourse : OnlineCourse
{
    int fee;
    int discount;

    public PaidOnlineCourse(string courseName, string duration, string platform, bool isRecorded, int fee, int discount) : base(courseName,duration,platform,isRecorded)
    {
        this.fee = fee;
        this.discount = discount;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Course Fee: {fee}");
        Console.WriteLine($"Discount: {discount}");
    }
}

class Program
{
    public static void Main()
    {
        Course course = new Course("MCA", "2 Years");
        course.DisplayDetails();
        Console.WriteLine("-------------------------------");
        OnlineCourse onlineCourse = new OnlineCourse("BCA", "3 Years", "Online", true);
        onlineCourse.DisplayDetails();
        Console.WriteLine("-------------------------------");
        PaidOnlineCourse paidOnlineCourse = new PaidOnlineCourse("Btech", "4 Yaers", "OnCampus", true, 2300, 1000);
        paidOnlineCourse.DisplayDetails();
        Console.ReadLine();
    }
}*/