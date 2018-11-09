using System;
using System.Collections.Generic;
using System.Text;

namespace Revised
{
    public interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
        decimal GetMinimumSalary();
    }

    public interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }
}
