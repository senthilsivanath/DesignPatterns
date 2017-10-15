using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckoutProcess process = new CheckoutProcess();
            process.checkout(new Order() { Prop1 = 10, Prop2 = 20 });
            process.getTotalAmount();
        }
    }
}
