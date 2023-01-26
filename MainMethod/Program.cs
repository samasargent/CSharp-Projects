using System;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            // Takes number user entered and converts it to an integer
            int userInt = Convert.ToInt32(Console.ReadLine());
            // Gets the result from the first "DoMath" method (user number times 10)
            int productResult = MathOp.DoMath(userInt);
            // Outputs the result from the first Method
            Console.Write("Your number times 10 equals: {0} \n", productResult);

            Console.WriteLine("Enter a number:");
            // Takes number user entered and converts it to a decimal
            decimal userDecimal = Convert.ToDecimal(Console.ReadLine());
            // Gets the result from the second "DoMath" method (user number plus 20)
            int sumResult = MathOp.DoMath(userDecimal);
            // Outputs the result from the second Method
            Console.Write("Your number plus 20 equals: {0} \n", sumResult);

            Console.WriteLine("Enter a number:");
            // Takes number user entered in as a string
            string userStrNum = Console.ReadLine();
            // Gets the result from the third "DoMath" method (user number divided by 2)
            int quotResult = MathOp.DoMath(userStrNum);
            // Outputs the result from the third Method
            Console.Write("Your number divided by 2 equals: {0} \n", quotResult);

            Console.ReadLine();
        }
    }
}
