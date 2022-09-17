using System;

namespace OopTask
{
    public class Truck : Transport
    {
        public bool IsLoaded { get; set; }

        public Truck(Engine engine, Сhassis сhassis, Transmission transmission, bool isLoaded) : base(engine, сhassis, transmission)
        {
            this.IsLoaded = isLoaded;
        }

        public override void PrintTransportValues()
        {
            Console.WriteLine("Truck: ");
            base.PrintTransportValues();
            Console.WriteLine($"Load: {this.IsLoaded}");
        }
    }
}
