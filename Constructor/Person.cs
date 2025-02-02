/*using System;

class Person
{
    private string Name;
    private int Age;

    // Parameterized Constructor
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    // Copy Constructor
    public Person(Person p1)
    {
        this.Name = p1.Name;
        this.Age = p1.Age;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {this.Name}, Age: {this.Age}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the Name of the Person ");
        string name = Console.ReadLine();

        Console.Write("Enter the Name of the Person ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Creating the original person object
        Person person1 = new Person(name, age);
        Console.WriteLine("Original Person:");
        person1.Display();

        // Creating a copy using the copy constructor
        Person person2 = new Person(person1);
        Console.WriteLine("\nCopied Person:");
        person2.Display();

        Console.ReadLine();
    }
}
*/