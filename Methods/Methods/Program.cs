using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer to perform addition.");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input + " + 10 = " + Math.Add(input));

            Console.WriteLine("\nPlease enter a decimal to perform multiplication.");
            decimal input2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(input2 + " + 10 = " + Math.Multiply(input2));

            Console.WriteLine("\nPlease enter an integer to check modulus of divide by 2.");
            int input3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Modulus = " + Math.Modulus(input3));

            Console.ReadLine();
        }
    }
}
