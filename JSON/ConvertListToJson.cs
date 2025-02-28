using System;
using Newtonsoft.Json;

namespace JsonAssignment
{
    internal class ConvertListToJson
    {
        public static void ListToObject()
        {
            var student = new[]
            {
                new { id = 1,name = "Alexa",hobbie = "dancing" },
                new {id=2, name ="Bob", hobbie="figthing"},
                new{id =3, name ="Zxcv", hobbie="reading" }
            };

            string jsonString = JsonConvert.SerializeObject(student, Formatting.Indented);
            Console.WriteLine("Converting List object to Json: ");
            Console.WriteLine(jsonString);
            Console.WriteLine("Converted Successfully");


        }
    }
}
