using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer to perform math operations with:");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input + " + 5 = " + Math.Add(input));
            Console.WriteLine(input + " - 5 = " + Math.Subtract(input));
            Console.WriteLine(input + " * 5 = " + Math.Multiply(input));
            Console.ReadLine();
        }
    }
}
