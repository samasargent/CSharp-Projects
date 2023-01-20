using System;

class Program
    {
        static void Main()
        {
        // Daily Report Header
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        
        // First question, answer is a string
        Console.WriteLine("A. What is your name?");
        string studentName = Console.ReadLine();
        
        // Second question, answer is a string
        Console.WriteLine("B. What course are you on?");
        string studentCourse = Console.ReadLine();
        
        // Third question, answer is a number so we cast it from a string to an integer
        Console.WriteLine("C. What page number?");
        int pgNum = Convert.ToInt32(Console.ReadLine());
        
        // Fourth question, answer is true/false so we cast it from a string to a boolean
        Console.WriteLine("D. Do you need help with anything? Please answer \"true\" or \"false.\"");
        bool needHelp = Convert.ToBoolean(Console.ReadLine());
        
        // Fifth question, answer is a string
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string posExp = Console.ReadLine();
        
        // Sixth question, answer is a string
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string otherFeedback = Console.ReadLine();
        
        // Seventh question, answer is a number so we cast it from a string to an integer
        Console.WriteLine("How many hours did you study today?");
        int hoursStudied = Convert.ToInt32(Console.ReadLine());
        
        // End of the daily report
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        //ReadLine is here so the console window stays open long enough for the student to read the last line
        Console.ReadLine(); 
    }
}
