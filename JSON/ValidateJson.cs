using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; //JObject present in this namespace
using Newtonsoft.Json.Schema;


namespace JsonAssignment
{
    internal class ValidateJson
    {
        public static  void ValidatingSchema()
        {
            try
            {
                string schemaText = File.ReadAllText("C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\JsonAssignment\\Schema.json");
                string jsonString = File.ReadAllText("C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\JsonAssignment\\user.json");

                JSchema schema = JSchema.Parse(schemaText);
                JObject jsonData = JObject.Parse(jsonString); // Parse JSON object

                if (jsonData.IsValid(schema))
                    Console.WriteLine("JSON is valid!");
                else
                    Console.WriteLine("Invalid JSON!");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}