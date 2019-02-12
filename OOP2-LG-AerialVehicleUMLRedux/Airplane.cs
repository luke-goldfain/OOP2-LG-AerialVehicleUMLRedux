// Airplane.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace LGSprint0UML
{
    public class Airplane : AerialVehicle
    {
        public Airplane()
        {
            this.defaultFlyHeight = 1000;
            this.MaxAltitude = 41000;
        }
    }
}
