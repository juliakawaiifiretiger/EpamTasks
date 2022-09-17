using System;

namespace AbstractAndInterface
{
    public class Airplane : IFlyable
    {
        public Coordinate StartPosition { get; set; }

        public Coordinate EndPosition { get; set; }

        public Airplane(Coordinate startPosition, Coordinate endPosition)
        {
            this.StartPosition = startPosition;
            this.EndPosition = endPosition;
        }

        public void GetCurrentPosition()
        {
            Console.WriteLine("Airplane: ");
            this.StartPosition.PrintBeginCoordinateValues();
        }

        public void FlyTo()
        {
            this.EndPosition.PrintEndCoordinateValeus();
        }

        public double GetFlyTime()
        {
            var time = Math.Round(2 * this.GetDistance() / (this.GetSpeed() + 200), 2);
            Console.WriteLine($"Time {time} hours");

            return time;
        }

        private double GetSpeed()
        {
            var speed = Math.Round(this.GetDistance() + 200, MidpointRounding.AwayFromZero);

            // Airplane speed limit up to 1000 km/h.
            if (speed > 1000)
            {
                speed = 1000;
            }

            return speed;
        }

        private double GetDistance() => Math.Sqrt(Math.Pow(EndPosition.X - StartPosition.X, 2) + Math.Pow(EndPosition.Y - StartPosition.Y, 2) + Math.Pow(EndPosition.Z - StartPosition.X, 2));
    }
}
