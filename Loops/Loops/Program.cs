using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of strings
            string[] stringArray = { "Dogs", "Cats", "Cars", "Diamonds", "Pears" };

            //Search the array for string specified by user
            Console.WriteLine("What would you like to search for in the string array?");
            string search = Console.ReadLine();

            //Loop through array to search for user input
            for(int k=0; k < stringArray.Length; k++)
            {
                if(stringArray[k] == search)
                {
                    Console.WriteLine(search + " is located at index " + k);
                    break;
                } else if (k == stringArray.Length-1)
                {
                    Console.WriteLine("Sorry, that text was not found in the array.");
                }
            }
            Console.ReadLine();


            //As user for text and add to each string in array, display output array
            Console.Write("Please enter some text.\n");
            string text = Console.ReadLine();

            for (int i=0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + " " + text;
            }

            for (int j = 0; j <= stringArray.Length-1; j++)
            {
                Console.WriteLine(stringArray[j]);
            }
            Console.ReadLine();

            //Create a list of strings
            List<string> stringList = new List<string>() { "Bees", "Birds", "Bats", "Bees", "Bears", "Birds"};


            //Search the list for string specified by the user
            Console.WriteLine("What would you like to search for in the string list?");
            string search2 = Console.ReadLine();

            List<int> intList = new List<int>();

            for (int m=0; m < stringList.Count; m++)
            {
                if (stringList[m] == search2)
                {
                    intList.Add(m);
                }
            }

            if (intList.Count == 0)
            {
                Console.WriteLine("Sorry, that text was not found in the list.");
            } else
            {
                Console.WriteLine("That text was found at the following index/indices: ");
                intList.ForEach(Console.WriteLine);
            }

            Console.ReadLine();

            //Search the list for duplicate strings
            List<string> duplicates = new List<string>();
            bool dup = false;
            foreach (string animal in stringList)
            {
                dup = duplicates.Contains(animal);
                Console.WriteLine("\nChecking whether " + animal + " has already appeared in the list.");

                if (dup)
                {
                    Console.WriteLine(animal + " has already appeared in the list.");
                }
                else
                {
                    Console.WriteLine("This is the first instance of " + animal + " in the list.");
                }
               
                duplicates.Add(animal);
            }
            Console.ReadLine();
        }
    }
}
