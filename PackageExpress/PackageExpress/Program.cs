using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            string input1 = Console.ReadLine();
            double weight = Convert.ToDouble(input1);
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package height:");
                string input2 = Console.ReadLine();
                double height = Convert.ToDouble(input2);

                Console.WriteLine("Please enter the package width:");
                string input3 = Console.ReadLine();
                double width = Convert.ToDouble(input3);

                Console.WriteLine("Please enter the package length:");
                string input4 = Console.ReadLine();
                double length = Convert.ToDouble(input4);

                double quote = weight * height * width * length / 100;

                Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                Console.ReadLine();
            }
        }
    }
}
