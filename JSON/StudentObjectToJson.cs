using System;
using Newtonsoft.Json;

namespace JsonAssignment
{
    internal class StudentObjectToJson
    {
        public static void CreateJSONObjectUsingAnnonymous() {
             //Create an Json Object for a Student
            var student = new
            {
                name = "ALexa",
                age = 23,
                subject = new string[] { "Math", "Physics", "Computer Science" }
            };

            string jsonString = JsonConvert.SerializeObject(student, Formatting.Indented);
            Console.WriteLine("Here’s the JSON:");
            Console.WriteLine(jsonString);

        }
    }
    //class Program
    //{
    //    static void Main()
    //    {
    //      StudentObjectToJson.CreateJSONObjectUsingAnnonymous();
    //    }
    //}
}
