/*using System;

interface IContact
{
    void AddData(int id, string name, string contNumber);
    void UpdateData(int id, string newName, string newContName);
    void DeleteData(int id);
    void DisplayData();
}

class Contact
{
    public int id;
    public string name;
    public string contNumber;

    public Contact(int id, string name, string contNumber)
    {
        this.id = id;
        this.name = name;
        this.contNumber = contNumber;
    }
}

class Manage : IContact
{
    private List<Contact> contacts = new List<Contact>();

    public void AddData(int id, string name, string contNumber)
    {
        contacts.Add(new Contact(id, name, contNumber));
    }

    public void UpdateData(int id, string newName, string newContNumber)
    {
        foreach(var con in contacts)
        {
            if(con.id == id)
            {
                con.name = newName;
                con.contNumber = newContNumber;
                return;
            }
        }
        Console.WriteLine("Invalid id");
    }

    public void DeleteData(int ind)
    {
        for(int i=0; i<contacts.Count; i++)
        {
            if (contacts[i].id == ind)
            {
                contacts.RemoveAt(i);
                return;
            }
        }
        Console.WriteLine("Invalid id");
    }

    public void DisplayData()
    {
        foreach(var con in contacts)
        {
            Console.WriteLine("ID: {0}", con.id);
            Console.WriteLine("Name: {0}", con.name);
            Console.WriteLine("Contact Number: {0}", con.contNumber);
        }
    }
}

class Program
{
    public static void Main()
    {
        IContact manage = new Manage();
        while (true)
        {
            Console.WriteLine("\n1. Add Contact\n2. Update Contact\n3. Delete Contact\n4. Display Contacts\n5. Exit");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Contact Number: ");
                string contNumber = Console.ReadLine();
                manage.AddData(id, name, contNumber);
            }
            else if (choice == 2)
            {
                Console.Write("Enter ID to Update: ");
                int updateId = int.Parse(Console.ReadLine());
                Console.Write("Enter New Name: ");
                string newName = Console.ReadLine();
                Console.Write("Enter New Contact Number: ");
                string newContNumber = Console.ReadLine();
                manage.UpdateData(updateId, newName, newContNumber);
            }
            else if (choice == 3)
            {
                Console.Write("Enter ID to Delete: ");
                int deleteId = int.Parse(Console.ReadLine());
                manage.DeleteData(deleteId);
            }
            else if (choice == 4)
            {
                manage.DisplayData();
            }
            else if (choice == 5)
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice! Try again.");
            }
        }
    }
}*/




using System;

class Parent
{
    public static void Show()
    {
        Console.WriteLine("Static method in Parent class.");
    }
}

class Child : Parent
{
    
}

class Program
{
    static void Main()
    {
        Parent.Show(); // Calls Parent's static method
        Child.Show();  // Calls Child's static method

        //Parent obj = new Child();
        //obj.Show(); // Still calls Parent's method (because static methods do not follow polymorphism)
        Console.ReadLine();
    }
}
