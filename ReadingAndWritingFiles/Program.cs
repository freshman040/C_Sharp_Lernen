using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\TAKE-IT\\Documents\\Csharp\\example.txt";

        // Writing to a file
        //string content = "Hello, World!";
        //File.WriteAllText(filePath, content);

        // Reading from a file
        string content = File.ReadAllText(filePath);
        Console.WriteLine(content);



    }
}