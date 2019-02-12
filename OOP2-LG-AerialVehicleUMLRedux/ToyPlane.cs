using System;
using System.Collections.Generic;
using System.Text;

namespace LGSprint0UML
{
    class ToyPlane : Airplane
    {
        private bool isWoundUp;

        public ToyPlane()
        {
            this.defaultFlyHeight = 10;
            this.MaxAltitude = 50;
            this.isWoundUp = false;
        }

        private string getWindUpString()
        {
            string woundUpStr = "";

            if (isWoundUp)
            {
                woundUpStr = this + "is wound up";
            }
            else
            {
                woundUpStr = this + "is not wound up";
            }

            return woundUpStr;
        }

        public override void StartEngine()
        {
            if (isWoundUp) this.Engine.Start();
        }

        public override string TakeOff()
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

        public void Unwind()
        {
            isWoundUp = false;
        }

        public void WindUp()
        {
            isWoundUp = true;
        }
    }
}
