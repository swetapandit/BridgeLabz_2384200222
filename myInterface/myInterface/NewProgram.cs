//using System;
//using System.Collections.Generic;

//// Interface for Abstraction
//interface IContact
//{
//    void AddData(int id, string name, string contNumber);
//    void UpdateData(int id, string newName, string newContNumber);
//    void DeleteData(int id);
//    void DisplayData();
//}

//// Contact Class (Encapsulated Data)
//class Contact
//{
//    public int id;
//    public string name;
//    public string contNumber;

//    public Contact(int id, string name, string contNumber)
//    {
//        this.id = id;
//        this.name = name;
//        this.contNumber = contNumber;
//    }
//}

//// Manage Class (Implements Interface & Hides Implementation)
//class Manage : IContact
//{
//    private List<Contact> contacts = new List<Contact>();  // Data hiding

//    public void AddData(int id, string name, string contNumber)
//    {
//        contacts.Add(new Contact(id, name, contNumber));
//        Console.WriteLine("Contact Added Successfully!");
//    }

//    public void UpdateData(int id, string newName, string newContNumber)
//    {
//        foreach (var con in contacts)
//        {
//            if (con.id == id)
//            {
//                con.name = newName;
//                con.contNumber = newContNumber;
//                Console.WriteLine("Contact Updated!");
//                return;
//            }
//        }
//        Console.WriteLine("Invalid ID!");
//    }

//    public void DeleteData(int id)
//    {
//        for (int i = 0; i < contacts.Count; i++)
//        {
//            if (contacts[i].id == id)
//            {
//                contacts.RemoveAt(i);
//                Console.WriteLine("Contact Deleted!");
//                return;
//            }
//        }
//        Console.WriteLine("Invalid ID!");
//    }

//    public void DisplayData()
//    {
//        Console.WriteLine("\n--- Contact List ---");
//        foreach (var con in contacts)
//        {
//            Console.WriteLine($"ID: {con.id}, Name: {con.name}, Contact: {con.contNumber}");
//        }
//    }
//}

//// Main Program (Menu-Driven, User Only Sees Interface Methods)
//class Program
//{
//    public static void Main()
//    {
//        IContact manage = new Manage(); // Interface reference for abstraction

//        while (true)
//        {
//            Console.WriteLine("\n1. Add Contact\n2. Update Contact\n3. Delete Contact\n4. Display Contacts\n5. Exit");
//            Console.Write("Enter choice: ");
//            int choice = int.Parse(Console.ReadLine());

//            if (choice == 1)
//            {
//                Console.Write("Enter ID: ");
//                int id = int.Parse(Console.ReadLine());
//                Console.Write("Enter Name: ");
//                string name = Console.ReadLine();
//                Console.Write("Enter Contact Number: ");
//                string contNumber = Console.ReadLine();
//                manage.AddData(id, name, contNumber);
//            }
//            else if (choice == 2)
//            {
//                Console.Write("Enter ID to Update: ");
//                int updateId = int.Parse(Console.ReadLine());
//                Console.Write("Enter New Name: ");
//                string newName = Console.ReadLine();
//                Console.Write("Enter New Contact Number: ");
//                string newContNumber = Console.ReadLine();
//                manage.UpdateData(updateId, newName, newContNumber);
//            }
//            else if (choice == 3)
//            {
//                Console.Write("Enter ID to Delete: ");
//                int deleteId = int.Parse(Console.ReadLine());
//                manage.DeleteData(deleteId);
//            }
//            else if (choice == 4)
//            {
//                manage.DisplayData();
//            }
//            else if (choice == 5)
//            {
//                Console.WriteLine("Exiting...");
//                break;
//            }
//            else
//            {
//                Console.WriteLine("Invalid choice! Try again.");
//            }
//        }
//    }
//}
