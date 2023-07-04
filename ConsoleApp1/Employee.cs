using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthAge { get; set; }
        public int Pay { get; set; }

        public Employee(string firstName, string lastName, int birthAge, int pay)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthAge = birthAge;
            Pay = pay;
        }
    }

    internal class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return string.Compare(x.FirstName, y.FirstName);
        }
    }
}