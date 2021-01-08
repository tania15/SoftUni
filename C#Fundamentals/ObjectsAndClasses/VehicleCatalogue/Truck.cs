using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalogue
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
    }
}
