using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Airbus : Plane
    {

        public Airbus(AirTrafficController airTrafficController)
            : base(airTrafficController)
        {
           
        }
        public override void receive(string message)
        {
            Console.WriteLine("Receieved in Airbus " + message);
        }
    }
}
