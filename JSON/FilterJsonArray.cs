using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

class FilterJsonArray
{
   public static void Filter()
    {
        string json = @"[
            { 'Name': 'Alice', 'Age': 30 },
            { 'Name': 'Bob', 'Age': 20 },
            { 'Name': 'John', 'Age': 40 }
        ]";

        JArray jsonData = JArray.Parse(json);

        var filteredData = jsonData.Where(user => (int)user["Age"] > 25);

        foreach (var item in filteredData)
        {
            Console.WriteLine(item);
        }
    }
}
