using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            AirTrafficController airTrafficController = new AirTrafficController();
            airTrafficController.addToPlaneList("Boeing1", new Boeing(airTrafficController));
            airTrafficController.addToPlaneList("Airbus1", new Airbus(airTrafficController));
            airTrafficController.send(null, "Boeing1", "Hey");
            airTrafficController.send(null, "Airbus1", "Hey");
        }
    }
}
