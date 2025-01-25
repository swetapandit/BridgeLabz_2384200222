/*using System;

class Program
{
    static void Main(string[] args)
    {
        // Arrays to store salaries, years of service, bonus, and new salaries
        double[] salaries = new double[10];
        double[] yearsOfService = new double[10];
        double[] bonuses = new double[10];
        double[] newSalaries = new double[10];

        // Variables to store totals
        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        // Input salaries and years of service
        GetEmployeeDetails(salaries, yearsOfService);

        // Process data to calculate bonuses and totals
        ProcessEmployeeData(salaries, yearsOfService, bonuses, newSalaries, ref totalBonus, ref totalOldSalary, ref totalNewSalary);

        // Display the results
        DisplayResults(totalBonus, totalOldSalary, totalNewSalary, bonuses);
    }

    static void GetEmployeeDetails(double[] salaries, double[] yearsOfService)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter the salary of employee {i + 1}: ");
            salaries[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter the years of service of employee {i + 1}: ");
            yearsOfService[i] = Convert.ToDouble(Console.ReadLine());

            // Ensure valid input
            while (salaries[i] <= 0 || yearsOfService[i] < 0)
            {
                Console.WriteLine("Invalid input. Salary must be positive, and years of service cannot be negative.");
                Console.Write($"Re-enter the salary of employee {i + 1}: ");
                salaries[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Re-enter the years of service of employee {i + 1}: ");
                yearsOfService[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
    }

    static void ProcessEmployeeData(double[] salaries, double[] yearsOfService, double[] bonuses, double[] newSalaries,
                                     ref double totalBonus, ref double totalOldSalary, ref double totalNewSalary)
    {
        for (int i = 0; i < 10; i++)
        {
            double bonusPercentage = yearsOfService[i] > 5 ? 0.05 : 0.02;
            bonuses[i] = salaries[i] * bonusPercentage;
            newSalaries[i] = salaries[i] + bonuses[i];

            // Update totals
            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }
    }

    static void DisplayResults(double totalBonus, double totalOldSalary, double totalNewSalary, double[] bonuses)
    {
        Console.WriteLine("\nSummary:");
        Console.WriteLine($"Total Bonus Payout: {totalBonus}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary}");
        Console.WriteLine($"Total New Salary: {totalNewSalary}");
	Console.WriteLine($"Bonus of all the employees individually");
	for(int i=0; i<bonuses.Length; i++) Console.WriteLine($"Bonus of Employee {i+1} is {bonuses[i]}");
    }
}
*/