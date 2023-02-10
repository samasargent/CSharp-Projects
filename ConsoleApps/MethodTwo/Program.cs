using System;

namespace MethodTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates the class MathOp, where the method that will be used is
            MathOp maths = new MathOp();

            // Asks user for first number, and converts it to an integer
            Console.WriteLine("Please enter a number.");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            
            // Asks user for second number, which is optional
            // Logs this as a string
            Console.WriteLine("Please enter a second number. (This is optional.)");
            string userString = Console.ReadLine();

            // Sets up variable 'result' so it can be used in the if/else statement
            // This is where the result of the equation will go
            int result = 0;

            // If userString contains "" or is null,
            // The method will use the default value 
            if (string.IsNullOrEmpty(userString))
            {
                result = maths.AddTogether(userNum1);
            }
            // Otherwise, the number entered into userString is converted to an integer
            // And used in the method with the first number entered
            else
            {
                int userNum2 = Convert.ToInt32(userString);
                result = maths.AddTogether(userNum1, userNum2);
            }

            // Writes the result of the equation
            Console.WriteLine("The result is {0}.", result);
            Console.ReadLine();
        }
    }
}
