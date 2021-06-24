using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }

        public Car(string model, int speed, int power, int weight, string type, 
            double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);

            Tire tire1 = new Tire(tire1Pressure, tire1Age);
            Tire tire2 = new Tire(tire2Pressure, tire2Age);
            Tire tire3 = new Tire(tire3Pressure, tire3Age);
            Tire tire4 = new Tire(tire4Pressure, tire4Age);
            Tires = new Tire[4] { tire1, tire2, tire3, tire4 };
        }

        //public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        //{
        //    Model = model;
        //    Engine = new Engine(engine);
        //    Cargo = new Cargo(cargo);
        //    Tires = tires;
        //}
    }
}
