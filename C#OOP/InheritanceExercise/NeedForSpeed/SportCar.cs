using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double DefaultFueConsumption = 10;

        public override double FuelConsumption
        {
            get
            {
                return DefaultFueConsumption;
            }
        }

        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
    }
}
