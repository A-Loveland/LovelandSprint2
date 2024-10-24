using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary
{
    public class ToyPlane : AerialVehicle
    {
        public bool isWoundUp = false;

        public ToyPlane() { Name = "Toy Plane"; MaxAltitude = 50; }

        public string About()
        {
            return $"This OOPFlyingVehicle.{Name} has a max altitude of {MaxAltitude} ft.\nIts current altitude is {CurrentAltitude} ft.\n{getWindUpString()}\n{VehicleEngine.About()}";
        }

        private string getWindUpString()
        {
            if (isWoundUp)
            {
                return "It is currently wound up.";
            }
            else
            {
                return "It is not currently wound up.";
            }
        }

        public void StartEngine()
        {
            if (isWoundUp)
            {
                VehicleEngine.Start();
            }
        }

        public string TakeOff()
        {
            if (!VehicleEngine.IsStarted)
            {
                return $"OOPFlyingVehicle.{Name} can't fly, its engine is not started. {getWindUpString()}";
            }
            else
            {
                IsFlying = true;
                return $"OOPFlyingVehicle.{Name} is flying.";
            }
        }

        public void WindUp()
        {
            isWoundUp = true;
        }

        public void UnWind()
        {
            isWoundUp = false;
        }
    }
}
