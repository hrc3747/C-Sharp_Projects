using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report \n");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page?");
            string page = Console.ReadLine();
            int pageNumber = Convert.ToInt32(page);
            Console.WriteLine("Do you need help with anything?  Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(help);
            Console.WriteLine("Were there any positive experiences today that you'd like to share?  Please give specifics.");
            string positive = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide?  Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            byte hoursStudied = Convert.ToByte(hours);
            Console.WriteLine("Thank you for your answers.  An Instructor will respond to this shortly.  Have a great day!");
            Console.ReadLine();
        }
    }
}
