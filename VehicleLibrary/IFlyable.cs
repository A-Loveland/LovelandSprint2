using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary
{
    public interface IFlyable
    {
        string About();
        void FlyDown();
        void FlyUp();
        void StartEngine();
        void StopEngine();
        string TakeOff();
    }
}
