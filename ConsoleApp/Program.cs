using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {

        // Assignment Part 1
        // One-dimensional string array
        string[] quotesArr = { "I'm not interested in ", "The only thing that feels better than ", "If you want something done, ", "The best way to find out if ", "We may encounter many " };
        // Asks user to input text and logs it in 'textEntered'
        Console.WriteLine("Please enter some text to finish the quotes.");
        string textEntered = (Console.ReadLine());
        
        // Iterates through each string and adds user's text input
        for (int i = 0; i < quotesArr.Length; i++)
        {
            quotesArr[i] = quotesArr[i] + textEntered;
        }

        // Prints off each string in the array
        for (int i = 0; i < quotesArr.Length; i++)
        {
            Console.WriteLine(quotesArr[i]);
        }

        // Assignment Part 2
        int count = 0;
        while(true) // An infinite loop
        {
            Console.WriteLine("It goes on and on...", count++);
            
            if (count > 10)
            {
                break;
            }
        }
        // Added 'count' variable and the break statement to stop the loop from running after 10 times 

        // Assignment Part 3
        // Loop where comparison uses a "<" operator
        int x = 0;
        while (x < 5)
        {
            Console.WriteLine("I have " + x + " bananas.");
            x++;
        }
        Console.WriteLine("I have enough bananas.");

        // Loop where comparison uses a "<=" operator
        int y = 0;
        while (y <= 4)
        {
            Console.WriteLine("I have " + y + " oranges.");
            y++;
        }

        // Assignment Part 4
        // String list with unique items
        List<string> fruits = new List<string>() { "apple", "orange", "banana", "peach", "kiwi", "watermelon" };
        
        // User input to search in the list
        Console.WriteLine("Search for a fruit:");
        string searchFruit = (Console.ReadLine());

        // Foreach loop that goes through fruits list
        foreach (string fruit in fruits)
        {
            // If user-entered fruit is found, find the index of that fruit in the list and write it
            if (fruit == searchFruit)
            {
                int index = fruits.FindIndex(a => a == searchFruit);
                Console.WriteLine(index);
            }
        }

        // If the list does not contain what the user entered, write message
        if (!fruits.Contains(searchFruit))
        {
            Console.WriteLine("Your input is not on the list.");
        }

        // Assignment Part 5
        // String list with at least 2 identical items
        List<string> cities = new List<string>() { "New York", "Los Angeles", "Chicago", "Paris", "Phoenix", "Seattle", "Paris", "Columbus" };

        // User input to search in the list
        Console.WriteLine("Search for a city:");
        string searchCity = (Console.ReadLine());

        var indices = new List<int>();

        // For loop that checks for user-input text
        // Where found, adds its index to new list indices
        for (int i = 0; i < cities.Count; i++)
        {
            if (cities[i] == searchCity)
            indices.Add(i);
        }

        // Writes indices where user-input text was found
        for (int j = 0; j < indices.Count; j++)
        {
            Console.WriteLine(indices[j]);
        }

        // If the list does not contain what the user entered, write message
        if (!cities.Contains(searchCity))
        {
            Console.WriteLine("Your input is not on the list.");
        }

        // Assignment Part 6
        // String list with at least 2 identical items
        // Also a second string list that is empty
        List<string> colors = new List<string>() { "red", "yellow", "green", "blue", "purple", "indigo", "blue", "gray" };
        List<string> colorsCheck = new List<string>();

        // Foreach loop going through list 'colors'
        foreach (string color in colors)
        {
            // If color is in the second list, 'colorsCheck', write duplicate message
            if (colorsCheck.Contains(color))
            {
                Console.WriteLine(color + " - this item is a duplicate");
            }
            // If not already in second list, it is unique
            else 
            {
                Console.WriteLine(color + " - this item is unique");
            }
            // Add color to the second list after checking
            colorsCheck.Add(color);
        }

        Console.ReadLine();
    }
    }
