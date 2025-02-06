/*using System;
using System.Collections.Generic;

class Patient
{
    public string name;
    public List<Doctor> doctors; // Association: Patient has multiple doctors

    public Patient(string name)
    {
        this.name = name;
        doctors = new List<Doctor>(); // Initialize empty list of doctors
        Console.WriteLine($"Patient {this.name} Created");
    }

    public void AddDoctor(Doctor doctor)
    {
        doctors.Add(doctor); // Patient is associating with a Doctor
    }

    public void ShowDoctors()
    {
        Console.WriteLine($"Patient {name} has consulted:");
        foreach (Doctor doc in doctors)
        {
            Console.WriteLine($"- Dr. {doc.name}");
        }
    }

    ~Patient()
    {
        Console.WriteLine($"Patient {name} Destroyed");
    }
}

class Doctor
{
    public string name;
    public List<Patient> patients; // Association: Doctor has multiple patients

    public Doctor(string name)
    {
        this.name = name;
        patients = new List<Patient>(); // Initialize empty list of patients
        Console.WriteLine($"Doctor {this.name} Created");
    }

    public void Consult(Patient patient)
    {
        patients.Add(patient); // Doctor is consulting a Patient
        patient.AddDoctor(this); // Patient also stores reference of this Doctor
        Console.WriteLine($"Dr. {name} consulted Patient {patient.name}");
    }

    public void ShowPatients()
    {
        Console.WriteLine($"Dr. {name} has seen:");
        foreach (Patient pat in patients)
        {
            Console.WriteLine($"- {pat.name}");
        }
    }

    ~Doctor()
    {
        Console.WriteLine($"Doctor {name} Destroyed");
    }
}

class Hospital
{
    private List<Doctor> doctors; // Composition: Hospital owns Doctors

    public Hospital()
    {
        doctors = new List<Doctor>();
    }

    public void AddDoctor(string name)
    {
        doctors.Add(new Doctor(name));
    }

    public Doctor GetDoctor(int index)
    {
        if (index >= 0 && index < doctors.Count)
            return doctors[index];
        return null;
    }

    ~Hospital()
    {
        Console.WriteLine("Hospital Destroyed");
    }
}

class Program
{
    static void Main()
    {
        // Create a hospital
        Hospital hospital = new Hospital();

        // Create doctors (Composition: Hospital owns Doctors)
        hospital.AddDoctor("Sharma");
        hospital.AddDoctor("Mehta");

        // Create patients (Aggregation: Patients exist independently)
        Patient p1 = new Patient("Rohan");
        Patient p2 = new Patient("Sita");

        // Get doctors from hospital
        Doctor d1 = hospital.GetDoctor(0); // Dr. Sharma
        Doctor d2 = hospital.GetDoctor(1); // Dr. Mehta

        // Consultations (Association: Doctors and Patients interacting)
        d1.Consult(p1); // Dr. Sharma consults Rohan
        d1.Consult(p2); // Dr. Sharma consults Sita
        d2.Consult(p1); // Dr. Mehta consults Rohan

        // Show relationships
        d1.ShowPatients();
        d2.ShowPatients();
        p1.ShowDoctors();
        p2.ShowDoctors();

        // Destroy Hospital (Doctors will be deleted)
        hospital = null;
        GC.Collect(); // Force garbage collection
    }
}
*/