using System;

class Person
{
    // Private properties with logic inside the setter
    private int Id { get; set; }
    private string Name { get; set; }
    private int Age
    {
        get { return age; }
        set
        {
            if (value > 0)  // Ensuring age is positive
                age = value;
        }
    }

    private int age; // Backing field for Age

    // Constructor to set values
    public Person(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age; // This will internally call the private set logic
    }

    // Public methods to get values
    public int GetId() => Id;
    public string GetName() => Name;
    public int GetAge() => Age;
}

class Program
{
    static void Main()
    {
        // Object create karna aur values set karna (constructor se)
        Person person = new Person(1, "Aarushi", 22);

        // Values print karna
        Console.WriteLine($"Id: {person.GetId()}, Name: {person.GetName()}, Age: {person.GetAge()}");
    }
}
