using System;
using Epam.Fly;
using Epam.Fly.Aircrafts;
using static System.Console;

namespace Epam
{
    class Program
    {
        public static void Main()
        {
            WriteLine(Convert.ConvertTensToN(10, 16));
            WriteLine(Convert.ConvertTensToN(16, 16));
            WriteLine(Convert.ConvertTensToN(123, 13));
            WriteLine(Convert.ConvertTensToN(118, 18));
            WriteLine(Convert.ConvertTensToN(10, 2));
            WriteLine(Convert.ConvertTensToN(10, 12));

            WriteLine("Bird will fly for "+new Bird(0, 0, 0, new Random().Next(1,51)).GetFlyTime(new Coordinate(100, 100, 100))+" hours");
            WriteLine("Plane will fly for " + new Plane(0, 0, 0).GetFlyTime(new Coordinate(1000, 1000, 1000)) + " hours");
            WriteLine("Drone will fly for " + new Drone(0, 0, 0).GetFlyTime(new Coordinate(100, 100, 100)) + " hours");

            Collections.ToXml();

            Collections.Collection();

            ReadLine();
        }
    }
}
