using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TexLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\Users\Hrene\logs\log.txt", true))
            {
                file.WriteLine(input);
            }
            string text = File.ReadAllText("C:\\Users\\Hrene\\logs\\log.txt");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
