﻿using static System.Console;
using VehicleLibrary;

namespace LovelandSprint1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester t = new Tester();
            t.Test();
        }

        class Tester
        {
            public void Test()
            {
                WriteLine("Flying Vehicle Tester......................................................");
                WriteLine("\nAirlplane.cs...............................................................");

                /*
                 * Airplane class tests
                 * many of the airplane class methods return a string we will write these to the console for testing
                 */
                Airplane ap = new Airplane();
                //Air plane should inherit from AerialVehicle
                WriteLine(ap.About());
                /* Output AirplaneAbout:
                 * This OOPFlyingVehicle.Airplane has a max altitude of 41000 ft.
                 * It's current altitude is 0 ft.
                 * OOPFlyingVehicleMidterm.Airplane engine is not started
                 */

                WriteLine("\nAireplaneTakeOffTests...............................................................");
                WriteLine("\nCall ap.TakeOff():");
                //Test take off should fail engine isn't started
                WriteLine(ap.TakeOff());  //Don't take off engine isn't started
                /* Output:
                 * OOPFlyingVehicleMidterm.Airplane can't fly it's engine is not started.
                 */
                WriteLine("\nCall ap.StartEngine():");
                ap.StartEngine();
                WriteLine(ap.TakeOff());  //take off engine is started
                /* Output:
                 * OOPFlyingVehicleMidterm.Airplane is flying
                 */

                //Fly up
                WriteLine("\nFly up Tests...................................................................");
                WriteLine("Call ap.FlyUp() fly to 1,000ft default");
                ap.FlyUp();    //Fly up tp 1,000 ft
                WriteLine(ap.About());
                WriteLine("\nCall ap.FlyUp(44000) Fly up to 45,000ft shouldn't work:");
                ap.FlyUp(44000);    //Fly up tp 45,000 ft shouldn't work
                WriteLine(ap.About());
                WriteLine("\nCall ap.FlyUp(40000) Fly up another 40,000ft:");
                ap.FlyUp(40000);    //Fly up tp 41,000 ft shouldn't work
                WriteLine(ap.About());
                /*
                 * Output:
                 */

                //Land
                WriteLine("\nFly Down.................................................................");
                WriteLine("Call ap.FlyDown(50000) Fly Down 50,000 ft");
                ap.FlyDown(50000);   //Land by floying down 50,000 ft = Crash and shouldn't work
                WriteLine(ap.About());
                WriteLine("Call ap.FlyDown(ap.CurrentAltitude) this should land");
                ap.FlyDown(ap.CurrentAltitude); //Land by flying down current altitiute
                WriteLine(ap.About());
            }
        }
    }
}
