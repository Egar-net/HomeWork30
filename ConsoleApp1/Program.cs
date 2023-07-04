namespace ConsoleApp1;
using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee("John", "Duo", 25, 50000),
            new Employee("Alice De", "Smithen", 30, 60000),
            new Employee("John", "Wick", 43, 55000)
        };

        employees.Sort(new EmployeeComparer());

        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}, год рождения: {employee.BirthAge}, зарплата: {employee.Pay}");
        }
    }
}