using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private const double DefaultFueConsumption = 3;

        public override double FuelConsumption
        {
            get
            {
                return DefaultFueConsumption;
            }
        }
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
    }
}
