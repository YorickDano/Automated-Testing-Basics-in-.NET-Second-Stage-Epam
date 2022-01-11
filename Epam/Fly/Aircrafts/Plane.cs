using System;

namespace Epam.Fly.Aircrafts
{
    class Plane : IFlyable
    {
        Coordinate CurrentCoordinate;

        public Plane(Coordinate currentCoordinate)
        {
            this.CurrentCoordinate = currentCoordinate;
        }

        public Plane(int x, int y, int z)
        {
            CurrentCoordinate.x = x;
            CurrentCoordinate.y = y;
            CurrentCoordinate.z = z;
        }

        public int GetLength(Coordinate next) =>
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
            int length = GetLength(coordinate);

            int speed = 200 + Convert.ToInt32((length.ToString().Remove(length.ToString().Length - 1) + "0"));

            if (speed > 1000)
            {
                speed = 1000; // Ограничение по скорости самолёта
            }

            return length / speed;
        }

    }
}
