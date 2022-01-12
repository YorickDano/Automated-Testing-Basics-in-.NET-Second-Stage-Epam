using System;

namespace Epam.Fly.Aircrafts
{
    class Bird : IFlyable
    {
        Coordinate CurrentCoordinate;

        private int Length;
        private int Speed;

        public Bird(Coordinate currentCoordinate)
        {
            this.CurrentCoordinate = currentCoordinate;
        }

        public Bird(Coordinate currentCoordinate, int speed)
        {
            this.CurrentCoordinate = currentCoordinate;
            Speed = speed;
        }

        public Bird(int x, int y, int z)
        {
            CurrentCoordinate.x = x;
            CurrentCoordinate.y = y;
            CurrentCoordinate.z = z;
        }

        public Bird(int x, int y, int z, int speed)
        {
            CurrentCoordinate.x = x;
            CurrentCoordinate.y = y;
            CurrentCoordinate.z = z;
            Speed = speed;
        }



        public int SetLength(Coordinate next) =>
                (int)Math.Sqrt(Math.Pow(next.x - CurrentCoordinate.x, 2)
                + Math.Pow(next.y - CurrentCoordinate.y, 2)
                + Math.Pow(next.z - CurrentCoordinate.z, 2));

        public void FlyTo(Coordinate next)
        {
            CurrentCoordinate.x = next.x;
            CurrentCoordinate.y = next.y;
            CurrentCoordinate.z = next.z;

            Console.WriteLine($"The flight will take: {GetFlyTime(next)} hours.");
        }

        public int GetFlyTime(Coordinate coordinate)
        {
            if (Length == 0 || coordinate != CurrentCoordinate)
            {
                Length = SetLength(coordinate);
            }

            return Length / Speed;
        }
    }
}
