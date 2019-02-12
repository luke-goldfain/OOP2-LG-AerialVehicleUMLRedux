// Program.cs
using System;

namespace LGSprint0UML
{
    class Program
    {
        static void Main()
        {
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
