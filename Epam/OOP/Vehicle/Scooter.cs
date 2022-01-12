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
            base.ShowInfo();
            Console.WriteLine($"\nCarrying сapacity of this scooter is {CarryingCapacity}");
        }
    }
}
