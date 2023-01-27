using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    public class MathOp
    {
        // Void method that outputs an integer with output parameterse
        public void DoMath(int userNum, out int result)
        {
            result = userNum / 2;
        }

        // Overloading the DoMath method, also making it static
        public static int DoMath(int userNum)
        {
            int result = (userNum + userNum);
            return result;
        }
    }
}
