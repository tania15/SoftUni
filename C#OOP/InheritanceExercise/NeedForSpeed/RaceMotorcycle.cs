using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motocycle
    {
        private const double DefaultFueConsumption = 8;
        public override double FuelConsumption
        {
            get
            {
                return DefaultFueConsumption;
            }
        }
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
    }
}
