using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonAssignment
{
    internal class CarObjectToJson
    {
        public static void CarObject()
        {
            var car = new
            {
                 name = "Roadster",
                brand = "Honda",
                color="black"
            };

            string jsonString = JsonConvert.SerializeObject(car, Formatting.Indented);
            Console.WriteLine("Created a Json Object of Car");
            Console.WriteLine(jsonString);
        }
    }
}
