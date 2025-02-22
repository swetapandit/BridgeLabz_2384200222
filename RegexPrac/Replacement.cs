//using System;
//using System.Text.RegularExpressions;

//class Program
//{
//    static void Main()
//    {
//        //string input = "This is a damn bad example with some stupid words.";
//        //string[] badWords = { "damn", "stupid"};
//        ////string pattern = @"\b(" + string.Join("|", badWords) + @")\b";
//        //string replacement = "****";

//        string input = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
//        string[] lang = { "Java", "Python", "JavaScript", "Go" };
//        string pattern = @"\b(" + string.Join("|", lang) + @")\b";
//        MatchCollection match = Regex.Matches(input,pattern);
//        foreach(Match m in match) Console.WriteLine(m+" ");
//        Console.ReadLine();
//    }
//}