using VehicleLibrary;

namespace BuildingLibrary
{
    public class Airport : IDockable
    {
        public int MaxVehicles;
        public List<AerialVehicle> Vehicles;
        public string AirportCode { get; protected set; }

        public Airport(string Code) : this(Code, 6)
        {
            // Defaults to 6 vehicles
        }
        public Airport(string Code, int maxVehicles)
        {
            AirportCode = Code;
            MaxVehicles = maxVehicles;
        }

        public string AllTakeOff()
        {
            foreach (var vehicle in Vehicles)
            {
                vehicle.TakeOff();
            }
            return "All vehicles have taken off!";
        }

        public string Land(AerialVehicle a)
        {
            a.CurrentAltitude = 0;
            return $"{a.Name} has landed!";
        }

        public string Land(List<AerialVehicle> landingVehicles)
        {
            string landedString = "";
            foreach (var vehicle in landingVehicles)
            {
                vehicle.CurrentAltitude = 0;
                landedString = $"{vehicle.Name}, ";
            }
            landedString = landedString + "have landed!";
            return landedString;
        }

        public string TakeOff(AerialVehicle a)
        {
            a.TakeOff();
            return $"{a.Name} has landed!";
        }
    }
}
