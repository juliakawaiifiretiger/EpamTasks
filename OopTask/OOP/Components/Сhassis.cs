using System;

namespace OopTask
{
    public class Сhassis
    {
        public int NumberWheels { get; set; }

        public string ChassisNumber { get; set; }

        public int AdmissibleLoad { get; set; }

        public Сhassis(int numberWheels, string chassisNumber, int admissibleLoad)
        {

            if (numberWheels < 1)
            {
                this.NumberWheels = 1;
                Console.WriteLine("Can't be < 0");
            }
            else
            {
                this.NumberWheels = numberWheels;
            } 

            this.ChassisNumber = chassisNumber;

            if (admissibleLoad < 1)
            {
                this.AdmissibleLoad = 1;
                Console.WriteLine("Can't be < 0");
            }
            else
            {
                this.AdmissibleLoad = admissibleLoad;
            }
        }

        public void PrintChassisValues() => Console.WriteLine($"Number of Wheels: {this.NumberWheels}, number: {this.ChassisNumber}, admissible load: {this.AdmissibleLoad}");
    }  
}

