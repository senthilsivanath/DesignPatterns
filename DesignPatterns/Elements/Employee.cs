using DesignPatterns.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Elements
{
    public class Employee : IEmployee
    {
        public string Name
        {
            get;
            set;
        }

        public int Salary
        {
            get;
            set;
        }

        private List<IEmployee> mEmployees = new List<IEmployee>();

        public void accept(IEmployee employee)
        {
            this.mEmployees.Add(employee);
        }

        public void remove(IEmployee employee)
        {
            this.mEmployees.Remove(employee);
        }

        void IEmployee.Visit(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Process(IVisitor visitor)
        {
            foreach (var employee in mEmployees)
            {
                employee.Visit(visitor);
            }
        }


       
    }
}
