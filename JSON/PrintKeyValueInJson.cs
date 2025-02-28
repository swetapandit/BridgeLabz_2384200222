using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace  JsonAssignment
{
    internal class PrintKeyValueInJson
    {
        internal static void PrintKeyValue()
        {
            string path = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\JsonAssignment\\user.json";
            string jsonString = File.ReadAllText(path);
            dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(jsonString);
            Console.WriteLine("Printing the Key Value Pair: ");

            // Loop through each key-value pair
            foreach (var pair in jsonData)
            {
                Console.WriteLine($"Key: {pair.Name}, Value: {pair.Value}");
            }
        }

        internal static void Method2()
        {
            try
            {
                string filePath = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\JsonAssignment\\user.json";
                // Read JSON file
                string jsonString = File.ReadAllText(filePath);

                // Parse JSON as JObject
                JObject jsonData = JObject.Parse(jsonString);

                Console.WriteLine("Printing all keys and values from JSON:");

                // Loop through each key-value pair
                foreach (var pair in jsonData)
                {
                    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
