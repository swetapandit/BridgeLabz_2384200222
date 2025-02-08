/*using System;

interface Worker
{
    void PerformDuties();
}

class Person
{
    string name;
    int id;
    public Person(string name, int id)
    {
        this.name = name;
        this.id = id;
    }
}

class Chef : Person, Worker
{
    public Chef(string name,int id) : base(name,id) { }
    public void PerformDuties()
    {
        Console.WriteLine("I am chef and i cook food");
    }
}

class Waiter : Person, Worker
{
    public Waiter(string name, int id) : base(name, id) { }
    public void PerformDuties()
    {
        Console.WriteLine("I am Waiter and i serve food");
    }
}

class Program
{
    static void Main()
    {
        Chef c = new Chef("Rohan", 123);
        c.PerformDuties();

        Waiter w = new Waiter("Ramu", 111);
        w.PerformDuties();
        Console.ReadLine();
    }
}*/