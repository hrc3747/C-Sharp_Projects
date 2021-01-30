using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer.");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Would you like to provide a second integer?  Enter true for yes, or false for no.");
            bool optional = Convert.ToBoolean(Console.ReadLine());

            if (optional == true)
            {
                Console.WriteLine("Please enter a second integer.");
                int input2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(input1 + " x " + input2 + " = " + Math.Multiply(input1, input2));
            }
            else
            {
                Console.WriteLine(input1 + " x 10 = " + Math.Multiply(input1));
            }

            Console.ReadLine();
        }
    }
}
