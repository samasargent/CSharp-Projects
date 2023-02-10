using System;

namespace ParsingEnums
{
    // Creating an enum for the days of the week
    public enum DaysOfTheWeek
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompting the user to enter the current day
            Console.WriteLine("Please enter the current day of the week.");

            // Try/catch block set up so if the user types something that isn't a day of week, they get an error
            try
            {
                // Parses what the user entered
                // "True" at the end of the parse statment lets it ignore the case, so it will take "Monday" or "monday" or "MONDAY"
                var dayPicked = Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine(), true);
                Console.WriteLine($"Day picked: {dayPicked}");
            }

            // If user enters something other than a day of the week, they get the error message
            catch
            {
                Console.WriteLine("Please enter an actual day of the week."); 
            }
            
            Console.ReadLine();
        }

    }
}
