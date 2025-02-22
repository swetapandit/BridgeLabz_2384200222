//using System;
//using System.Text.RegularExpressions;

//namespace RegexPrac
//{
//	public class ExtractEmail
//	{
//        public static void Main()
//		{
//            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
//            string input = "test@example.com and sweta@gla.ac";

//            MatchCollection match = Regex.Matches(input, pattern);

//            foreach(Match m in match)
//            {
//                Console.WriteLine(m.Value);
//            }
//            Console.ReadLine();
//        }
//    }
//}

