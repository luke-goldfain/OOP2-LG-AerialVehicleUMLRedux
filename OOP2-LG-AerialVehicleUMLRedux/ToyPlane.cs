// ToyPlane.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace LGSprint0UML
{
    public class ToyPlane : Airplane
    {
        public bool IsWoundUp;

        public ToyPlane()
        {
            this.defaultFlyHeight = 10;
            this.MaxAltitude = 50;
            this.IsWoundUp = false;
        }

        private string getWindUpString()
        {
            string woundUpStr = "";

            if (IsWoundUp)
            {
                woundUpStr = this + "is wound up";
            }
            else
            {
                woundUpStr = this + "is not wound up";
            }

            return woundUpStr;
        }

        public void StartEngine()
        {
            if (IsWoundUp) this.Engine.Start();
        }
        
        public override string TakeOff()
        {
            string takeOffStr = "";

            if (!this.IsWoundUp)
            {
                takeOffStr = "Could not take off - " + this + " not wound up";
            }
            else if (!this.Engine.IsStarted)
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

        public void Unwind()
        {
            IsWoundUp = false;
        }

        public void WindUp()
        {
            IsWoundUp = true;
        }
    }
}
