using System;

namespace Epam.OOP.Cars
{
    public class HeavyCar : Vehicle
    {
        private int _weight;
        public int weight
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Weight cannot be negative");
                    _weight = 0;
                }
                else
                {
                    _weight = value;
                }
            }
            get => _weight;
        }

        public HeavyCar()
        {
            type = Type.HeavyCar;
            engine = new Engine();
            chassis = new Chassis();
            transmission = new Transmission();
        }

        public HeavyCar(int weight)
        {
            type = Type.HeavyCar;
            engine = new Engine();
            chassis = new Chassis();
            transmission = new Transmission();
            this._weight = weight;
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
            Console.WriteLine($"\nWeight of this truck is {weight}");
        }
    }
}
