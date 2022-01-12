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

        public void ShowInfo()
        {
            Console.WriteLine("Vehicle type: {0}\n", type);
            Console.WriteLine($"Engine: " +
                $"\nPower: {engine.power}" +
                $"\nType: {engine.type}" +
                $"\nVolume: {engine.volume}" +
                $"\nSerial Number: {engine.serialNumber}");
            Console.WriteLine($"\nChassis: " +
                $"\nCount: {chassis.count}" +
                $"\nNumber: {chassis.number}" +
                $"\nMax weight: {chassis.max}");
            Console.WriteLine($"\nTransmission: " +
              $"\nType: {transmission.type}" +
              $"\nCount: {transmission.count}" +
              $"\nCreator: {transmission.creator}");
        }

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
