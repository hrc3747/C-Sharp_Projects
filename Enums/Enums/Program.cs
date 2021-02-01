using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the day of the week.");
            string input = Console.ReadLine();

            try
            {
                Enum.Parse(typeof(DaysOfTheWeek), input, true);
                Console.WriteLine("Today is " + input);
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
