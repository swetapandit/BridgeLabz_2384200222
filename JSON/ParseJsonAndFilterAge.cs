
using System;
using Newtonsoft.Json;

namespace JsonAssignment
{
    internal class ParseJsonAndFilterAge
    {
        public static void FilterAge()
        {
            var student = new[]
            {
                new { id = 1,name = "Alexa",age= 13,hobbie = "dancing" },
                new {id=2, name ="Bob", age= 25,hobbie="figthing"},
                new{id =3, name ="Zxcv",age=30, hobbie="reading" },
                new{id =4, name ="john",age=26, hobbie="playing" },
                new{id =5, name ="alice",age=36, hobbie="reading" }
            };

            string filePath = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\JsonAssignment\\student.json";
            // Convert list to JSON
            string jsonString = JsonConvert.SerializeObject(student, Formatting.Indented);

            // Write JSON to file
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("JSON file created successfully!\n");
            Console.WriteLine("Converting List object to JSON: ");
            Console.WriteLine(jsonString);

          
            // Read JSON from file and filter records where age > 25
            string readJson = File.ReadAllText(filePath);

            var filteredStudents = JsonConvert.DeserializeObject<dynamic>(jsonString);

            Console.WriteLine("\nPrinting the record whose age is gretaer than 25");

            foreach (var s in filteredStudents)
            {
                if (s.age > 25) //check the condition
                {
                    Console.WriteLine($"ID: {s.id} \tName: {s.name} \tage: {s.age} \thobby: {s.hobbie}");
                }
            }
        }
    }
}
