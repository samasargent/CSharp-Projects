using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to use?");
            // Gets text input by user and converts it to an integer
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The results are:");

            // Calls methods from Maths.cs and uses them with the number input by the user
            Maths.MultiplyBy2(userNum); 
            Maths.Add20(userNum);
            Maths.DivideBy3(userNum);

            Console.ReadLine();
        }
    }
}
