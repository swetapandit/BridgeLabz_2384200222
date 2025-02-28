using System;
using System.IO;
using Newtonsoft.Json;


namespace JsonAssignment
{
    internal class CSVToJson
    {
        public static void ConvertFile()
        {

            try
            {
                string csvFile = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\FileDemo\\EmployeeData.csv";
                string[] lines = File.ReadAllLines(csvFile); // Read CSV file

                string jsonString = JsonConvert.SerializeObject(lines, Formatting.Indented); // Convert to JSON
                Console.WriteLine(jsonString); // Print JSON output
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
