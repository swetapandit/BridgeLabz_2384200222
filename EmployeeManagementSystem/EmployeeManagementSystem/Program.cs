using System;
class Program
{
    private static Employee? employee;
    public static void Main()
    {
        Console.WriteLine("1.Full Time Employee\n2. Part Time Employee ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the working Hours: ");
        int workingHours = Convert.ToInt32(Console.ReadLine());

        

        switch (choice)
        {
            case 1:
                employee = new FullTimeEmployee(workingHours);
                Console.WriteLine("Enter Employee Id: ");
                employee.EmployeeId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Name: ");
                employee.Name = "" + Console.ReadLine();
                Console.WriteLine("Enter the Base Salary: ");
                employee.BaseSalary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Department Name: ");
                employee.DepartmentName = Console.ReadLine();

                employee.CalculateSalary(employee.BaseSalary);
                employee.DisplayDetails();
                employee.GetDepartmentDetails();
                break;
            case 2:
                employee = new PartTimeEmployee(workingHours);
                Console.WriteLine("Enter Employee Id: ");
                employee.EmployeeId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Name: ");
                employee.Name = "" + Console.ReadLine();
                Console.WriteLine("Enter the Base Salary: ");
                employee.BaseSalary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Department Name: ");
                employee.DepartmentName = Console.ReadLine();

                employee.CalculateSalary(employee.BaseSalary);
                employee.DisplayDetails();
                employee.GetDepartmentDetails();
                break;
        }
        Console.ReadLine();
    }
}