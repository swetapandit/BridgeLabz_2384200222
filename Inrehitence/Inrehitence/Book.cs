/*using System;
class Book
{
    public string title;
    public int publicationYear;
    public Book(string title, int publicationYear)
    {
        this.title = title;
        this.publicationYear = publicationYear;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title:{title} \nPublication Year:{publicationYear}");
    }
}
class Author : Book
{
    string name, bio;
    public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear)
    {
        this.name = name;
        this.bio = bio;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Author Name: {name} \nAuthor Bio: {bio}");
    }
}
class HelloWorld
{
    static void Main()
    {
        Book mark = new Author("Julius Caesar", 1950, "Mark Twain", "Social writer");
        mark.DisplayInfo();

        Console.ReadLine();
    }
*/