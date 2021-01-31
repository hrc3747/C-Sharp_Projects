using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 newClass = new Class1();

            Console.WriteLine("Please enter an integer.");
            string input = Console.ReadLine();

            Class1.DivideBy2(input);

            int i, j, k;

            Class1.Outputs(out i, out j);
            Class1.Outputs(out k);
            Console.WriteLine(i + " " + j + " " + k);
            Console.ReadLine();
        }
    }
}
