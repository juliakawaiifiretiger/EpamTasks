using System;

namespace AbstractAndInterface
{
    public class Bird : IFlyable
    {
        public Coordinate StartPoint { get; set; }

        public Coordinate EndPoint { get; set; }

        public Bird(Coordinate startPoint, Coordinate endPoint)
        { 
            this.StartPoint = startPoint;

            // Restriction of bird flight along the axis Z up to 500 km.
            if (endPoint.Z > 500)
            {
                endPoint.Z = 500;  
            }

            this.EndPoint = endPoint;
        }

        public void FlyTo()
        {
            this.EndPoint.PrintEndCoordinateValeus();
        }

        public double GetFlyTime()
        {
            var time =Math.Round(this.GetDistance() / this.GetSpeed(), 2);
            Console.WriteLine($"Time {time} hours");

            return time;
        }

        public void GetCurrentPosition()
        {
            Console.WriteLine("Bird: ");
            this.StartPoint.PrintBeginCoordinateValues();
        }

        private int GetSpeed() => new Random().Next(0, 20);

        private double GetDistance() => Math.Sqrt(Math.Pow(EndPoint.X - StartPoint.X, 2) + 
            Math.Pow(EndPoint.Y - StartPoint.Y, 2) + Math.Pow(EndPoint.Z - StartPoint.X, 2));        
    }
}
