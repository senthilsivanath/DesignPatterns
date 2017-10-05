using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Elements.IEmployee employee)
        {
            Console.WriteLine("In income visitor for " + employee.GetType().Name);
        }
    }
}
