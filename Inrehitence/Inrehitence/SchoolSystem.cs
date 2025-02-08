/*using System;
using System.Xml.Linq;

class Person
{
    string name;
    int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
    }

    public virtual void DisplayRole()
    {
        Console.WriteLine("I'm a Person");
    }
}

class Teacher : Person
{
    string subject;

    public Teacher(string name, int age, string subject) : base(name, age)
    {
        this.subject = subject;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Subject: {subject}");
    }
    public override void DisplayRole()
    {
        Console.WriteLine("I'm a Person, Whoose Role is Teacher");
    }
}

class Student : Person
{
    string grade;

    public Student(string name, int age, string grade) : base(name, age)
    {
        this.grade = grade;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Your Grade is : {grade}");
    }
    public override void DisplayRole()
    {
        Console.WriteLine("I'm a Person, Whoose Role is Student");
    }
}

class Staff : Person
{
    string task;

    public Staff(string name, int age, string task) : base(name, age)
    {
        this.task = task;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Your Task is : {task}");
    }
    public override void DisplayRole()
    {
        Console.WriteLine("I'm a Person, Whoose Role is Staff");
    }
}

class Program
{
    public static void Main()
    {
        Person person = new Person("Aarush", 25);
        person.DisplayDetails();
        person.DisplayRole();
        Console.WriteLine("-----------------------");

        Student student = new Student("Aarush", 25, "A");
        student.DisplayDetails();
        student.DisplayRole();
        Console.WriteLine("-----------------------");

        Teacher teacher = new Teacher("Aarush", 25, "Maths");
        teacher.DisplayDetails();
        teacher.DisplayRole();
        Console.WriteLine("-----------------------");

        Staff staff = new Staff("Aarush", 25, "Bring File");
        staff.DisplayDetails();
        staff.DisplayRole();
        Console.WriteLine("-----------------------");

        Console.ReadLine();
    }
}*/