using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary
{
    public class Engine
    {
        public bool IsStarted = false;

        public Engine() { }

        public string About()
        {
            if (IsStarted)
            {
                return "OOP.FlyingVehicle.Engine is started.";
            }
            else
            {
                return "OOP.FlyingVehicle.Engine is not started.";
            }
        }

        public void Start()
        {
            IsStarted = true;
        }

        public void Stop()
        {
            IsStarted = false;
        }
    }
}
