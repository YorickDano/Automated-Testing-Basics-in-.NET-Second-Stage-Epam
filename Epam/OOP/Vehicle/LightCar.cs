using System;

namespace Epam.OOP.Cars
{
    public class LightCar : Vehicle
    {
        private int _price;
        public int price
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Price cannot be negative");
                    _price = 0;
                }
                else
                {
                    _price = value;
                }
            }
            get => _price;
        }

        public LightCar()
        {
            type = Type.LightCar;
            engine = new Engine();
            chassis = new Chassis();
            transmission = new Transmission();
        }

        public LightCar(int price)
        {
            type = Type.LightCar;
            engine = new Engine();
            chassis = new Chassis();
            transmission = new Transmission();
            this._price = price;
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
            Console.WriteLine($"\nPrise of this car is {price}");
        }
    }
}
