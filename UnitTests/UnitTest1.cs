using BuildingLibrary;
using VehicleLibrary;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        Airplane airplane = new Airplane();
        Drone drone = new Drone();
        ToyPlane toyPlane = new ToyPlane();
        Helicopter helicopter = new Helicopter();

        [TestMethod]
        [ExpectedException(typeof(MissingMethodException), "Aerial Vehicle should be abstract.")]
        public void TestVehicleAbstract_Throws()
        {
            var ae = Activator.CreateInstance<AerialVehicle>(); // Will throw
        }

        [TestMethod]
        public void TestAerialVehicleEngineStart()
        {
            // Arrange
            List<AerialVehicle> testVehicles = new List<AerialVehicle>() { airplane, drone, toyPlane, helicopter };
            
            foreach (AerialVehicle vehicle in testVehicles)
            {
                // Act
                vehicle.StartEngine();

                // Assert
                Assert.IsTrue(vehicle.VehicleEngine.IsStarted);
            }
        }

        [TestMethod]
        public void TestAerialVehicleEngineStop()
        {
            List<AerialVehicle> testVehicles = new List<AerialVehicle>() { airplane, drone, toyPlane, helicopter };

            foreach (AerialVehicle vehicle in testVehicles)
            {
                vehicle.StartEngine();
                vehicle.StopEngine();

                Assert.IsFalse(vehicle.VehicleEngine.IsStarted);
            }
        }

        [TestMethod]
        public void TestAerialVehicleTakeOff()
        {
            List<AerialVehicle> testVehicles = new List<AerialVehicle>() { airplane, drone, toyPlane, helicopter };
            
            foreach (AerialVehicle vehicle in testVehicles)
            {
                vehicle.StartEngine();
                vehicle.TakeOff();

                Assert.IsTrue(vehicle.IsFlying);
            }
        }

        [TestMethod]
        public void TestAerialVehicleFlyUp()
        {
            List<AerialVehicle> testVehicles = new List<AerialVehicle>() { airplane, drone, toyPlane, helicopter };
            int origVehicleAltitude;
            int newVehicleAltitude;

            foreach (AerialVehicle vehicle in testVehicles)
            {
                origVehicleAltitude = vehicle.CurrentAltitude;

                vehicle.StartEngine();
                vehicle.TakeOff();
                vehicle.FlyUp();
                newVehicleAltitude = vehicle.CurrentAltitude;

                if (vehicle.MaxAltitude < 1000)
                {
                    Assert.AreEqual(newVehicleAltitude, origVehicleAltitude);
                }
                else
                {
                    Assert.AreEqual(newVehicleAltitude, origVehicleAltitude + 1000);
                }
            }
        }

        [TestMethod]
        public void TestAerialVehicleFlyUpAmount()
        {
            List<AerialVehicle> testVehicles = new List<AerialVehicle>() { airplane, drone, toyPlane, helicopter };
            int origVehicleAltitude;
            int newVehicleAltitude;

            foreach (AerialVehicle vehicle in testVehicles)
            {
                origVehicleAltitude = vehicle.CurrentAltitude;

                vehicle.StartEngine();
                vehicle.TakeOff();
                vehicle.FlyUp(50);
                newVehicleAltitude = vehicle.CurrentAltitude;

                Assert.AreEqual(newVehicleAltitude, origVehicleAltitude + 50);
            }
        }

        [TestMethod]
        public void TestAerialVehicleFlyDown()
        {
            List<AerialVehicle> testVehicles = new List<AerialVehicle>() { airplane, drone, toyPlane, helicopter };
            int origVehicleAltitude;
            int newVehicleAltitude;

            foreach (AerialVehicle vehicle in testVehicles)
            {
                origVehicleAltitude = vehicle.CurrentAltitude;

                vehicle.StartEngine();
                vehicle.TakeOff();
                vehicle.FlyUp();
                vehicle.FlyDown();
                newVehicleAltitude = vehicle.CurrentAltitude;

                Assert.AreEqual(newVehicleAltitude, origVehicleAltitude);
            }
        }

        [TestMethod]
        public void TestAerialVehicleFlyDownAmount()
        {
            List<AerialVehicle> testVehicles = new List<AerialVehicle>() { airplane, drone, toyPlane, helicopter };
            int origVehicleAltitude;
            int newVehicleAltitude;

            foreach (AerialVehicle vehicle in testVehicles)
            {
                origVehicleAltitude = vehicle.CurrentAltitude;

                vehicle.StartEngine();
                vehicle.TakeOff();
                vehicle.FlyUp(50);
                vehicle.FlyDown(40);
                newVehicleAltitude = vehicle.CurrentAltitude;

                Assert.AreEqual(newVehicleAltitude, origVehicleAltitude + 10);
            }
        }

        [TestMethod]
        public void TestAerialVehicleLand()
        {
            List<AerialVehicle> testVehicles = new List<AerialVehicle>() { airplane, drone, toyPlane, helicopter };
            int origVehicleAltitude;
            int newVehicleAltitude;

            foreach (AerialVehicle vehicle in testVehicles)
            {
                vehicle.StartEngine();
                vehicle.TakeOff();
                vehicle.FlyUp();
                vehicle.FlyDown();

                Assert.IsFalse(vehicle.IsFlying);
            }
        }

        [TestMethod]
        public void TestAirportCode()
        {
            Airport airport = new Airport("ORD");
            string airportCode = airport.AirportCode;
            Assert.AreEqual(airport.AirportCode, airportCode);
        }

        [TestMethod]
        public void TestAirportTakeOff()
        {
            Airport airport = new Airport("ORD");
        }
    }
}