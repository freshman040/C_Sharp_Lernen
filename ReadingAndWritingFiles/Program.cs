class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\TAKE-IT\\Documents\\Csharp\\example.txt";
        //string filePath = "C:\\Users\\TAKE-IT\\Documents\\Csharp\\example2.txt";

        // Writing to a file
        //string content = "Hello, World!";
        //File.WriteAllText(filePath, content);

        // Reading from a file
        //string content = File.ReadAllText(filePath);
        //Console.WriteLine(content);

        //using (StreamWriter writer = new StreamWriter(filePath))
        //{
        //    writer.WriteLine("Hello, World!");
        //    writer.WriteLine("This is a second line.");
        //}

        //using (StreamReader reader = new StreamReader(filePath))
        //{
        //    string line;
        //    while ((line = reader.ReadLine()) != null)
        //    {
        //        Console.WriteLine(line);
        //    }
        //}

        try
        {
            // Attempt to read the file 
            string text = File.ReadAllText(filePath);
            Console.WriteLine(text);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Acces denied.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"An I/0 error occured: {ex.Message}");
        }

}



}
