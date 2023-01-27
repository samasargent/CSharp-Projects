using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class where our methods are
            MathOp mathProblem = new MathOp();

            // Getting the user to enter a number and converting it to an integer
            Console.WriteLine("Please enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // Using the first DoMath, with an out parameter
            mathProblem.DoMath(userNum, out int result);
            Console.WriteLine("The value of your number divided by 2 is {0}.", result);

            // Using the static method, the second DoMath
            int result2 = MathOp.DoMath(userNum);
            Console.WriteLine("The value of your number plus itself is {0}.", result2);

            Console.ReadLine();
        }
    }
}
