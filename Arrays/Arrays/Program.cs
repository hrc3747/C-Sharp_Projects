using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringarray = { "apple", "bird", "pasta", "fruit", "boat" };
            int[] intarray = { 13, 7, 402, 205, 3, 95 };

            List<string> stringList = new List<string>();
            stringList.Add("pineapple");
            stringList.Add("house");
            stringList.Add("clock");
            stringList.Add("monkey");

            Console.Write("Please enter an index to select from the string array.\n");
            int input1 = Convert.ToInt32(Console.ReadLine());
            if (input1 > stringarray.Length)
            {
                Console.WriteLine("Sorry, that index doesn't exist for the given array.");
            } else
            {
                Console.WriteLine(stringarray[input1]);
            }
            Console.ReadLine();

            Console.Write("Please enter an index to select from the integer array.\n");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 > intarray.Length)
            {
                Console.WriteLine("Sorry, that index doesn't exist for the given array.");
            }
            else
            {
                Console.WriteLine(intarray[input2]);
            }
            Console.ReadLine();

            Console.Write("Please enter an index to select from the string list.\n");
            int input3 = Convert.ToInt32(Console.ReadLine());
            if (input3 > stringList.Count)
            {
                Console.WriteLine("Sorry, that index doesn't exist for the given array.");
            }
            else
            {
                Console.WriteLine(stringList[input3]);
            }
            Console.ReadLine();
        }
    }
}
