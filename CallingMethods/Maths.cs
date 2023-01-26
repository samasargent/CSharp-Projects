using System;

namespace CallingMethods
{
    public class Maths
    {
        // Method that takes user input number and multiplies by 2
        public static int MultiplyBy2(int userNum)
        {
            int product = userNum * 2;
            return product;
        }

        // Method that takes user input number and adds 20
        public static int Add20(int userNum)
        {
            int sum = userNum + 20;
            return sum;
        }

        // Method that takes user input number and divides by 3
        public static int DivideBy3(int userNum)
        {
            int quotient = userNum / 3;
            return quotient;
        }
    }
}
