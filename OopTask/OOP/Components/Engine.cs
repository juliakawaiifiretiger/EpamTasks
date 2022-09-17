using System;

namespace OopTask
{
    public class Engine
    {
        public int Power { get; set; }

        public float Volume { get; set; }

        public string SerialNumber { get; set; }

        public EngineType Type { get; set; }

        public Engine(int power, float volume, string serialNumber, EngineType type)
        {

            if (power < 1)
            {
                this.Power = 1;
                Console.WriteLine("Can't be < 0");
            }
            else if (power > 5000)
            {
                this.Power = 5000;
                Console.WriteLine("Can't be > 5000");
            }
            else
            {
                this.Power = power;
            } 

            if (volume < 1)
            {
                this.Volume = 1;
                Console.WriteLine("Can't be < 0");
            }
            else if (volume > 50)
            {
                this.Volume = 50;
                Console.WriteLine("Can't be > 50");
            }
            else
            {
                this.Volume = volume;
            } 

            this.SerialNumber = serialNumber;
            this.Type = type;
        }

        public void PrintEngineValues() => Console.WriteLine($"Engine power: {this.Power}, volume: {this.Volume}, serial number: {this.SerialNumber}, engine type: {this.Type}");
    }
}
