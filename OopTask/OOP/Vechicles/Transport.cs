using System;

namespace OopTask
{
   public class Transport
   {
        public Engine Engine { get; set; }

        public Сhassis Chassis { get; set; }

        public Transmission Transmission { get; set; }

        public Transport (Engine engine, Сhassis сhassis, Transmission transmission)
        {
            this.Engine = engine;
            this.Chassis = сhassis;
            this.Transmission = transmission;
        }

        public virtual void PrintTransportValues()
        {
            this.Engine.PrintEngineValues();
            this.Chassis.PrintChassisValues();
            this.Transmission.PrintTransmissionValues();
        } 
   }
}
