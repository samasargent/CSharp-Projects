using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try block
            try
            {
                // Asks user for their age
                Console.WriteLine("What is your age?");
                // Converts what the user entered to an integer and assigns it to 'userAge'
                int userAge = Convert.ToInt32(Console.ReadLine());
                // If number entered is equal to or less than 0, throws an error 
                if (userAge <= 0)
                {
                    throw new LessThanZeroException();
                }
                // Takes current year and subtracts user's age to find what year they were born
                int whenBorn = DateTime.Now.Year - userAge;
                // Writes to the console when the user was born
                Console.WriteLine($"You were born in {whenBorn}.");
            }
            // Catch block for when the user's age is 0 or a negative number
            catch (LessThanZeroException)
            {
                Console.WriteLine("Please enter a number greater than 0.");
            }
            // Catch block for all other exceptions
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
            }
            Console.ReadLine();
        }
    }
}
