using System;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonAssignment
{
    internal class JsontoXML
    {
        public static void ConvertJsonIntoXML()
        {
           
                string json = @"{ 'Name': 'Alice', 'Age': 30, 'Email': 'alice@example.com' }";

                XmlDocument xmlDocument = JsonConvert.DeserializeXmlNode(json, "User");
                Console.WriteLine(xmlDocument.OuterXml);
            }
        }

    }

