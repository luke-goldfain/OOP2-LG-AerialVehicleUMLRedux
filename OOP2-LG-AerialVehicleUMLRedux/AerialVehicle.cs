// AerialVehicle.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace LGSprint0UML
{
    public abstract class AerialVehicle
    {
        public int CurrentAltitude;
        public Engine Engine;
        public bool IsFlying;
        public int MaxAltitude;
        // Variable added to allow each inheritor to set their own fly height (airplane's is 1000)
        protected int defaultFlyHeight;

        public AerialVehicle()
        {
            this.IsFlying = false;

            this.CurrentAltitude = 0;

            this.defaultFlyHeight = 1000;

            this.Engine = new Engine();
        }

        public string About()
        {
            string aboutStr = "This " + this + " has a max altitude of " + this.MaxAltitude + " ft\n" +
                              "Its current altitude is " + CurrentAltitude + " ft\n" +
                              this + "'s engine is " + getEngineStartedString();

            return aboutStr;
        }

        public void FlyDown()
        {
            CurrentAltitude -= 1000;
            // force min altitude (0)
            CurrentAltitude = Math.Max(CurrentAltitude, 0);
        }

        public void FlyDown(int HowManyFeet)
        {
            if (CurrentAltitude - HowManyFeet >= 0)
            {
                CurrentAltitude -= HowManyFeet;
            }
        }

        public void FlyUp()
        {
            CurrentAltitude += 1000;
            // Force max altitude
            CurrentAltitude = Math.Min(CurrentAltitude, MaxAltitude);
        }

        public void FlyUp(int HowManyFeet)
        {
            CurrentAltitude += HowManyFeet;
            CurrentAltitude = Math.Min(CurrentAltitude, MaxAltitude);
        }

        private string getEngineStartedString()
        {
            string engineStartedStr = "";

            if (this.Engine.IsStarted)
            {
                engineStartedStr = "started";
            }
            else
            {
                engineStartedStr = "not started";
            }

            return engineStartedStr;
        }

        public void StartEngine()
        {
            this.Engine.Start();
        }

        public void StopEngine()
        {
            this.Engine.Stop();
        }

        public string TakeOff()
        {
            string takeOffStr = "";

            if (!this.Engine.IsStarted)
            {
                takeOffStr = "Could not take off - " + this + " engine not started";
            }
            else
            {
                CurrentAltitude = defaultFlyHeight;

                IsFlying = true;

                takeOffStr = this + " took off and is flying";
            }

            return takeOffStr;
        }
    }
}
