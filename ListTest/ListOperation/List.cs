using System;
namespace ListOperation
{
	public class List1
	{
        private List<int> numbers;

        // Constructor to initialize the list with user-defined values
        public List1(List<int> value)
        {
            numbers = new List<int>(value);
        }

        // Method to add an element to the list
        public void AddElement(int element)
        {
            numbers.Add(element);
        }
        // Method to add an element to the list
        public int GetSize()
        {
            return numbers.Count;
        }

        // Method to remove an element from the list
        public bool RemoveElement(int element)
        {
            return numbers.Remove(element);
        }

        // Method to display list elements
        public void DisplayList()
        {
            Console.WriteLine("List Elements: " + string.Join(", ", numbers));
        }
    }
}

