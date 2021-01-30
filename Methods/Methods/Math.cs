using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Math
    {
        public static int Add(int input)
        {
            int x = input + 10;
            return x;
        }

        public static int Multiply(decimal input2)
        {
            decimal y = input2 * 10;
            int z = Convert.ToInt32(y);
            return z;
        }

        public static int Modulus(string input3)
        {
            int a = Convert.ToInt32(input3) % 2;
            return a;
        }
    }
}
