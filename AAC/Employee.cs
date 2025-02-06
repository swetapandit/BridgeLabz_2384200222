/*using System;
using System.Collections.Generic;

// Employee class
class Employee
{
    public string name;

    public Employee(string name)
    {
        this.name = name;
    }

    public void ShowDetails()
    {
        Console.WriteLine("   - Employee: " + name);
    }
}

// Department class (Composition with Employees)
class Department
{
    public string deptName;
    private List<Employee> employees;

    public Department(string deptName)
    {
        this.deptName = this.deptName;
        employees = new List<Employee>();
    }

    public void AddEmployee(string empName)
    {
        employees.Add(new Employee(empName));
    }

    public void ShowEmployees()
    {
        Console.WriteLine(" - Department: " + deptName);
        foreach (var emp in employees)
        {
            emp.ShowDetails();
        }
    }
}

// Company class (Composition with Departments)
class Company
{
    public string companyName;
    private List<Department> departments;

    public Company(string companyName)
    {
        this.companyName = companyName;
        departments = new List<Department>();
    }

    public void AddDepartment(string deptName)
    {
        departments.Add(new Department(deptName));
    }

    public void AddEmployeeToDepartment(string deptName, string empName)
    {
        foreach (var dept in departments)
        {
            if (dept.deptName == deptName)
            {
                dept.AddEmployee(empName);
                return;
            }
        }
        Console.WriteLine("Department " + deptName + " not found!");
    }

    public void ShowCompanyStructure()
    {
        Console.WriteLine("Company: " + companyName);
        foreach (var dept in departments)
        {
            dept.ShowEmployees();
        }
    }

}

// Main Program
class Program
{
    static void Main()
    {
        // Creating a company
        Company myCompany = new Company("TechCorp");

        // Adding departments
        myCompany.AddDepartment("IT");
        myCompany.AddDepartment("HR");

        // Adding employees to departments
        myCompany.AddEmployeeToDepartment("IT", "Alice");
        myCompany.AddEmployeeToDepartment("IT", "Bob");
        myCompany.AddEmployeeToDepartment("HR", "Charlie");

        // Displaying company structure
        myCompany.ShowCompanyStructure();

        // Company goes out of scope, destructor called
        Console.ReadLine();
    }
}
*/