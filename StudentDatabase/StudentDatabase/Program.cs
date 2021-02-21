using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { FirstName = "Bobby", LastName = "Smith" };

                ctx.Students.Add(student);
                ctx.SaveChanges();

            }
        }
    }
}
