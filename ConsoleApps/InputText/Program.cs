using System;
using System.IO;

namespace InputText
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user for a number
            Console.WriteLine("Pick a number.");
            // Assigns what the user wrote to string 'number'
            string number = Console.ReadLine();
            // Writes string 'number' to a text file
            File.WriteAllText(@"C:\Users\Samantha Sargent\logs\number.txt", number);
            // Assigns what is in number.txt (the file we just wrote to) to string 'file'
            string file = File.ReadAllText(@"C:\Users\Samantha Sargent\logs\number.txt");
            // Writes what is in string 'file' to the screen
            Console.WriteLine("Here's what it is in the file now: {0}", file);
            Console.ReadLine();
        }
    }
}
