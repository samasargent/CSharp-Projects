using System;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates the class MathOp, where the method is
            MathOp mathProblem = new MathOp();
            
            // Calling the method, passing in two numbers
            mathProblem.TwoNumbers(2, 3);

            // Calling the method with parameters by name
            mathProblem.TwoNumbers(num1: 5, num2: 12);

            Console.ReadLine(); 
        }
    }
}
