using System;
public abstract class Employee : IDepartment
{
    private int employeeId;
    private string name;
    private int baseSalary;
    private string departmentName;
    public int EmployeeId
    {
        get { return employeeId; }
        set
        {
            if (value > 0) employeeId = value;
            else employeeId = 0;
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) Console.WriteLine("Name cannot be Empty");
            else name = value;
        }
    }

    public int BaseSalary
    {
        get { return baseSalary; }
        set
        {
            if (value > 0)
                baseSalary = value;
            else Console.WriteLine("Salary Must be Positive");
        }
    }

    public string DepartmentName
    {
        get { return departmentName; }
        set
        {
            if (string.IsNullOrEmpty(value)) Console.WriteLine("Department cannot be Empty");
            else departmentName = value;
        }
    }

    public abstract int CalculateSalary(int fixedSalary);

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Employee Id: {EmployeeId}");
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Employee Base Salary: {BaseSalary}");
    }

    public string AssignDepartment(string departmentName)
    {
        return departmentName;
    }
    public void GetDepartmentDetails()
    {
        Console.WriteLine("Your department is: " + AssignDepartment(departmentName));
    }

}