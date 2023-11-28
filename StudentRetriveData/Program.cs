using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\ACER\\OneDrive\\Desktop\\Practise Project2\\studentdata.txt";

        try
        {
            // Open the file with StreamReader
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Read and display each line
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
