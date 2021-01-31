using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee : Person, IQuittable
    {
        public int id { get; set; }

        public void Quit()
        {
            Console.WriteLine("I'm outta here. - Ex-employee");
            Console.ReadLine();
        }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            return employee1.id == employee2.id;
        }

        public static bool operator!=(Employee employee1, Employee employee2)
        {
            return employee1.id == employee2.id;
        }
    }
}
