using Revised.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Revised.Implementation
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(int id, string name) : base(id, name)
        {
        }
        
        public override decimal GetMinimumSalary()
        {
            return 1000;
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }

    }
}
