using DesignPatterns.Elements;
using DesignPatterns.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Engineer engineer = new Engineer();
            engineer.Name = "Senthil";
            engineer.Salary = 10000;

            CEO ceo = new CEO();
            ceo.Name = "ABC";
            ceo.Salary = 100000;

            Employee employee = new Employee();
            employee.accept(engineer);
            employee.accept(ceo);

            IncomeVisitor incomeVisitor = new IncomeVisitor();
            employee.Process(incomeVisitor);

            RentVisitor rentVisitor = new RentVisitor();
            employee.Process(rentVisitor);
        }
    }
}
