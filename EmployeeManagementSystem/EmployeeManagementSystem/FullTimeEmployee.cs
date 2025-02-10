using System;
public class FullTimeEmployee : Employee
{
    private int workingHours;
    public FullTimeEmployee(int workingHours)
    {
        this.workingHours = workingHours;
    }
    public override int CalculateSalary(int fixedSalary)
    {
        return workingHours * fixedSalary;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Working Hours: " + workingHours);
        Console.WriteLine($"Your Salary is: " + CalculateSalary(BaseSalary));
    }

}