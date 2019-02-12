using System;
using System.Collections.Generic;
using System.Text;

namespace LGSprint0UML
{
    class Drone : AerialVehicle
    {
        // The UML diagram omits this constructor. Are we expected to assign MaxAltitude another way?
        public Drone()
        {
            this.defaultFlyHeight = 50;
            this.MaxAltitude = 500;
        }
    }
}