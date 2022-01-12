using System;

namespace Epam.Fly
{
    struct Coordinate
    {
        private int X;
        public int x
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("X Cannot be negative");
                    X = 0;
                }
                else
                {
                    X = value;
                }
            }

            get => X;
        }

        private int Y;
        public int y
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Y Cannot be negative");
                    Y = 0;
                }
                else
                {
                    Y = value;
                }
            }

            get => Y;
        }
        private int Z;
        public int z
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Z Cannot be negative");
                    Z = 0;
                }
                else
                {
                    Z = value;
                }
            }

            get => Z;
        }

        public static bool operator ==(Coordinate coordinate1 ,Coordinate coordinate2)
        {
            return coordinate1.x == coordinate2.x && coordinate1.y == coordinate2.y && coordinate1.z == coordinate2.z;
        }

        public static bool operator !=(Coordinate coordinate1, Coordinate coordinate2)
        {
            return !(coordinate1 == coordinate2);
        }

        public Coordinate(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
