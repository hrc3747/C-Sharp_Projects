using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("\nPerson 1");

            Console.WriteLine("Hourly Rate?");
            string hourlyinput1 = Console.ReadLine();
            double hourly1 = Convert.ToDouble(hourlyinput1);

            Console.WriteLine("Hours worked per week?");
            string hoursinput1 = Console.ReadLine();
            double hours1 = Convert.ToDouble(hoursinput1);
            double annual1 = hourly1 * hours1 * 52;

            Console.WriteLine("\nPerson 2");

            Console.WriteLine("Hourly Rate?");
            string hourlyinput2 = Console.ReadLine();
            double hourly2 = Convert.ToDouble(hourlyinput2);

            Console.WriteLine("Hours worked per week?");
            string hoursinput2 = Console.ReadLine();
            double hours2 = Convert.ToDouble(hoursinput2);
            double annual2 = hours2 * hourly2 * 52;

            bool comp = annual1 > annual2;

            Console.WriteLine("\nAnnual Salary of Person 1: \n" + annual1);
            Console.WriteLine("Annual Salary of Person 2: \n" + annual2);
            Console.WriteLine("Does Person 1 make more money than Person 2? \n" + comp);
            Console.ReadLine();
           
        }
    }
}
