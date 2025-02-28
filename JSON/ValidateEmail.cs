using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JsonAssignment
{
    internal class ValidateEmail
    {
      internal  static void EmailValidation()
        {
            string schemaText = @"{
            'type': 'object',
            'properties': {
                'Email': { 'type': 'string', 'format': 'email' }
            },
            'required': ['Email']
        }";

            string jsonText = @"{ 'Email': 'alexa@gmail.com' }";

            JSchema schema = JSchema.Parse(schemaText);
            JObject jsonData = JObject.Parse(jsonText);

            if (jsonData.IsValid(schema))
                Console.WriteLine("Valid JSON!");
            else
                Console.WriteLine("Invalid JSON!");
        }
    }
}


