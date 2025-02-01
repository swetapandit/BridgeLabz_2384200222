using System;

public class Book{
	private string title;
	private string author;
	private int price;
	
	public Book(string title, string author, int price){
		this.title = title;
		this.author = author;
		this.price = price;
	}
	public void Display(){
		Console.WriteLine("Book Title : " + title);
		Console.WriteLine("Book Author : " + author);
		Console.WriteLine("Book Price : " + price);
	}
}

public class Program3{
	public static void Main(){
		Console.Write("Enter the Book Title : ");
		string title = Console.ReadLine();
		Console.Write("Enter the Book Author : ");
		string author = Console.ReadLine();
		Console.Write("Enter the Book Price : ");
		int price = Convert.ToInt32(Console.ReadLine());
		Book b = new Book(title, author, price);
		b.Display();
	}
}