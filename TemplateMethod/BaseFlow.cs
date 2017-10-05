using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class BaseFlow
    {
        public void Process()
        {
            this.Start();
            this.Execute();
            this.End();
        }

        protected void Start()
        {
            Console.WriteLine("in Start");
        }

        protected abstract void Execute();

        protected void End(){
            Console.WriteLine("in End");
        }

    }
}
