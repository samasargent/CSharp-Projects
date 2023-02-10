using System;

namespace MainMethod
{
    public class MathOp
    {
        public int DoMath(int userInt)
        {
            // Method takes user input number (as an integer)
            // Multiplies it 10
            // Returns the result
            int product = userInt * 10;
            return product;
        }

        public int DoMath(decimal userDecimal)
        {
            // Method takes user input number (as a decimal)
            // Adds 20 to it
            // Result is converted to an integer
            // Returns the result
            decimal sum = userDecimal + 20.0m;
            int sumInt = Convert.ToInt32(sum);
            return sumInt;
        }

        public int DoMath(string userStrNum)
        {
            // Method takes user input number (as a string)
            // Converts the string to an integer (if possible)
            // Divides it by 2
            // Returns the result
            int userConvertNum = Convert.ToInt32(userStrNum);
            int quotient = userConvertNum / 2;            
            return quotient;
        }
    }
}
