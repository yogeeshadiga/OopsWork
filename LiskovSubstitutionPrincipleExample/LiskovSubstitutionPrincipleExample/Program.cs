using System;

namespace LiskovSubstitutionPrincipleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee fullTime = new PermanentEmployee(1, "Raju");
            Employee partTime = new PartTimeEmployee(2, "Sanju");
            Employee contract = new ContractEmployee(2, "Sanju");

            Console.WriteLine("{0}; Bonus is {1};", fullTime.ToString(), fullTime.CalculateBonus(1000));
            Console.WriteLine("{0}; Bonus is {1};", partTime.ToString(), partTime.CalculateBonus(1000));
            Console.WriteLine("{0}; Bonus is {1};", contract.ToString(), contract.CalculateBonus(1000));
            Console.ReadLine();
        }
    }
}
