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

            // Gets the result of method MultiplyBy2
            int productResult = Maths.MultiplyBy2(userNum);
            // Outputs the result 
            Console.WriteLine("Your number times 2 equals: {0}", productResult);

            // Gets the result of method Add20
            int sumResult = Maths.Add20(userNum);
            // Outputs the result
            Console.WriteLine("Your number plus 20 equals: {0}", sumResult);

            //Gets the result of method DivideBy3
            int quotResult = Maths.DivideBy3(userNum);
            // Outputs the result
            Console.WriteLine("Your number divided by 3 equals: {0}", quotResult);

            Console.ReadLine();
        }
    }
}
