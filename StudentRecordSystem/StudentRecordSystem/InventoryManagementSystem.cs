/*using System;

public class Inventory
{
    public int ItemId { get; set ; }
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public Inventory(int itemId, string itemName, int quantity, double price)
    {
        ItemId = itemId;
        ItemName = itemName;
        Quantity = quantity;
        Price = price;
    }
}

class Node
{
    public Inventory Inventory { get; set; }
    public Node Next { get; set; }

    public Node(Inventory inventory)
    {
        Inventory = inventory;
        Next = null;
    }

}

class InventoryList<T>
{
    private Node head;
    private Node tail;
    public InventoryList()
    {
        head = null;
        tail = null;
    }
    
    // Node Added to Beginning
    public void AddBeginning(Inventory inventory)
    {
        Node newNode = new Node(inventory);
        if (head == null) head = tail = newNode;
        else
        {
            newNode.Next = head;
            head = newNode;
        }
    }

    // Node added to End
    public void AddEnd(Inventory inventory) {
        Node newNode = new Node(inventory);
        if (head == null) head = tail = newNode;
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
    }

    // Node added at specific position
    public void AddAtPosition(Inventory inventory, int pos)
    {
        Node newNode = new Node(inventory);
        if (head == null) head = tail = newNode;
        if (pos <= 1)
        {
            AddBeginning(inventory);
            return;
        }

        Node temp = head;
        int cnt = 1;
        while(cnt < pos-1 && temp.Next != null)
        {
            temp = temp.Next;
            cnt++;
        }
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    //Delete inventory by its item number.
    public void DeleteInventory(int itemId)
    {
        if(head == null)
        {
            Console.WriteLine("We Don't have any Inventory!!!");
            return;
        }
        //if (head.Student.RollNumber == rollNumber)
        //{
        //    head = head.Next;
        //    return;
        //}

        Node temp = head;
        Node prev = null;
        if(temp.Inventory.ItemId == itemId)
        {
            Console.WriteLine("Inventory Found");
            head = head.Next;
            return;
        }
        while(temp.Inventory.ItemId != itemId && temp != null)
        {
            prev = temp;
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Inventory not Found with ItemId: " + itemId);
            return;
        }
        prev.Next = temp.Next;

    }

    //Search Inventory by ItemId
    public void SearchInventoryById(int itemId)
    {
        if (head == null)
        {
            Console.WriteLine("We Don't have any Inventory!!!");
            return;
        }
        if (head.Inventory.ItemId == itemId)
        {
            Console.WriteLine("Student Found");
            Console.Write(head.Inventory.ItemId);
            Console.Write(" " + head.Inventory.ItemName);
            Console.Write(" " + head.Inventory.Quantity);
            Console.Write(" " + head.Inventory.Price);
            Console.WriteLine("\n------------------------");
            return;
        }

        Node temp = head;
        while (temp.Inventory.ItemId != itemId && temp != null)
        {
            temp = temp.Next;
            if (temp.Next == null)
            {
                Console.WriteLine("Inventory not Found with Item Id: " + itemId);
                return;
            }
        }

        if (temp.Inventory.ItemId == itemId)
        {
            Console.WriteLine("Inventory Found");
            Console.Write(temp.Inventory.ItemId);
            Console.Write(" " + temp.Inventory.ItemName);
            Console.Write(" " + temp.Inventory.Quantity);
            Console.Write(" " + temp.Inventory.Price);
            Console.WriteLine("\n------------------------");
            return;
        }

    }
    //Search by ItemName
    public void SearchInventoryByName(string itemName)
    {
        if (head == null)
        {
            Console.WriteLine("We Don't have any Inventory!!!");
            return;

        }
        if (head.Inventory.ItemName == itemName)
        {
            Console.WriteLine("Inventory Found");
            Console.Write(head.Inventory.ItemId);
            Console.Write(" " + head.Inventory.ItemName);
            Console.Write(" " + head.Inventory.Quantity);
            Console.Write(" " + head.Inventory.Price);
            Console.WriteLine("\n------------------------");
            return;
        }

        Node temp = head;
        while (temp.Inventory.ItemName != itemName && temp != null)
        {
            temp = temp.Next;
            if (temp.Next == null)
            {
                Console.WriteLine("Inventory not Found with Item Name: " + itemName);
                return;
            }
        }

        if (temp.Inventory.ItemName == itemName)
        {
            Console.WriteLine("Iventory Found");
            Console.Write(temp.Inventory.ItemId);
            Console.Write(" " + temp.Inventory.ItemName);
            Console.Write(" " + temp.Inventory.Quantity);
            Console.Write(" " + temp.Inventory.Price);
            Console.WriteLine("\n------------------------");
            return;
        }

    }
    //Update Inventory Quantity by its ItemId
    public void UpdateInventory(int itemId,int quantity)
    {
        if (head == null)
        {
            Console.WriteLine("We Don't have any Inventory!!!");
            return;
        }
        if (head.Inventory.ItemId == itemId)
        {
            head.Inventory.Quantity = quantity;
            return;
        }

        Node temp = head;
        
        while (temp.Inventory.ItemId != itemId && temp != null)
        {
            temp = temp.Next;
            if (temp.Next == null)
            {
                Console.WriteLine("Inventory not Found with ItemId: " + itemId);
                return;
            }
        }
        if (temp.Inventory.ItemId == itemId)
        {
            Console.WriteLine("Inventory Found");
            temp.Inventory.Quantity = quantity;
            return;
        }
    }
    //Calculate total value of inventory by it name
    public void CalcInventory()
    {
        double totalValue = 0.0;
        if (head == null)
        {
            Console.WriteLine("We Don't have any inventory");
            return;
        }
        Node temp = head;
        while(temp.Next != null)
        {
            totalValue += temp.Inventory.Price * temp.Inventory.Quantity;
            temp = temp.Next;
        }
        Console.WriteLine("Total value is " + totalValue);
    }
    //Sort the inventory
    public void SortInventory()
    {
        int temp;
        Node ptr = head;
        Node ctr;
        while(ptr != null)
        {
            ctr = ptr.Next;
            while(ctr != null)
            {
                if(ctr.Inventory.ItemId < ptr.Inventory.ItemId)
                {
                    temp = ptr.Inventory.ItemId;
                    ptr.Inventory.ItemId = ctr.Inventory.ItemId;
                    ctr.Inventory.ItemId = temp;
                }
                ctr = ctr.Next;
            }
            ptr = ptr.Next;
        }
    }

    //Display Method
    public void Display()
    {
        Node temp = head;
        if(head == null)
        {
            Console.WriteLine("No Inventory exists!");
            return;
        }
        
        while (temp != null)
        {
            Console.Write(temp.Inventory.ItemId);
            Console.Write(" " + temp.Inventory.ItemName);
            Console.Write(" " + temp.Inventory.Quantity);
            Console.Write(" " + temp.Inventory.Price);
            Console.WriteLine("\n------------------------");
            temp = temp.Next;
        }
    }
}



public class Program
{
    public static void Main()
    {
        InventoryList<Inventory> inventoryList = new InventoryList<Inventory>();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Inventory at Beginning");
            Console.WriteLine("2. Add Inventory at End");
            Console.WriteLine("3. Add Inventory At Position");
            Console.WriteLine("4. Delete Inventory by ItemId");
            Console.WriteLine("5. Display Inventory");
            Console.WriteLine("6. Update Inventory");
            Console.WriteLine("7. Search Inventory by ItemId");
            Console.WriteLine("8. Search Inventory by ItemName");
            Console.WriteLine("9. Show Total Value");
            Console.WriteLine("10. Sort the Inventory");
            Console.WriteLine("11. Exit");
            Console.Write("Choose an option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                case 2:
                case 3:
                    Console.Write("Enter Item Id: ");
                    int itemId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Item Name: ");
                    string itemName = Console.ReadLine();
                    Console.Write("Enter Quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                    Console.Write("Enter Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Inventory inventory = new Inventory(itemId, itemName, quantity, price);
                    if (choice == 1)
                        inventoryList.AddBeginning(inventory);
                    else if (choice == 2)
                        inventoryList.AddEnd(inventory);
                    else
                    {
                        Console.WriteLine("Enter the Position: ");
                        int pos = Convert.ToInt32(Console.ReadLine());
                        inventoryList.AddAtPosition(inventory, pos);
                    }
                    break;


                case 4:
                    Console.Write("Enter ItemId to delete: ");
                    int itemToDelete = int.Parse(Console.ReadLine());
                    inventoryList.DeleteInventory(itemToDelete);
                    break;

                case 5:
                    inventoryList.Display();
                    break;
                case 6:
                    Console.Write("Enter ItemId to Update: ");
                    int itemToUpdate = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter no. of Quantity: ");
                    int quantity1 = int.Parse(Console.ReadLine());
                    inventoryList.UpdateInventory(itemToUpdate, quantity1);
                    break;
                case 7:
                    Console.Write("Enter ItemId to Search: ");
                    int itemToSearch = int.Parse(Console.ReadLine());
                    inventoryList.SearchInventoryById(itemToSearch);
                    break;
                case 8:
                    Console.Write("Enter ItemId to Search: ");
                    string itemToSearch1 = Console.ReadLine();
                    inventoryList.SearchInventoryByName(itemToSearch1);
                    break;
                case 9:
                    inventoryList.CalcInventory();
                    break;
                case 10:
                    inventoryList.SortInventory();
                    break;
                case 11:
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;

            }
        }
    }
}*/