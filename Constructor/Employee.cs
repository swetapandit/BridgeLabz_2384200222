using System;

class Employee
{
    public int employeeID;
    protected string department;
    private double salary;

    // Constructor to initialize employee details
    public Employee(int employeeID, string department, double salary)
    {
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }

    // Public method to get the salary
    public double GetSalary()
    {
        return salary;
    }

    // Public method to modify the salary
    public void ModifySalary(double newSalary)
    {
        if (newSalary >= 0) // Salary should not be negative
        {
            salary = newSalary;
        }
        else
        {
            Console.WriteLine("Invalid salary value. Salary cannot be negative.");
        }
    }

    // Method to display employee details
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee ID: {employeeID}, Department: {department}, Salary: ₹{salary}");
    }
}

// Subclass Manager to access employeeID and department, and demonstrate access modifiers
class Manager : Employee
{
    public Manager(int employeeID, string department, double salary)
        : base(employeeID, department, salary) // Call to the base class constructor
    {
    }

    // Method to display manager details (accessing protected and public members)
    public void DisplayManagerDetails()
    {
        Console.WriteLine($"Manager - Employee ID: {employeeID}, Department: {department}");
    }
}

class Program
{
    static void Main()
    {
        // Creating an Employee object
        Employee employee1 = new Employee(1001, "Sales", 50000.0);
        employee1.DisplayEmployeeDetails();

        // Modifying the salary using public method
        employee1.ModifySalary(55000.0);
        Console.WriteLine($"Updated Salary: {employee1.GetSalary():C}");

        Console.WriteLine();

        // Creating a Manager object
        Manager manager1 = new Manager(2001, "HR", 80000.0);
        manager1.DisplayManagerDetails();
        manager1.DisplayEmployeeDetails();  // Can access the protected department and public employeeID
    }
}
