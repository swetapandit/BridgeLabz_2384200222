using System;
using ReviewGoingOn;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static void Main()
        {
            //Console.WriteLine("Enter your Choice\n1.Display by name\n2.SortByAge");
            //int ch = Convert.ToInt32(Console.ReadLine());
            List<string> name = new List<string> { "abc", "bca" };
            Employee employee = new Employee();
            employee.DisplayByName(name);
        }
    }


}