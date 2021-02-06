using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>();

            {
                EmployeeList.Add(new Employee("Joe", "Smith", 1));
                EmployeeList.Add(new Employee("Joe", "Jackson", 2));
                EmployeeList.Add(new Employee("JJ", "Adams", 3));
                EmployeeList.Add(new Employee("Amanda", "Smith", 4));
                EmployeeList.Add(new Employee("Sally", "Thomas", 5));
                EmployeeList.Add(new Employee("Diane", "Wood", 6));
                EmployeeList.Add(new Employee("Abby", "Long", 7));
                EmployeeList.Add(new Employee("Mike", "Johnson", 8));
                EmployeeList.Add(new Employee("Alex", "Marsh", 9));
                EmployeeList.Add(new Employee("Mack", "Swartz", 10));
            };

            List<Employee> Joes = new List<Employee>();

            foreach (var employee in EmployeeList)
            {
                if (employee.Fname == "Joe")
                {
                    Joes.Add(employee);
                    Console.WriteLine(employee.Fname + " " + employee.Lname);
                }
            }
            Console.ReadLine();

            List<Employee> otherJoes = EmployeeList.Where(x => x.Fname == "Joe").ToList();
            List<Employee> idList = EmployeeList.Where(x => x.id > 5).ToList();

        }
    }
}
