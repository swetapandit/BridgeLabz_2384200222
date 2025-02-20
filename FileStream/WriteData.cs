/*using System;
using System.IO;

public class UserInputToFile
{
    public static void Main(string[] args)
    {
        try
        {
            // Get user input (without loops)
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString); // Could still throw exception

            Console.WriteLine("Enter your favorite programming language:");
            string language = Console.ReadLine();

            // Save user info to file
            string filePath = "/Users/swetapandit/Desktop/Mydotnet/file.txt";
            SaveUserInfo(name, age, language, filePath);

            Console.WriteLine("User information saved to the file");
            Console.ReadLine();

        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid age. Please enter a number.");
            Console.ReadLine();

        }
        catch (OverflowException)
        {
            Console.WriteLine("Age is too large or too small.");
            Console.ReadLine();

        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
            Console.ReadLine();

        }
    }


    // Function to save user information to a file
    static void SaveUserInfo(string name, int age, string language, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine($"Name: {name}");
            writer.WriteLine($"Age: {age}");
            writer.WriteLine($"Favorite Language: {language}");
            writer.WriteLine("Data Saved");
        }
    }
}*/