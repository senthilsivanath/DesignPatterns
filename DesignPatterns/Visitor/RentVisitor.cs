using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class RentVisitor : IVisitor
    {
        public void Visit(Elements.IEmployee employee)
        {
            Console.WriteLine("In rent visitor for " + employee.GetType().Name);
        }
    }
}
