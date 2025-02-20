//using System;
//using System.IO;

//class FileHandlingExample
//{
//    static void Main()
//    {
//        string sourceFilePath = "/Users/swetapandit/Desktop/Mydotnet/file.txt"; // Change this as needed
//        string destinationFilePath = "/Users/swetapandit/Desktop/Mydotnet/destination.txt";

//        try
//        {
//            // Check if source file exists
//            if (!File.Exists(sourceFilePath))
//            {
//                Console.WriteLine("Source file does not exist.");
//                Console.ReadLine();

//                return;
//            }

//            // Open FileStreams for reading and writing
//            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
//            using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
//            {
//                byte[] buffer = new byte[1024]; // Buffer to store data
//                int bytesRead;

//                // Read from source and write to destination
//                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
//                {
//                    destinationStream.Write(buffer, 0, bytesRead);
//                }

//                Console.WriteLine("File copied successfully.");
//            }
//                Console.ReadLine();
//        }
//        catch (IOException ex)
//        {
//            Console.WriteLine("An error occurred: " + ex.Message);
//        }
//    }
//}
