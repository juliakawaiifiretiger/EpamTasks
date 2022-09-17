using System;

namespace AbstractAndInterface
{
    public struct Coordinate 
    {
        public uint X, Y, Z;

        public Coordinate(uint x, uint y, uint z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public void PrintBeginCoordinateValues() => Console.WriteLine($"Current posotion {X}, {Y}, {Z}");

        public void PrintEndCoordinateValeus() => Console.WriteLine($"End position {X},{Y},{Z}");
    }
}
