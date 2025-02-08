using System;

interface IStudent
{
    void Method1();
}

class Student : IStudent
{
    public  void Method1()
    {
        Console.WriteLine("This is Student Class");
    }
}

class NewStudent : Student
{
    public void Method1()
    {
        Console.WriteLine("This is overriden Student Class");
    }

    public void m1(int n)
    {
        Console.WriteLine("The value of n is {0} ", n);
    }
    public void m1(string str)
    {
        Console.WriteLine("The value of str is {0} ", str);
    }
}

class Program
{
    public static void Main()
    {
        IStudent st = new NewStudent();
        NewStudent ns = new NewStudent();
        st.Method1();
        ns.m1(23);
        ns.m1("abc");
        Console.ReadLine();
    }
}