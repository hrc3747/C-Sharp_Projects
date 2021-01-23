using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();
            int age = Convert.ToInt32(input);
            int i = 0;

            bool comp = i <= age;

            while (comp)
            { Console.WriteLine(i);
                i++;
                comp = i <= age;
            }
            Console.ReadLine();

            Console.WriteLine("Guess a number:");
            string input2 = Console.ReadLine();
            int guess = Convert.ToInt32(input2);

            int num = 13;

            bool guessed = num == guess;

            do
            {
                guessed = num == guess;

                if (guessed)
                {
                    Console.WriteLine("You guessed correctly, the number was " + num);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Sorry, that's not it.\nGuess Again.");
                    string inputnew = Console.ReadLine();
                    guess = Convert.ToInt32(inputnew);
                }
            }
            while (!guessed);
        }
    }
}
