using System;
using System.Collections.Generic;
using System.Text;

namespace Revised.Abstract
{
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public abstract decimal GetMinimumSalary();

        public Employee(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("{0}. {1}", ID, Name);
        } 
    }
}
