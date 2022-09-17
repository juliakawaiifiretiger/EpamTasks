using System;

namespace AbstractAndInterface
{
    public class ExecuteFourthTask
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird(new Coordinate(0, 0, 0), new Coordinate(30, 10, 100));
            bird.GetCurrentPosition();
            bird.FlyTo();
            bird.GetFlyTime();

            Airplane airplane = new Airplane(new Coordinate(0, 0, 0), new Coordinate(700, 110, 150));
            airplane.GetCurrentPosition();
            airplane.FlyTo();
            airplane.GetFlyTime();
           
            Drone drone = new Drone(new Coordinate(0, 0, 0), new Coordinate(50, 200, 500));
            drone.GetCurrentPosition();
            drone.FlyTo();
            drone.GetFlyTime();
            
            Console.ReadKey();
        }
    }
}
