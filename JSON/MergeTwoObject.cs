using System;
using Newtonsoft.Json;

namespace JsonAssignment
{
    internal class MergeTwoObject
    {
        public static void Merge()
        {
            var studentInfo = new
            {
                name = "John",
                age = 25,
                address = "Mathura"
             };

            var StudentAdditionalInfo = new
            {
                emailId = "john.@gmail.com",
                Rollno = 12,
            };

            var mergedStudent = new
            {
                student = studentInfo,
               Details = StudentAdditionalInfo
            };

            string JsonString = JsonConvert.SerializeObject(mergedStudent, Formatting.Indented);
            Console.WriteLine("After Merging: ");
            Console.WriteLine(JsonString);
            Console.WriteLine("Merged Successfully");
        } 
    }
}
