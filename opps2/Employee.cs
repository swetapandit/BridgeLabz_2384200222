/*using System;

public class Employee
{
    private static string companyName = "Capgemini India";
    private readonly int id;

    private static int totalEmployee = 0;
    private string name;
    private string designation;

    public Employee(string name, int id, string designation)
    {
        this.name = name;
        this.id = id;
        this.designation = designation;
        totalEmployee++;
    }

    public static string GetCompanyName()
    {
        return companyName;
    }

    public static int GetTotalEmployee()
    {
        return totalEmployee;
    }

    public void DisplayDetails()
    {
        if (this is Employee)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Company Name: {GetCompanyName()}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Employee Name: {name}");
            Console.WriteLine($"Employee Id: {id}");
            Console.WriteLine($"Employee Designation: {designation}");
            Console.WriteLine($"Total Employee: {GetTotalEmployee()}");
        }
        else Console.WriteLine("Invalid Book");
    }
}


class Program1
{
    public static void Main()
    {
        Console.WriteLine("---------Employee Management System---------");

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Employee Id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Designation: ");
        string designation = Console.ReadLine();

        Employee emp = new Employee(name, id, designation);

        emp.DisplayDetails();
        Console.ReadLine();
    }
}*/