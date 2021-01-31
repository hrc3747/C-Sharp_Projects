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
            //IQuittable quittable = new Employee();
            //quittable.Quit();

            //Employee newEmployee = new Employee();
            //newEmployee.FirstName = "Sample";
            //newEmployee.LastName = "Student";
            //newEmployee.id = 1;
            //newEmployee.SayName();
            //Console.ReadLine();

            //Employee otherEmployee = new Employee();
            //otherEmployee.id = 1;

            //Console.WriteLine("Do the new employee and the other employee have the same id?\n");
            //Console.WriteLine(newEmployee == otherEmployee);
            //Console.ReadLine();

            Employee<string> employee3 = new Employee<string>();
            employee3.Things = new List<string>() { "Bears", "Beets", "Battle Star Galactica" };

            Employee<int> employee4 = new Employee<int>();
            employee4.Things = new List<int>() { 1, 2, 3 };

            employee3.ListThings();
            employee4.ListThings();
            Console.ReadLine();
        }
    }
}
