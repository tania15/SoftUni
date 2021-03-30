using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalogue
{
    public class Vehicle
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public Vehicle(string model, string color, int horsePower)
        {           
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
    }
}
