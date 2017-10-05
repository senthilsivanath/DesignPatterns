using DesignPatterns.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Elements
{
    public interface IEmployee
    {
         String Name { get; set; }

         int Salary { get; set; }

         void Visit(IVisitor visitor);
     
    }
}
