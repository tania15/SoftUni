using System;
using System.Linq;
using System.Collections.Generic;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>(n);

            for (int i = 0; i < n; i++)
            {
                string[] engine = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = engine[0];
                int power = int.Parse(engine[1]);                
                string displacement = engine.Length == 2 ? "n/a" : (int.TryParse(engine[2], out int d) == true ? engine[2] : "n/a");
                string efficiency = engine.Length == 2 ? "n/a" : (engine.Length == 3 ? (int.TryParse(engine[2], out int p) == true ? "n/a" : engine[2]) : engine[3]);

                engines.Add(new Engine(model, power, displacement, efficiency));
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>(m);

            for (int i = 0; i < m; i++)
            {
                string[] car = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                string weight = car.Length == 2 ? "n/a" : (car.Length == 3 ? (double.TryParse(car[2], out double d) != true ? "n/a" : car[2]) : car[2]);
                string color = car.Length == 2 ? "n/a" : (car.Length == 3 ? (double.TryParse(car[2], out double p) == true ? "n/a" : car[2]) : car[3]);

                cars.Add(new Car(car[0], engines.Where(e => e.Model == car[1]).First(), weight, color));
            }

            foreach (Car c in cars)
            {
                Console.WriteLine(c);
            }
        }
    }
}
