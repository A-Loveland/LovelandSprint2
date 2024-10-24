using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingLibrary
{
    public interface IDockable
    {
        string AllTakeOff();
        string Land();
        string TakeOff();
    }
}
