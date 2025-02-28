using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonAssignment
{
    internal class MergeObjectByLINQ
    {
        public static void Merge()
        {
            
                string json1 = @"{ 'Name': 'Alice', 'Age': 25 }";
                string json2 = @"{ 'Email': 'alice@example.com', 'City': 'New York' }";

                JObject obj1 = JObject.Parse(json1);
                JObject obj2 = JObject.Parse(json2);

                obj1.Merge(obj2);

                Console.WriteLine(obj1.ToString(Formatting.Indented));
            }
    }
}

