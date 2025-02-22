using System;
namespace ListOperation;
public class Program
{
    public static void Main()
    {

        List<int> numbers = new List<int> { 1, 2, 3 };

        // Display initial list
        Console.WriteLine("Initial List: " + string.Join(", ", numbers));

        Console.WriteLine("Enter numbers for the list. Type 'done' to stop:");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
                break;

            numbers.Add(Convert.ToInt32(input));
        }

        List1 listManager = new List1(numbers);
        listManager.DisplayList();
        Console.WriteLine(listManager.GetSize());
        Console.Write("Enter a number to add: ");
        listManager.AddElement(Convert.ToInt32(Console.ReadLine()));
        listManager.DisplayList();
        Console.WriteLine(listManager.GetSize());
        Console.Write("Enter a number to remove: ");
        listManager.RemoveElement(Convert.ToInt32(Console.ReadLine()));
        listManager.DisplayList();
        Console.WriteLine(listManager.GetSize());
        Console.ReadLine();
    }
}