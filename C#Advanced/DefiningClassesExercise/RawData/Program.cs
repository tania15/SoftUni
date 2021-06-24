using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>(n);

            for (int i = 0; i < n; i++)
            {
                string[] car = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = car[0];
                int speed = int.Parse(car[1]);
                int power = int.Parse(car[2]);
                int weight = int.Parse(car[3]);
                string typeCargo = car[4];
                double tire1Pressure = double.Parse(car[5]);
                int tire1Age = int.Parse(car[6]);
                double tire2Pressure = double.Parse(car[7]);
                int tire2Age = int.Parse(car[8]);
                double tire3Pressure = double.Parse(car[9]);
                int tire3Age = int.Parse(car[10]);
                double tire4Pressure = double.Parse(car[11]);
                int tire4Age = int.Parse(car[12]);

                cars.Add(new Car(model, speed, power, weight, typeCargo,
                    tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age));
            }

            string command = Console.ReadLine();

            foreach (Car c in cars)
            {
                bool flag = false;

                if (command.ToLower() == "fragile")
                {
                    flag = (c.Tires.Where(t => t.Pressure < 1).Count() > 0 && c.Cargo.Type == "fragile" ? true : false);
                }
                else
                {
                    flag = (c.Engine.Power > 250 && c.Cargo.Type == "flamable" ? true : false);
                }

                if (flag == true)
                {
                    Console.WriteLine(c.Model);
                }
            }
        }
    }
}

