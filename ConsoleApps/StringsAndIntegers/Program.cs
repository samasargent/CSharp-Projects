using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
        // List of integers
        List<int> integers = new List<int>() { 10, 25, 56, 82, 32, 15, 76 };
        
        try { // Start of try block
        // User enters a number to divide the numbers in the integer list by
        Console.WriteLine("Please enter a number to divide by.");
        int divideBy = (Convert.ToInt32(Console.ReadLine()));
        
        // Foreach loop that divides each integer in the list by the number entered by the user
        foreach (int integer in integers)
        {
            int x = integer;
            x /= divideBy;
            Console.WriteLine(x);
        }
        
        } // End of try block

        catch (Exception ex) // Start of catch block
        {   
            Console.WriteLine(ex.Message);
            // Error message for whatever exception will write 
        } // End of catch blook

        // Message to display after try/catch block
        Console.WriteLine("Program execution has resumed.");
        Console.ReadLine();

        }
    }
