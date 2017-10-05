using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class FlowOne : BaseFlow
    {
        protected override void Execute()
        {
            Console.WriteLine("IN Flow one");
        }
    }
}
