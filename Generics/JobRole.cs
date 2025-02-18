using System;
using System.Collections.Generic;

// Abstract class representing a JobRole
abstract class JobRole
{
    public string JobTitle { get; set; }
    public string RequiredSkills { get; set; }

    // Abstract method to display job details
    public abstract void DisplayJobDetails();
}

// Specific job roles inheriting from JobRole

class SoftwareEngineer : JobRole
{
    public SoftwareEngineer()
    {
        JobTitle = "Software Engineer";
        RequiredSkills = "C#, ASP.NET, SQL";
    }

    public override void DisplayJobDetails()
    {
        Console.WriteLine($"Job Title: {JobTitle}\nRequired Skills: {RequiredSkills}");
    }
}

class DataScientist : JobRole
{
    public DataScientist()
    {
        JobTitle = "Data Scientist";
        RequiredSkills = "Python, Machine Learning, SQL";
    }

    public override void DisplayJobDetails()
    {
        Console.WriteLine($"Job Title: {JobTitle}\nRequired Skills: {RequiredSkills}");
    }
}

// Generic Resume class with a constraint on the type parameter
class Resume<T> where T : JobRole
{
    public string ApplicantName { get; set; }
    public T JobRole { get; set; }

    // Constructor to initialize the resume with applicant's name and job role
    public Resume(string applicantName, T jobRole)
    {
        ApplicantName = applicantName;
        JobRole = jobRole;
    }

    // Method to process and display resume details
    public void ProcessResume()
    {
        Console.WriteLine($"Processing Resume for {ApplicantName}...");
        JobRole.DisplayJobDetails();
    }
}

class Program
{
    static void Main()
    {
        // Create resumes for different job roles
        Resume<SoftwareEngineer> softwareEngineerResume = new Resume<SoftwareEngineer>("Alice", new SoftwareEngineer());
        Resume<DataScientist> dataScientistResume = new Resume<DataScientist>("Bob", new DataScientist());

        // List to handle multiple resumes
        List<JobRole> resumes = new List<JobRole>();
        resumes.Add(softwareEngineerResume.JobRole);
        resumes.Add(dataScientistResume.JobRole);

        // Process all resumes in the list dynamically
        Console.WriteLine("Processing all resumes in the list:\n");
        foreach (var resume in resumes)
        {
            resume.DisplayJobDetails();
        }

        // Process individual resumes
        Console.WriteLine("\nProcessing individual resumes:\n");
        softwareEngineerResume.ProcessResume();
        dataScientistResume.ProcessResume();
        Console.ReadLine();
    }
}
