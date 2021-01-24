using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "This is a string.  ";
            string string2 = "And this is another string.  ";
            string string3 = "Unfortunately these strings are not very interesting.";

            string paragraph = string1 + string2 + string3;

            string upper = string1.ToUpper();

            StringBuilder sb = new StringBuilder();
            sb.Append(string1);
            sb.Append(string2);
            sb.Append(string3);

            Console.WriteLine(paragraph);
            Console.WriteLine(upper);
            Console.WriteLine(sb);
            Console.ReadLine();




        }
    }
}
