using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrincipleExample
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("{0}. {1}", ID, Name);
        }
    }

    public class PermanentEmployee : Employee
    {
        public PermanentEmployee(int id, string name) : base(id, name) { }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(int id, string name): base(id, name) {  }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }

    public class ContractEmployee : Employee
    {
        public ContractEmployee(int id, string name) : base(id, name) { }

        public override decimal CalculateBonus(decimal salary)
        {
            throw new NotImplementedException();
        }
    }
}
