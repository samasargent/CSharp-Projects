using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTwo
{
    public class MathOp
    {   
        // Method AddTogether takes two integers
        // The second one is optional, and the default value is 5
        public int AddTogether(int userNum1, int userNum2 = 5)
        {
            // Takes userNum1 and userNum2, adds them together and then multiplies by 2
            int result = (userNum1 + userNum2) * 2;
            return result;
        }
    }
}
