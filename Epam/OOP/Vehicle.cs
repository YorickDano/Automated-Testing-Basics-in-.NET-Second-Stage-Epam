using Epam.OOP;
using System;

namespace Epam
{
    public class Vehicle
    {
        public Type type;
        public Engine engine;
        public Chassis chassis;
        public Transmission transmission;

        public void ShowEngineInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Engine: " +
                $"\nType: {engine.type}" +
                $"\nVolume: {engine.volume}" +
                $"\nSerial Number: {engine.serialNumber}");
            Console.WriteLine();
        }
    }
}
