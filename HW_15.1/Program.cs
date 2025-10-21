using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter the path to the source file: ");
        string sourcePath = Console.ReadLine();

        Console.Write("Enter the path to the file you want to copy the data to: ");
        string destinationPath = Console.ReadLine();

        try
        {
            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Error: Source file not found!");
                return;
            }

            string content = File.ReadAllText(sourcePath);

            File.WriteAllText(destinationPath, content);

            Console.WriteLine("File copied successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error copying file: {ex.Message}");
        }
    }
}