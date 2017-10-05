using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Boeing : Plane
    {
        public Boeing(AirTrafficController airTrafficController) : base(airTrafficController)
        {
           
        }
        public override void receive(string message)
        {
            Console.WriteLine("Received in boeing" + message);
        }
    }
}
