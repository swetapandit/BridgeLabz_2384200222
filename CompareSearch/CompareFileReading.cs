﻿/*using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class FileReadingComparison
{
    static void Main()
    {
        string filePath = "/Users/swetapandit/Desktop/Mydotnet/file.txt"; // Ensure this file exists

        Stopwatch sw = Stopwatch.StartNew();
        ReadUsingStreamReader(filePath);
        sw.Stop();
        Console.WriteLine($"StreamReader: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        ReadUsingFileStream(filePath);
        sw.Stop();
        Console.WriteLine($"FileStream: {sw.ElapsedMilliseconds} ms");
        Console.ReadLine();
    }

    static void ReadUsingStreamReader(string filePath)
    {
        using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
        {
            while (sr.ReadLine() != null) { }
        }
    }

    static void ReadUsingFileStream(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[4096];
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
    }
}
*/