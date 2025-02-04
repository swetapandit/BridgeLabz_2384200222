using System;

class Hospital
{
    private static string hospitalName = "City Hospital";
    private static int totalPatients = 0;

    private readonly int id;
    private string name;
    private int age;
    private string ailment;


    public Hospital(int id, string name, int age, string ailment)
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.ailment = ailment;
        totalPatients++;
    }

    public static int GetTotalPatients()
    {
        return totalPatients;
    }

    public void DisplayPatients()
    {
        if (this is Hospital)
        {
            Console.WriteLine($"------{hospitalName}-------");
            Console.WriteLine($"Patient Id: {id}");
            Console.WriteLine($"Patient Name: {name}");
            Console.WriteLine($"Patient Age: {age}");
            Console.WriteLine($"Patient Ailment: {ailment}");
            Console.WriteLine($"Total Patient: {GetTotalPatients()}");
        }
        else Console.WriteLine("Invalid Data");
    }
}

class Program
{
    public static void Main()
    {
        Console.Write("Enter the Number of Patients ");
        int numOfPatients = Convert.ToInt32(Console.ReadLine());

        Hospital[] hospitals = new Hospital[numOfPatients];

        for(int i = 0; i < numOfPatients; i++)
        {
            Console.Write("Enter the id of the patient ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the name of the Patients ");
            string name = Console.ReadLine();

            Console.Write("Enter the age of the patient ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the ailment Patients ");
            string ailment = Console.ReadLine();

            hospitals[i] = new Hospital(id, name, age, ailment);

            Console.WriteLine("Admitted Patients:");
        }
        foreach (var h in hospitals)
        {
            h.DisplayPatients();
        }

        Console.ReadLine();
    }
}