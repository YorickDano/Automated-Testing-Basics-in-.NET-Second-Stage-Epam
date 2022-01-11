using System;

namespace Epam.OOP.Cars
{
    public class Bus : Vehicle
    {
        private int _CountOfPassengers;
        public int CountOfPassengers
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Count of passengers cannot be negative");
                    _CountOfPassengers = 0;
                }
                else
                {
                    _CountOfPassengers = value;
                }
            }
            get => _CountOfPassengers;
        }

        public Bus()
        {
            type = Type.Bus;
            engine = new Engine();
            chassis = new Chassis();
            transmission = new Transmission();
        }

        public Bus(int CountOfPassengers)
        {
            type = Type.Bus;
            engine = new Engine();
            chassis = new Chassis();
            transmission = new Transmission();
            this._CountOfPassengers = CountOfPassengers;
        }

        public void ShowInfo()
        {
            Console.WriteLine();
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
            Console.WriteLine($"\nMax count of passengers of this bus is {CountOfPassengers}");
        }
    }
}
