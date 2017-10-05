using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
     class AirTrafficController
    {

        public void send(Plane from, String to, String message)
         {

             try
             {
                 planes[to].receive(message);
             }
             catch (KeyNotFoundException)
             {
                 Console.WriteLine("Unable to find a matching plane, please check the destination plane");
             }
         }

        protected Dictionary<String, Plane> planes = new Dictionary<String, Plane>();  

        public void addToPlaneList(String name, Plane plane)
        {
            planes.Add(name, plane);
        }
    }
}
