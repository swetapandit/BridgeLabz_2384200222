/*using System;

// Base class representing a general employee
class Employee
{
    private string name;
    private int id;
    private double salary;

    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    // Virtual method to be overridden by subclasses
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Employee Name: {name}");
        Console.WriteLine($"Employee Id: {id}");
        Console.WriteLine($"Employee Salary: {salary}");
    }
}

// Derived class for Manager
class Manager : Employee
{
    private int teamSize;

    public Manager(int teamSize, string name, int id, double salary) : base(name, id, salary)
    {
        this.teamSize = teamSize;
    }

    // Overriding DisplayDetails to include TeamSize
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Team Size: {teamSize}");
    }
}

// Derived class for Developer
class Developer : Employee
{
    private string programmingLanguage;

    public Developer(string programmingLanguage, string name, int id, double salary) : base(name, id, salary)
    {
        this.programmingLanguage = programmingLanguage;
    }

    // Overriding DisplayDetails to include ProgrammingLanguage
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Programming Language: {programmingLanguage}");
    }
}

// Derived class for Intern
class Intern : Employee
{
    private string intershipDuration;

    public Intern(string intershipDuration, string name, int id, double salary) : base(name, id, salary)
    {
        this.intershipDuration = intershipDuration;
    }

    // Overriding DisplayDetails to include InternshipDuration
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Internship Duration: {intershipDuration}");
    }
}

class Program
{
    public static void Main()
    {
        // Reading inputs for Employee details
        Console.WriteLine("Enter Employee Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Employee ID:");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Salary:");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Manager Team Size:");
        int teamSize = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Developer Programming Language:");
        string programmingLanguage = Console.ReadLine();
        Console.WriteLine("Enter Intern Duration:");
        string internshipDuration = Console.ReadLine();

        // Creating an Employee object
        Employee employee = new Employee(name, id, salary);
        employee.DisplayDetails();

        // Creating instances of subclasses with correct parameters
        Employee employee1 = new Manager(teamSize, name, id, salary);
        employee1.DisplayDetails();

        Employee employee2 = new Developer(programmingLanguage, name, id, salary);
        employee2.DisplayDetails();

        Employee employee3 = new Intern(internshipDuration, name, id, salary);
        employee3.DisplayDetails();

        Console.ReadLine();
    }
}*/