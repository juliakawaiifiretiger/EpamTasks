using System;

namespace OopTask
{
    public class Scooter : Transport
    {
        public int MaxSpeed { get; set; }

        public Scooter(Engine engine, Сhassis сhassis, Transmission transmission, int maxSpeed) : base(engine, сhassis, transmission)
        {
            if (maxSpeed < 1)
            {
                this.MaxSpeed = 1;
                Console.WriteLine("Can't be < 0");
            }
            else if (maxSpeed > 200)
            {
                this.MaxSpeed = 200;
                Console.WriteLine("Can't be > 200");
            }
            else
            {
                this.MaxSpeed = maxSpeed;
            } 
        }

        public override void PrintTransportValues()
        {
            Console.WriteLine("Scooter: ");
            base.PrintTransportValues();
            Console.WriteLine($"Max speed: {this.MaxSpeed}");
        }
    }
}
