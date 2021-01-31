using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy2
{
    class Class1
    {
        public static void DivideBy2(string input)
        {
            int input2 = Convert.ToInt32(input);
            int output = input2 / 2;
            Console.Write(input + "/2 = " + output);
            Console.ReadLine();

            return;
        }

        public static void Outputs(out int i, out int j)
        {
            i = 20;
            j = 30;
        }

        public static void Outputs(out int k)
        {
            k = 40;
        }

    }
}
