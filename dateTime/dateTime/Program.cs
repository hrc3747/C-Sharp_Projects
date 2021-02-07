using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It is " + DateTime.Now);
            Console.ReadLine();
            Console.WriteLine("Please enter a number");
            int input = Convert.ToInt32(Console.ReadLine());
            TimeSpan hours = new TimeSpan(input, 0, 0);
            DateTime future = DateTime.Now + hours;
            Console.WriteLine("The future time is " + future);
            Console.ReadLine();
        }
    }
}
