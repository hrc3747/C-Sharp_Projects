using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int id { get; set; }

        public Employee(string Fname, string Lname, int id)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.id = id;
        }
    }
}
