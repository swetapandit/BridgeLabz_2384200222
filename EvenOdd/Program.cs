using System;
namespace EvenOdd
{
    public class Program
    {
        
        public static void Main()
        {
            int num = 10;
            Check check = new Check();
            string str = check.EvenOrOdd(num);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}