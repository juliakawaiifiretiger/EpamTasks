using System;

namespace OopTask
{
    public class Transmission
    {
        public int NumberOfGears { get; set; }

        public string Producer { get; set; }

        public TransmissionType Type { get; set; }

        public Transmission(int numberOfGears, string producer, TransmissionType type)
        {

            if (numberOfGears < 1)
            {
                this.NumberOfGears = 1;
                Console.WriteLine("Can't be < 0");
            }
            else
            {
                this.NumberOfGears = numberOfGears;
            }

            this.Producer = producer;
            this.Type = type;
        }
        public void PrintTransmissionValues() => Console.WriteLine($"Number of gears: {this.NumberOfGears}, producer: {this.Producer}, transmission type: {this.Type}");
    }
}
