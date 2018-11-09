using Revised.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Revised.Implementation
{
    public class ContractEmployee : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ContractEmployee(int id, string name)
        {
            ID = id;
            Name = name;
        }
        
        public decimal GetMinimumSalary()
        {
            return 1000;
        }

        public override string ToString()
        {
            return string.Format("{0}. {1}", ID, Name);
        }
    }
}
