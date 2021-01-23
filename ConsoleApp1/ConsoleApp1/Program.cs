using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Please enter an integer");
            string input1 = Console.ReadLine();
            int output1 = Convert.ToInt32(input1) * 50;
            Console.WriteLine(input1 + " x 50 = " + output1);

            Console.WriteLine("\n Please enter an integer");
            string input2 = Console.ReadLine();
            int output2 = Convert.ToInt32(input2) +25;
            Console.WriteLine(input2 + " + 25 = " + output2);

            Console.WriteLine("\n Please enter a number");
            string input3 = Console.ReadLine();
            double output3 = Convert.ToDouble(input3) /12.5;
            Console.WriteLine(input3 + " / 12.5 = " + output3);

            Console.WriteLine("\n Please enter a number");
            string input4 = Console.ReadLine();
            int value4 = Convert.ToInt32(input4);
            bool output4 = value4 > 50;
            Console.WriteLine("Is " + value4 + " greater than 50? " + output4);

            Console.WriteLine("\n Please enter an integer");
            string input5 = Console.ReadLine();
            int output5 = Convert.ToInt32(input5) / 7;
            int modulo5 = Convert.ToInt32(input5) % 7;
            Console.WriteLine(input5 + " / 7 = " + output5 + " with a remainder of " + modulo5);
            Console.ReadLine();

        }
    }
}
