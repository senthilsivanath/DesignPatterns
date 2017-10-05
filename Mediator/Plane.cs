using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    abstract class Plane
    {

        protected AirTrafficController controller;

        public Plane(AirTrafficController controller)
        {
            this.controller = controller;
        }

        public abstract void receive(String message);

        public void sendMessage(String to, String message)
        {
            controller.send(this, to, message);
        }
    }
}
