// ToyPlane.cs
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

        public void StartEngine()
        {

        }

        new public string TakeOff()
        {
            string takeOffStr = "";

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
