using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; } = 0;

        public Car(string model, double fuel, double consumption)
        {
            Model = model;
            FuelAmount = fuel;
            FuelConsumptionPerKilometer = consumption;
        }

        public void Drive(double amoutOfKm)
        {
            if (amoutOfKm * FuelConsumptionPerKilometer <= FuelAmount)
            {
                FuelAmount -= amoutOfKm * FuelConsumptionPerKilometer;
                TravelledDistance += amoutOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
