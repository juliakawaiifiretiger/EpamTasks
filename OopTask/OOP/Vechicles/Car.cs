using System;

namespace OopTask
{
    public class Car : Transport
    {
        public string Model { get; set; }

        public Car(Engine engine, Сhassis сhassis, Transmission transmission, string model) : base(engine, сhassis, transmission)
        {
            this.Model = model;
        }

        public override void PrintTransportValues()
        {
            Console.WriteLine("Car: ");
            base.PrintTransportValues();
            Console.WriteLine($"Model: {this.Model}");
        }
    }  
}
