using System;

namespace Epam.OOP
{
    public class Chassis
    {
        Random rand = new Random();

        public int count;
        public int number;
        public double max;

        public Chassis()
        {
            count = rand.Next(7);
            number = rand.Next(9);
            max = rand.Next(50, 10000) + rand.NextDouble();
        }

        public Chassis(int count, int number, double max)
        {
            this.count = count;
            this.number = number;
            this.max = max;
        }
    }
}
