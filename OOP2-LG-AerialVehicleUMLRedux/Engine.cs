// Engine.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace LGSprint0UML
{
    public class Engine
    {
        public bool IsStarted = false;

        public Engine()
        {

        }

        public string About()
        {
            string aboutStr = "";

            return aboutStr;
        }

        public void Start()
        {
            this.IsStarted = true;
        }

        public void Stop()
        {
            this.IsStarted = false;
        }
    }
}