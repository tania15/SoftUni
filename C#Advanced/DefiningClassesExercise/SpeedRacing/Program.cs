using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] car = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);                    

                cars.Add(new Car(car[0], double.Parse(car[1]), double.Parse(car[2])));
            }

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] car = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car carModel = cars.Where(c => c.Model == car[1]).FirstOrDefault();
                carModel.Drive(double.Parse(car[2]));

                input = Console.ReadLine();
            }           

            foreach (var c in cars)
            {
                string travelled = c.TravelledDistance == 0 ? 0.ToString() : c.TravelledDistance.ToString();

                Console.WriteLine($"{c.Model} {c.FuelAmount:F2} {travelled}");
            }
        }
    }
}
