using System;

namespace OopTask
{
    public class ExecuteThirdTask
    {
        static void Main(string[] args)
        {

            Car car = new Car(new Engine(170, 2.0f, "khg5826", EngineType.Electro),
                              new Сhassis(4, "7777-AT", 120),
                              new Transmission(5, "Company K", TransmissionType.Automatic),
                              "Opel");

            car.PrintTransportValues();

            Truck truck = new Truck(new Engine(200, 2.8f, "lfj4582", EngineType.Petrol),
                                    new Сhassis(8, "5269-MT", 300),
                                    new Transmission(5, "Company S", TransmissionType.Mechanical),
                                    true);

            truck.PrintTransportValues();

            Bus bus = new Bus(new Engine(150, 2.5f, "jfk5987", EngineType.Diesel),
                              new Сhassis(6, "9683-AT", 200),
                              new Transmission(5, "Company A", TransmissionType.Mechanical),
                              64);

            bus.PrintTransportValues();

            Scooter scooter = new Scooter(new Engine(100, 1.3f, "jdgof8584", EngineType.Petrol),
                                          new Сhassis(2, "5936-KD", 70),
                                          new Transmission(2, "Company M", TransmissionType.Automatic),
                                          130);

            scooter.PrintTransportValues();

            Console.ReadKey();
        }
    }
}
