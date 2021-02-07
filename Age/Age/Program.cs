using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;

            try
            {
                Console.WriteLine("How old are you?");
                bool valid = int.TryParse(Console.ReadLine(), out age);
                if (!valid)
                {
                    throw new Exception();
                }
                if ( age <= 0)
                {
                    throw new negativeException();
                }
                DateTime current = DateTime.Now;
                int currentYear = current.Year;
                int birthyear = currentYear - age;
                Console.WriteLine("You were born in " + birthyear);
                Console.ReadLine();
            }
            catch (negativeException)
            {
                {
                    Console.WriteLine("Please enter positive numbers only.");
                    Console.ReadLine();
                    return;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
                Console.ReadLine();
                return;
            }
        }
    }
}
