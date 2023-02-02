using System;

namespace whatTime
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Prints the current date and time to the console
            Console.WriteLine(DateTime.Now);
            // Asks the user for a number
            Console.WriteLine("Pick a number.");
            // Gets the user number and logs in as in integer under 'userNumber'
            int userNumber = Convert.ToInt32(Console.ReadLine());
            // Adds the user's number to the current time and sets that to DateTime 'futureTime'
            DateTime futureTime = (DateTime.Now.AddHours(userNumber));
            // Prints to the console what time it will be after adding the user's number
            Console.WriteLine("The time in {0} hours will be {1}.", userNumber, futureTime.ToString("h:mm tt"));
            Console.ReadLine();
        }
    }
}
