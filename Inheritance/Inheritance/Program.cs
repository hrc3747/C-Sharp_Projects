using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();
            newEmployee.FirstName = "Sample";
            newEmployee.LastName = "Student";
            newEmployee.SayName();
            Console.ReadLine();
        }
    }
}
