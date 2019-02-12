using System;

namespace LGSprint0UML
{
    class Program
    {
        static void Main()
        {
            #region Sprint 0 Testing
            ColorMagenta();
            Console.WriteLine("Luke Goldfain - Flying Vehicle Tester");
            Console.WriteLine("Airplane.cs");
            ColorWhite();

            Airplane ap = new Airplane();

            Console.WriteLine(ap.About());

            ColorMagenta();
            Console.WriteLine("---Airplane Takeoff---");
            Console.WriteLine("Calling ap.TakeOff");
            ColorWhite();

            Console.WriteLine(ap.TakeOff());

            ColorMagenta();
            Console.WriteLine("Calling Engine.Start() then ap.TakeOff()");
            ColorWhite();

            ap.StartEngine();
            Console.WriteLine(ap.TakeOff());

            ColorMagenta();
            Console.WriteLine("---Airplane fly up---");
            Console.WriteLine("Calling ap.FlyUp() to fly up 1000 ft");
            ColorWhite();

            ap.FlyUp();
            Console.WriteLine(ap.About());

            ColorMagenta();
            Console.WriteLine("Calling ap.FlyUp(44000) to fly up to 45000 ft");
            ColorWhite();

            ap.FlyUp(44000);
            Console.WriteLine(ap.About());

            ColorMagenta();
            Console.WriteLine("Calling ap.FlyUp(45000) to fly up to 90000 ft");
            ColorWhite();

            ap.FlyUp(45000);
            Console.WriteLine(ap.About());

            ColorMagenta();
            Console.WriteLine("---Airplane fly down---");
            Console.WriteLine("Calling ap.FlyDown(50000) to fly down 50000 ft (invalid amount)");
            ColorWhite();

            ap.FlyDown(50000);
            Console.WriteLine(ap.About());

            ColorMagenta();
            Console.WriteLine("Calling ap.FlyDown(ap.CurrentAltitude) to fly down and land");
            ColorWhite();

            ap.FlyDown(ap.CurrentAltitude);
            Console.WriteLine(ap.About());
            #endregion

            #region Sprint 1 Testing (Airport)
            ColorMagenta();
            Console.WriteLine("---Airport Creation---");
            Console.WriteLine("Creating a new Airport and populating its AerialVehicle list");
            ColorWhite();

            Airport airport = new Airport("JEF", 3); // Jeff Meyers Airport JEF ;)
            Drone d = new Drone();
            Helicopter h = new Helicopter();
            Console.WriteLine(airport.Land(ap));
            Console.WriteLine(airport.Land(d));
            Console.WriteLine(airport.Land(h));

            ColorMagenta();
            Console.WriteLine("Attempting to add a fourth vehicle to the Airport (will fail as airport.MaxVehicles == 3)");
            ColorWhite();

            // Attempt to add a fourth vehicle (will fail)
            ToyPlane tp = new ToyPlane();
            Console.WriteLine(airport.Land(tp));

            ColorMagenta();
            Console.WriteLine("Calling Airport.TakeOff(AerialVehicle) to take off the helicopter, then the toy plane may land");
            ColorWhite();

            h.StartEngine();
            Console.WriteLine(airport.TakeOff(h));
            Console.WriteLine(airport.Land(tp));

            ColorMagenta();
            Console.WriteLine("Starting engines and calling Airport.AllTakeOff() to take off all of the vehicles");
            ColorWhite();

            ap.StartEngine();
            d.StartEngine();
            h.StartEngine();
            tp.WindUp();
            tp.StartEngine();
            Console.WriteLine(airport.AllTakeOff());

            #endregion

            Console.ReadKey();
        }

        static void ColorMagenta()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }

        static void ColorWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
