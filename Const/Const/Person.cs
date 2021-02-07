using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const
{
    class Person
    {
        public Person(string Fname) : this(Fname, "unknown")
        {

        }
        public Person(string Fname, string Lname)
        {
            FirstName = Fname;
            LastName = Lname;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
