using System;
using System.Collections.Generic;

namespace Epam
{
    public class Engine
    {
        Random rand = new Random();

        public double power;
        public double volume;
        public string type;
        public int serialNumber;

        List<string> randEngineType = new List<string>() { "Gas engine", "Steam engine", "Carburetor injection system", "Injector", "Diesel Engines", "Electric motors" };

        public Engine()
        {
            power = rand.Next(200, 1000);
            volume = rand.Next(0, 5) + rand.NextDouble();
            type = randEngineType[rand.Next(randEngineType.Count)];
            serialNumber = rand.Next(int.MaxValue);
        }

        public Engine(double power, double volume, string type, int serialNumber)
        {
            this.power = power;
            this.volume = volume;
            this.type = type;
            this.serialNumber = serialNumber;
        }
    }
}
