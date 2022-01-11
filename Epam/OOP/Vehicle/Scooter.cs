using System;

namespace Epam.OOP.Cars
{
    public class Scooter : Vehicle
    {
        private int _CarryingCapacity;
        public int CarryingCapacity
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Carrying capacity cannot be negative");
                    _CarryingCapacity = 0;
                }
                else
                {
                    _CarryingCapacity = value;
                }
            }
            get => _CarryingCapacity;
        }

        public Scooter()
        {
            type = Type.Scooter;
            engine = new Engine();
            chassis = new Chassis();
            transmission = new Transmission(); 
        }

        public Scooter(int CarryingCapacity)
        {
            type = Type.Scooter;
            engine = new Engine();
            chassis = new Chassis();
            transmission = new Transmission();
            this.CarryingCapacity = CarryingCapacity;
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
            Console.WriteLine($"\nCarrying сapacity of this scooter is {CarryingCapacity}");
        }
    }
}
