/*using System;
using System.IO;

namespace FileStream1
{
	public class MyFile
	{
		public void LetsCopy(string source, string destination)
		{
			if (!File.Exists(source))
			{
				Console.WriteLine("File Doesn't Exists!!!");
				Console.ReadLine();
				return;
			}
			// Open File Stream
			using (FileStream fileSource = new FileStream(source, FileMode.Open, FileAccess.Read)) {
				using (FileStream filedestination = new FileStream(destination, FileMode.Create, FileAccess.Write))
				{
					int i;
					while ((i = fileSource.ReadByte())!= -1)
					{
						filedestination.WriteByte((Byte)i);

					}
					Console.WriteLine("File Data Copied");
                    Console.ReadLine();

                }
            }
		}

	}
	public class Program
	{
		public static void Main()
		{
			string source = "/Users/swetapandit/Desktop/Mydotnet/file.txt";
			string destination = "/Users/swetapandit/Desktop/Mydotnet/destination.txt";

			MyFile myFile = new MyFile();
			myFile.LetsCopy(source, destination);
		}
	}
}*/