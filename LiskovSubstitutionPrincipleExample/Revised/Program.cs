using Revised.Abstract;
using Revised.Implementation;
using System;
using System.Collections.Generic;

namespace Revised
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEmployee> employees = new List<IEmployee>();

            employees.Add(new PermanentEmployee(1, "Raju"));
            employees.Add(new PartTimeEmployee(2, "Sanju"));
            employees.Add(new ContractEmployee(3, "Tiju"));

            employees.ForEach(e => Console.WriteLine(e.ToString()));

            List<Employee> emps = new List<Employee>();
            emps.Add(new PermanentEmployee(1, "Raju"));
            emps.Add(new PartTimeEmployee(2, "Sanju"));

            emps.ForEach(e => Console.WriteLine("{0}. {1}", e.ToString(), e.CalculateBonus(e.GetMinimumSalary())));

            Console.Read();
        }
    }
}
