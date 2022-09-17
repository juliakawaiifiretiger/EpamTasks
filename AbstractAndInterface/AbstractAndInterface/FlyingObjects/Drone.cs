using System;

namespace AbstractAndInterface
{
    public class Drone : IFlyable
    {
        public Coordinate StartPoint { get; set; }

        public Coordinate EndPoint { get; set; }

        public Drone(Coordinate startPoint, Coordinate endPoint)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }

        public void GetCurrentPosition()
        {
            Console.WriteLine("Drone: ");
            this.StartPoint.PrintBeginCoordinateValues();
        }

        public void FlyTo()
        {
            this.EndPoint.PrintEndCoordinateValeus();
        }

        public double GetFlyTime()
        {
            var timeInMotion = this.GetDistance() / this.GetSpeed();
            double stopTime = Convert.ToInt32(timeInMotion / 0.16) * 0.016;
            var time = Math.Round(timeInMotion + stopTime, 2);
            Console.WriteLine($"Time {time} hours");

            return time;
        }

        private double GetDistance()
        {
            double distance = Math.Sqrt(Math.Pow(EndPoint.X - StartPoint.X, 2) +
                Math.Pow(EndPoint.Y - StartPoint.Y, 2) + Math.Pow(EndPoint.Z - StartPoint.X, 2));

            // Drone distance limit up to 1000 km.
            if (distance > 1000)
            {
                distance = 1000;
            } 

            return distance;
        }

        private int GetSpeed() => new Random().Next(0, 250);
    }
}
