using System;
public class PartTimeEmployee : Employee
{
    private int workingHours;
    public PartTimeEmployee(int workingHours)
    {
        this.workingHours = workingHours;
    }
    public override int CalculateSalary(int fixedSalary)
    {
        //Console.WriteLine($"{workingHours * fixedSalary}");
        return workingHours * fixedSalary;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Your Salary is: " + CalculateSalary(BaseSalary));
    }

}