using System;

namespace OopTask
{
    public class Bus : Transport
    {
        public int NumberOfSeats { get; set; }

        public Bus(Engine engine, Сhassis сhassis, Transmission transmission, int numberOfSeats) : base(engine, сhassis, transmission)
        {

            if (numberOfSeats < 1) 
            { 
                this.NumberOfSeats = 1;
                Console.WriteLine("Can't be < 0");
            }
            else
            {
                this.NumberOfSeats = numberOfSeats;
            }
        }

        public override void PrintTransportValues()
        {
            Console.WriteLine("Bus: ");
            base.PrintTransportValues();
            Console.WriteLine($"Number of seats: {this.NumberOfSeats}");
        }
    }
}
