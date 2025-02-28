using System;
using Newtonsoft.Json;

namespace JsonAssignment
{
    internal class ReadJson
    {
        public static void ExtractNameEmail()
        {
            string path = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\JsonAssignment\\user.json";
            try
            {
                string jsonString = File.ReadAllText(path);
                dynamic user = JsonConvert.DeserializeObject(jsonString);

                Console.WriteLine("Extract only Email and name of User: ");
                Console.WriteLine($"user Name: {user.Name} \tuser Email-Id: {user.Email}");
            }
            catch (Exception e)
            {
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
