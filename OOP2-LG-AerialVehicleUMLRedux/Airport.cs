using System;
using System.Collections.Generic;
using System.Text;

namespace LGSprint0UML
{
    class Airport
    {
        protected int MaxVehicles;
        private List<AerialVehicle> Vehicles;

        public string AirportCode;

        public Airport(string code)
        {
            this.AirportCode = code;
            this.MaxVehicles = 10;
            this.Vehicles = new List<AerialVehicle>();
        }

        public Airport(string code, int maxVehicles)
        {
            this.AirportCode = code;
            this.MaxVehicles = maxVehicles;
            this.Vehicles = new List<AerialVehicle>();
        }

        public string TakeOff(AerialVehicle a)
        {
            string takeOffStr = "";

            if (this.Vehicles.Contains(a))
            {
                a.TakeOff(); // a.Engine must be started or this will fail

                if (a.IsFlying)
                {
                    this.Vehicles.Remove(a);
                    takeOffStr = "Vehicle " + a + " has taken off from airport " + AirportCode;
                }
                else
                {
                    takeOffStr = "Vehicle " + a + " could not take off and remains at airport " + AirportCode;
                }
            }
            else
            {
                takeOffStr = "Error: Vehicle " + a + " is not currently at airport " + AirportCode;
            }

            return takeOffStr;
        }

        public string AllTakeOff()
        {
            string takeOffStr = "";
            int tempVehicleCount = this.Vehicles.Count;

            for (int i = 0; i < tempVehicleCount; i++)
            {
                takeOffStr += TakeOff(this.Vehicles[0]) + "\n";
            }

            return takeOffStr;
        }

        public string Land(AerialVehicle a)
        {
            string landStr = "";

            if (Vehicles.Count < MaxVehicles)
            {
                Vehicles.Add(a);
                a.FlyDown(a.CurrentAltitude); // Automatically sets IsFlying to false
                a.StopEngine();
                landStr = "Aerial Vehicle " + a + " has landed at airport " + AirportCode;
            }
            else
            {
                landStr = "Aerial Vehicle " + a + " could not land at airport " + AirportCode + ": airport is full";
            }

            return landStr;
        }

        public string Land(List<AerialVehicle> landing)
        {
            string landStr = "";

            if (Vehicles.Count + landing.Count <= MaxVehicles)
            {
                Vehicles.AddRange(landing);
                foreach (AerialVehicle a in landing)
                {
                    a.FlyDown(a.CurrentAltitude); // Automatically sets IsFlying to false
                    a.StopEngine();
                    landStr += "Aerial Vehicle " + a + " has landed at airport " + AirportCode + "\n";
                }
            }
            else
            {
                landStr = "The vehicles could not all land at airport" + AirportCode + ": not enough space.\n" +
                          "You may only land " + (MaxVehicles - Vehicles.Count) + "or fewer vehicles here.";
            }

            return landStr;
        }
    }
}
