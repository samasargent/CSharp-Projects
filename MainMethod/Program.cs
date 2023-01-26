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
            // Instantiates the class MathOp
            MathOp maths1 = new MathOp();
            // Gets the result from the first "DoMath" method (user number times 10)
            int productResult = maths1.DoMath(userInt);
            // Outputs the result from the first Method
            Console.WriteLine("Your number times 10 equals: {0}", productResult);

            Console.WriteLine("Enter a number:");
            // Takes number user entered and converts it to a decimal
            decimal userDecimal = Convert.ToDecimal(Console.ReadLine());
            // Instantiates the class MathOp
            MathOp maths2 = new MathOp();
            // Gets the result from the second "DoMath" method (user number plus 20)
            int sumResult = maths2.DoMath(userDecimal);
            // Outputs the result from the second Method
            Console.WriteLine("Your number plus 20 equals: {0}", sumResult);

            Console.WriteLine("Enter a number:");
            // Takes number user entered in as a string
            string userStrNum = Console.ReadLine();
            // Instantiates the class MathOp
            MathOp maths3 = new MathOp();
            // Gets the result from the third "DoMath" method (user number divided by 2)
            int quotResult = maths3.DoMath(userStrNum);
            // Outputs the result from the third Method
            Console.WriteLine("Your number divided by 2 equals: {0}", quotResult);

            Console.ReadLine();
        }
    }
}
