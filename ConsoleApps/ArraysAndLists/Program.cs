using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creates a string array
        string[] strArray1 = new string[] { "The Land Before Time", "Anastasia", "Thumbelina", "Halloweentown", "Hocus Pocus" };
        
        // Asks user to type in a number, and writes the data from the corresponding index of the array
        Console.WriteLine("Select an index from the array.");
        int strIndexPicked = Convert.ToInt32(Console.ReadLine());

        // If statements checks if number picked is greater than or equal to 0
        // and less than the total number of items in the list
        if (strIndexPicked >= 0 && strIndexPicked < strArray1.Length ) {
            Console.WriteLine(strArray1[strIndexPicked]);
        }
        else
        {
            Console.WriteLine("Index is out of range.");
        }

        // Creates an integer array
        int[] numArray1 = new int[] { 908, 822, 242, 46, 287, 823 };

        // Asks user to type in a number, and writes the data from the corresponding index of the array
        Console.WriteLine("Select an index from the array.");
        int numIndexPicked = Convert.ToInt32(Console.ReadLine());

        // If statements checks if number picked is greater than or equal to 0
        // and less than the total number of items in the list
        if (numIndexPicked >= 0 && numIndexPicked < numArray1.Length)
        {
            Console.WriteLine(numArray1[numIndexPicked]);
        }
        else
        {
            Console.WriteLine("Index is out of range.");
        }

        // Creates a string list
        var cities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Paris",
                        "Seattle",
                        "Memphis",
                        "Anchorage",
                        "Budapest"
                    };

        // Asks user to type in a number, and writes the data from the corresponding index of the list
        Console.WriteLine("Select an index from the list.");
        int listIndexPicked = Convert.ToInt32(Console.ReadLine());

        // If statements checks if number picked is greater than or equal to 0
        // and less than the total number of items in the list
        if (listIndexPicked >= 0 && listIndexPicked < cities.Count)
        {
            Console.WriteLine(cities[listIndexPicked]);
        }
        else
        {
            Console.WriteLine("Index is out of range.");
        }

        Console.ReadLine(); 
    }
}

