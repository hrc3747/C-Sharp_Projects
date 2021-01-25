using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> integers = new List<int>() { 6, 2, 84, 36, 58, 92 };
                Console.WriteLine("Enter a number to divide integers in list by.");
                int divide = Convert.ToInt32(Console.ReadLine());

                foreach (int number in integers)
                {
                    Console.WriteLine(number / divide);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please format the input as an integer.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            finally
            {
                Console.WriteLine("\nProgram has finished execution.");
                Console.ReadLine();
            }
        }
    }
}
