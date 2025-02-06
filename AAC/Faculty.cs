/*using System;

class University
{
    public Department department;
    public Faculty faculty;

    private string universityName;
    private List<Department> departments;
    private List<Faculty> faculties;

    public University(string universityName)
    {
        this.universityName = universityName;
     
        departments = new List<Department>();
        faculties = new List<Faculty>();
    }

    public void AddDepartment(string deptName)
    {
        departments.Add(new Department(deptName));
    }

    public void AddFaculty(string facName)
    {
        faculties.Add(new Faculty(facName));
    }

    public void ShowUniversity()
    {
        Console.WriteLine("This is " + universityName);
        //Console.WriteLine("Deparment ");
        foreach(var dept in departments)
        {
            dept.ShowDetails();
        }

        Console.WriteLine("We have Faculties:- ");
        foreach (var fac in faculties)
        {
            fac.ShowDetails();
        }
    }
    ~University()
    {
        Console.WriteLine("Destroy University");
    }
}

class Department
{
    public Faculty faculty;
    private string deptName;

    public Department(string deptName)
    {
        this.deptName = deptName;
    }

    public void ShowDetails()
    {
        Console.WriteLine("Welcome to {0} Department", deptName);
    }
    ~Department()
    {
        Console.WriteLine("Destroy Department");
    }
}

class Faculty
{
    private string facName;

    public Faculty(string facName)
    {
        this.facName = facName;
    }
    public void ShowDetails()
    {
        Console.WriteLine("Faculty Name: {0}", facName);
    }

    ~Faculty()
    {
        Console.WriteLine("Destroy Faculty");
    }
}

class Program
{
    public static void Main()
    {

        University university = new University("GLA University");
        university.AddDepartment("Computer Science ");
        university.AddDepartment("Biotech ");
        university.AddDepartment("MCA ");
        university.AddFaculty("Alice ");
        university.AddFaculty("Bob ");
        university.AddFaculty("John ");
        university.ShowUniversity();
        Console.ReadLine();
    }
}*/