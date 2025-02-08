/*using System;

class Animal
{
    private string name;
    private string age;

    // Virtual method to be overridden
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes Sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog Barks");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}

class Program
{
    public static void Main()
    {
        Animal animal = new Animal();
        animal.MakeSound();

        // Polymorphism: Base class reference holding derived class objects
        Animal animal1 = new Dog();
        animal1.MakeSound();

        Animal animal2 = new Cat();
        animal2.MakeSound();

        Animal animal3 = new Bird();
        animal3.MakeSound();

        Console.ReadLine();
    }
}
*/