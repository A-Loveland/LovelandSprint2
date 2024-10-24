using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary
{
    public abstract class AerialVehicle : IFlyable
    {
        public string Name { get; protected set; }

        protected int currentAltitude;
        public int CurrentAltitude
        { 
            get { return currentAltitude; }
            
            set { currentAltitude = value; }
        }

        public Engine VehicleEngine { get; protected set; }
        
        protected bool isFlying; //private instance data member
        public bool IsFlying
        {
            get { return isFlying; }

            set { isFlying = value; }
        }

        public int MaxAltitude { get; protected set; }

        public AerialVehicle()
        {
            VehicleEngine = new Engine();
            CurrentAltitude = 0;
            IsFlying = false;
        }

        public string About()
        {
            return $"This OOPFlyingVehicle.{Name} has a max altitude of {MaxAltitude} ft.\nIts current altitude is {CurrentAltitude} ft.\n{VehicleEngine.About()}";
        }

        public void FlyDown()
        {
            FlyDown(1000);
        }
        public void FlyDown(int Feet)
        {
            if (IsFlying && (CurrentAltitude - Feet) >= 0)
            {
                CurrentAltitude -= Feet;
            }
            else if (IsFlying)
            {
                CurrentAltitude = 0;
            }

            if (CurrentAltitude == 0)
            {
                IsFlying = false;
            }
        }
        public void FlyUp()
        {
            FlyUp(1000);
        }
        public void FlyUp(int Feet)
        {
            if (IsFlying && (CurrentAltitude + Feet) <= MaxAltitude)
            {
                CurrentAltitude += Feet;
            }
        }

        public void StartEngine()
        {
            VehicleEngine.Start();
        }

        public void StopEngine()
        {
            VehicleEngine.Stop();
        }

        public string TakeOff()
        {
            if (!VehicleEngine.IsStarted)
            {
                return $"OOPFlyingVehicle.{Name} can't fly, its engine is not started.";
            }
            else
            {
                IsFlying = true;
                return $"OOPFlyingVehicle.{Name} is flying.";
            }
        }
    }
}
