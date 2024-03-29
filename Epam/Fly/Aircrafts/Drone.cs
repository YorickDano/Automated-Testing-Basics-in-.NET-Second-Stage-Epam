﻿using System;

namespace Epam.Fly.Aircrafts
{
    class Drone : IFlyable
    {
        Coordinate CurrentCoordinate;

        public Drone(Coordinate currentCoordinate)
        {
            this.CurrentCoordinate = currentCoordinate;
        }

        public Drone(int x, int y, int z)
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

            if (length > 1000)
            {
                Console.WriteLine("Too far...");
                throw new Exception("Too far");
            }

            int speed = new Random().Next(101);

            return (int)((length / speed) * 0.1 + (length / speed));
        }

    }
}
