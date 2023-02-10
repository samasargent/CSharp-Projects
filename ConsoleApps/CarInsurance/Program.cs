using System;

class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Car Insurance Application");
        // Gets age and converts it to an integer
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        // Gets answer to DUI question and converts it to a boolean
        Console.WriteLine("Have you ever had a DUI? (Please enter \"true\" or \"false.\")");
        bool DUI = Convert.ToBoolean(Console.ReadLine());

        // Gets number of tickets and converts it to an integer
        Console.WriteLine("How many speeding tickets do you have?");
        int tickets = Convert.ToInt32(Console.ReadLine());

        // Boolean statement that checks that all rules are met
        // No DUIs, number of tickets is no more than 3 and age is greater than 15
        bool Qualified = DUI == false && tickets <= 3 && age > 15;
        
        // Gives the result of the above boolean statement
        Console.WriteLine("Qualified?");
        Console.WriteLine(Qualified);
        Console.ReadLine();
        }
    }
