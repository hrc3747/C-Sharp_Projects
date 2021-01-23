using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceAproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string input1 = Console.ReadLine();
            int age = Convert.ToInt32(input1);

            Console.WriteLine("Have you ever had a DUI?");
            string input2 = Console.ReadLine();
            bool dui = Convert.ToBoolean(input2);

            Console.WriteLine("How many speeding tickets do you have?");
            string input3 = Console.ReadLine();
            int tickets = Convert.ToInt32(input3);

            bool qualified = age > 15 && dui == false && tickets < 3;
            Console.WriteLine("Qualified? \n" + qualified);
            Console.ReadLine();

        }
    }
}