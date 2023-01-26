using System;

namespace CallingMethods
{
    public class Maths
    {
        // Method that takes user input number and multiplies by 2
        public static void MultiplyBy2(int userNum)
        {
            Console.WriteLine(userNum * 2);
        }

        // Method that takes user input number and adds 20
        public static void Add20(int userNum)
        {
            Console.WriteLine(userNum + 20);
        }

        // Method that takes user input number and divides by 3
        public static void DivideBy3(int userNum)
        {
            Console.WriteLine(userNum / 3);
        }
    }
}
